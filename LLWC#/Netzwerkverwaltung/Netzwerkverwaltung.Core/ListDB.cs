using Netzwerkverwaltung.Data;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkverwaltung.Core
{
    public class ListDB : IList
    {
        private List<NetworkData> dblist;
        private static IList list;

        public ListDB()
        {
            dblist = new List<NetworkData>();
        }

        public static IList GetInstance()
        {
            if (list == null)
                list = new ListDB();

            return list;
        }

        public void Delte(NetworkData data)
        {
            dblist.Remove(data);
        }

        public List<NetworkData> GetAll()
        {
            return dblist;
        }

        public NetworkData GetById(NetworkData data)
        {
            return dblist.FirstOrDefault(x => x.Id == data.Id);
        }

        public void Insert(NetworkData data)
        {
            dblist.Add(data);
        }

        public void Update(NetworkData data)
        {
            var n = dblist.FirstOrDefault(x => x.Id == data.Id);


            n.Id = data.Id;
            n.Name = data.Name;
            n.IpAdresse = data.IpAdresse;
            n.Gerätetype = data.Gerätetype;
            n.Kurzbeschreibung = data.Kurzbeschreibung;
        }

        public List<NetworkData> SearchByDevice(string Device)
        {
            List<NetworkData> retval = new List<NetworkData>();

            foreach (var item in dblist.Where(x => x.Gerätetype.ToUpper() == Device.ToUpper()))
            {
                retval.Add(item);
            }
            return retval;
        }
    }
}
