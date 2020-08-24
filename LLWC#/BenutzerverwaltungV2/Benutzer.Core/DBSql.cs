using Benutzer.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Benutzer.Core
{
    public class DBSql : IList
    {
        private string ConnectionString = "Data Source=lwnsvlehrling01;Initial Catalog=lwngrmc;Integrated Security=True";
        private static IList list;

        public static IList GetInstance()
        {
            if (list == null)
                list = new DBSql();

            return list;
        }

        public void Delete(Users data)
        {
            using (var context = new SqlConnection(this.ConnectionString))
            {
                context.Open();

                using (var command = new SqlCommand("DELETE FROM Users WHERE Id = @Id", context))
                {
                    command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 500).Value = data.id;

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Users> GetAll()
        {
            List<Users> retval = new List<Users>();
            using (var context = new SqlConnection(this.ConnectionString))
            {
                context.Open();

                using (var command = new SqlCommand("SELECT * FROM Users", context))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Users user = new Users()
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1),
                            address = reader.GetString(2),
                            city = reader.GetString(3),
                            telephone = reader.GetString(4),
                            email = reader.GetString(5)
                        };

                        retval.Add(user);
                    }
                }

                return retval;
            }
        }

        public Users GetById(Users data)
        {
            Users retval = new Users();

            using (var context = new SqlConnection(this.ConnectionString))
            {
                context.Open();

                using (var command = new SqlCommand("SELECT * FROM Users WHERE Id = @Id", context))
                {
                    command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 500).Value = data.id;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        retval.id = reader.GetInt32(0);
                        retval.name = reader.GetString(1);
                        retval.address = reader.GetString(2);
                        retval.city = reader.GetString(3);
                        retval.telephone = reader.GetString(4);
                        retval.email = reader.GetString(5);
                    }
                }
            }
            return retval;
        }

        public void Insert(Users data)
        {
            using (var context = new SqlConnection(this.ConnectionString))
            {
                context.Open();

                using (var command = new SqlCommand("INSERT INTO Users (id, name, address, city, telephone, mail) VALUES (@id, @name, @address, @city, @telephone, @mail)", context))
                {
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int, 500).Value = data.id;
                    command.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 50).Value = data.name;
                    command.Parameters.Add("@address", System.Data.SqlDbType.VarChar, 50).Value = data.address;
                    command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 50).Value = data.city;
                    command.Parameters.Add("@telephone", System.Data.SqlDbType.VarChar, 50).Value = data.telephone;
                    command.Parameters.Add("@mail", System.Data.SqlDbType.VarChar, 50).Value = data.email;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Users data)
        {
            using (var context = new SqlConnection(this.ConnectionString))
            {
                context.Open();

                using (var command = new SqlCommand("UPDATE Users SET name = @name, address = @address, city = @city, telephone = @telephone, mail = @mail WHERE id = @id"))
                {
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int, 500).Value = data.id;

                    command.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 50).Value = data.name;
                    command.Parameters.Add("@address", System.Data.SqlDbType.VarChar, 50).Value = data.address;
                    command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 50).Value = data.city;
                    command.Parameters.Add("@telephone", System.Data.SqlDbType.VarChar, 50).Value = data.telephone;
                    command.Parameters.Add("@mail", System.Data.SqlDbType.VarChar, 50).Value = data.email;

                    command.ExecuteNonQuery();
                }
            }
        }
    }

}

