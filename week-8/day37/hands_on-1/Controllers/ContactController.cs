using Microsoft.AspNetCore.Mvc;
using WebAPI.DataAccess;
using WebAPI.Models;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController:ControllerBase
    {
        private readonly IContactRepository _repo;
        public ContactController (IContactRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _repo.GetAllAsync();
            return Ok(contacts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int id)
        {
            var contact = await _repo.GetbyIdAsync(id);
            if(contact==null)
            {
                return NotFound();
            }
            return Ok(contact);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(ContactInfo ci)
        {
            if(ci==null)
            {
                return BadRequest("Invalid Data");

            }
            var created = await _repo.AddAsync(ci);
            return CreatedAtAction(nameof(GetById), new { id = created.ContactId }, created);
        }
        [HttpPut ("{id}")]
        public async Task<IActionResult> EditAsync(int id,ContactInfo ci)
        {
            var update = await _repo.UpdateAsync(id, ci);
            if (update == null)
            {
                return NotFound();
            }
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var delete = await _repo.DeleteAsync(id);
            if(delete==null)
            {
                return NotFound();
            }
            return Ok("deleted Successfully");
        }
    }
}
