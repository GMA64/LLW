using Netzwerkverwaltung.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkverwaltung.Core
{
    public interface IList
    {
        List<NetworkData> GetAll();
        NetworkData GetById(NetworkData data);

        void Insert(NetworkData data);
        void Update(NetworkData data);
        void Delte(NetworkData data);

        List<NetworkData> SearchByDevice(string Device);
    }
}
