using Geräte.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Geräte.Data
{
    public class ListDB : IList
    {
        private List<Device> dblist;
        private static IList list;
        public ListDB()
        {
            dblist = new List<Device>();
        }

        public static IList GetInstance()
        {
            if (list == null)
                list = new ListDB();

            return list;
        }

        public void Delete(Device data)
        {
            dblist.Remove(data);
        }

        public List<Device> GetAll()
        {
            return dblist;
        }

        public Device GetByID(Device data)
        {
            return dblist.FirstOrDefault(x => x.Id == data.Id);
        }

        public void Insert(Device data)
        {
            dblist.Add(data);
        }

        public void Update(Device data)
        {
            var i = dblist.FirstOrDefault(x => x.Id == data.Id);

            i.Id = data.Id;
            i.Manufacturere = data.Manufacturere;
            i.DeviceName = data.DeviceName;
            i.DeviceType = data.DeviceType;
        }
    }
}
