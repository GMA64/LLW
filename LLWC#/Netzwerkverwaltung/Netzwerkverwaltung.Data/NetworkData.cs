using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkverwaltung.Data
{
    public class NetworkData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAdresse { get; set; }
        public string Gerätetype { get; set; }
        public string Kurzbeschreibung { get; set; }
    }
}
