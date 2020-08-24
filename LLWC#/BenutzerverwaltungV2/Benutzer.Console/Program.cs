using Benutzer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benutzer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in DBSql.GetInstance().GetAll())
            {
                System.Console.WriteLine(item.id +"|"+ item.name +"|"+ item.address +"|"+item.telephone +"|"+ item.email);
            }

            System.Console.ReadKey();


        }
    }
}
