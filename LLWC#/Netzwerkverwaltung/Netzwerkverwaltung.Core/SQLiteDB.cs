using Netzwerkverwaltung.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkverwaltung.Core
{
    public class SQLiteDB : IList
    {
        private static IList list;
        private string connection = @"URI=file:C:\Users\lwngrmc\source\repos\LLWTest\Database\database.db";

        public static IList GetInstance()
        {
            if (list == null)
                list = new SQLiteDB();

            return list;
        }

        public List<NetworkData> GetAll()
        {
            string sqlstring;
            List<NetworkData> retval = new List<NetworkData>();
            using (var context = new SQLiteConnection(this.connection))
            {
                context.Open();

                sqlstring = "SELECT * FROM Netzwerk";

                using (var command = new SQLiteCommand(sqlstring, context))
                {
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        NetworkData data = new NetworkData()
                        {
                            Id = reader.GetInt32(0),
                            IpAdresse = reader.GetString(1),
                            Name = reader.GetString(2),
                            Gerätetype = reader.GetString(3),
                            Kurzbeschreibung = reader.GetString(4)
                        };

                        retval.Add(data);
                    }
                }
            }
            return retval;
        }

        public NetworkData GetById(NetworkData data)
        {
            string sqlstring;
            NetworkData retval = new NetworkData();

            using (var context = new SQLiteConnection(this.connection))
            {
                context.Open();

                sqlstring = "SELECT * FROM Netzwerk WHERE Id = @Id";

                using (var command = new SQLiteCommand(sqlstring, context))
                {
                    command.Parameters.Add("@Id", DbType.Int32, 100).Value = data.Id;

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        retval.Id = (int)reader.GetValue(0);
                        retval.IpAdresse = reader.GetString(1);
                        retval.Name = reader.GetString(2);
                        retval.Gerätetype = reader.GetString(3);
                        retval.Kurzbeschreibung = reader.GetString(4);
                    }
                }
            }
            return retval;
        }

        public void Insert(NetworkData data)
        {
            string sqlstring;

            using (var context = new SQLiteConnection(this.connection))
            {
                context.Open();

                sqlstring = "INSERT INTO Netzwerk (IP, Name, Device, Description) VALUES (@IP, @Name, @Device, @Description)";

                using (var command = new SQLiteCommand(sqlstring, context))
                {
                    command.Parameters.Add("@IP", DbType.String, 50).Value = data.IpAdresse;
                    command.Parameters.Add("@Name", DbType.String, 100).Value = data.Name;
                    command.Parameters.Add("@Device", DbType.String, 100).Value = data.Gerätetype;
                    command.Parameters.Add("@Description", DbType.String, 100).Value = data.Kurzbeschreibung;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(NetworkData data)
        {
            string sqlstring;

            using (var context = new SQLiteConnection(this.connection))
            {
                context.Open();

                sqlstring = "UPDATE Netzwerk SET IP = @IP, Name = @Name, Device = @Device WHERE Id = @Id";

                using (var command = new SQLiteCommand(sqlstring, context))
                {
                    command.Parameters.Add("@Id", DbType.Int32, 100).Value = data.Id;
                    command.Parameters.Add("@IP", DbType.String, 50).Value = data.IpAdresse;
                    command.Parameters.Add("@Name", DbType.String, 100).Value = data.Name;
                    command.Parameters.Add("@Device", DbType.String, 100).Value = data.Gerätetype;
                    command.Parameters.Add("@Description", DbType.String, 100).Value = data.Kurzbeschreibung;

                    command.ExecuteNonQuery();
                }
            }

        }

        public void Delte(NetworkData data)
        {
            string sqlstring;

            using (var context = new SQLiteConnection(this.connection))
            {
                context.Open();

                sqlstring = "DELETE FROM Netzwerk WHERE Id = @Id";

                using (var command = new SQLiteCommand(sqlstring, context))
                {

                    command.Parameters.Add("@Id", DbType.Int32, 100).Value = data.Id;

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<NetworkData> SearchByDevice(string device)
        {
            List<NetworkData> retval = new List<NetworkData>();

            string sqlstring;

            using (var context = new SQLiteConnection(this.connection))
            {
                context.Open();

                sqlstring = "SELECT * FROM Netzwerk WHERE Device = @Device";

                using (var command = new SQLiteCommand(sqlstring, context))
                {
                    command.Parameters.Add("@Device", DbType.String, 100).Value = device;

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        NetworkData network = new NetworkData()
                        {
                            Id = reader.GetInt32(0),
                            IpAdresse = reader.GetString(1),
                            Name = reader.GetString(2),
                            Gerätetype = reader.GetString(3),
                            Kurzbeschreibung = reader.GetString(4)
                        };

                        retval.Add(network);
                    }
                }
            }
            return retval;
        }
    }
}
