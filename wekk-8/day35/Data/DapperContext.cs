using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace CMS.Data
{
    public class DapperContext
    {
        private readonly IConfiguration _config;
        private readonly string _constr;
        public DapperContext(IConfiguration config)
        {
            _config = config;
            _constr = _config.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_constr);
    }
}
