using CMS.Data;
using CMS.Models;
using Dapper;

namespace CMS.Repository
{
    public class ContactRepository:IContactRepository
    {
        private readonly DapperContext _context;
        public ContactRepository(DapperContext context)
        {
            _context = context;
        }
        public IEnumerable<ContactInfo> GetAll()
        {
            string query = @"select c.* co.CompanyName,d.DepartmentName 
              from ContactInfo c 
              inner join Company co on c.CompanyId=co.cId
              left join Department d on c.DepartmentId=d.dId";
            using var connection = _context.CreateConnection();
            return connection.Query<ContactInfo>(query);
        }
        public ContactInfo GetContactById(int id)
        {
            string query = "select * from ContactInfo where ContactId=@id";
            using var connection = _context.CreateConnection();
            return connection.QueryFirstOrDefault<ContactInfo>(query, new { Id = id });

        }
        public void AddContact(ContactInfo c)
        {
            string query = @"insert into ContactInfo(FirstName,LastName,EmailId,MobileNo,Designation,cId,dId) values(@FirstName,@LastName,@EmailId,@MobileNo,@Designation,@cId,@dId)";
            using var connection = _context.CreateConnection();
            connection.Execute(query, c);
        }
        public void EditContact(ContactInfo c)
        {
            string query = @"
              UPDATE ContactInfo SET
              FirstName = @FirstName,
              LastName = @LastName,
              EmailId = @EmailId,
              MobileNo = @MobileNo,
              Designation = @Designation,
              cId = @cId,
              dId = @dId
              WHERE ContactId = @ContactId";
              using var connection = _context.CreateConnection();
              connection.Execute(query, c);
        }
        public void DeleteContact(int id)
        {
            string query = "delete * from ContactInfo where ContactId=@id";
            using var connection = _context.CreateConnection();
            connection.Execute(query, new { Id = id });
        }
        public IEnumerable<Company> GetCompanies()
        {
            using var connection = _context.CreateConnection();
            return connection.Query<Company>("select * from Company");
        }
        public IEnumerable<Department> GetDepartments()
        {
            using var connection = _context.CreateConnection();
            return connection.Query<Department>("select * from Department");
        }
    }
}
