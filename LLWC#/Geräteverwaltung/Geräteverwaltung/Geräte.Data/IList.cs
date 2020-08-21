using Geräte.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geräte.Data
{
    public interface IList
    {
        List<Device> GetAll();
        Device GetByID(Device data);

        void Insert(Device data);
        void Update(Device data);
        void Delete(Device data);
    }
}
