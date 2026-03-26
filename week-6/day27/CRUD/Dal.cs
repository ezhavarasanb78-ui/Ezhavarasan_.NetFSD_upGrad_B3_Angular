using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CRUD
{
    internal class Dal
    {
        private readonly string connectionstring;

        public Dal()
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("D:\\C#\\CRUD\\CRUD\\appsettings.json").Build();
            connectionstring = config.GetConnectionString("DefaultConnection");
        }
        public void inspro( Model m)
        {
            using(SqlConnection con =new SqlConnection(connectionstring))
                using(SqlCommand cmd=new SqlCommand("inspro",con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Productname", m.Productname);
                cmd.Parameters.AddWithValue("@Category", m.Category);
                cmd.Parameters.AddWithValue("@Price", m.Price);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void uppro(Model m)
        {
            using(SqlConnection con=new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand("updall",con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Productid", m.Productid);
                cmd.Parameters.AddWithValue("@Productname", m.Productname);
                cmd.Parameters.AddWithValue("@Category", m.Category);
                cmd.Parameters.AddWithValue("@Price", m.Price);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<Model> getAll()
        {
            List <Model>li = new List<Model>();
            using (SqlConnection con = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand("getall", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    li.Add(new Model
                    {
                        Productid = (int)r["Productid"],
                        Productname = r["Productname"].ToString(),
                        Category = r["Category"].ToString(),
                        Price = (decimal)r["Price"]
                    });
                }
            }
            return li;
        }
        public void del(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand("delall", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Productid", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
