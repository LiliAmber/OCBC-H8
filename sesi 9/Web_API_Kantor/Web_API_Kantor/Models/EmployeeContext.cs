using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Kantor.Models
{
    public class EmployeeContext
    {
        //public EmployeeContext()
        //{
        //}

        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        //FUNCTION TO GET ALL EMPLOYEES
        public List<EmployeeItem> GetEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenis_kelmain = reader.GetString("jenis_kelmain"),
                            alamat = reader.GetString("alamat")

                        });
                    }
                }
            }
            return list;
        }

        //FUNCTION TO GET EMPLOYEE BY ID
        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using(MySqlConnection conn = GetConnnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id =@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenis_kelmain = reader.GetString("jenis_kelmain"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }

            return list;
        }
    }
}
