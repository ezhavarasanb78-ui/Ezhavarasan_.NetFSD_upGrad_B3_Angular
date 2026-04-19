using Contactservice.Models;
using Contactservice.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contactservice.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactController:ControllerBase
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            => Ok(await _service.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            await _service.AddAsync(contact);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Contact contact)
        {
            await _service.UpdateAsync(contact);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
