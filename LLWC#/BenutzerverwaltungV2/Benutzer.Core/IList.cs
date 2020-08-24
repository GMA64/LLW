using Benutzer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benutzer.Core
{
    public interface IList
    {
        List<Users> GetAll();
        Users GetById(Users data);

        void Insert(Users data);
        void Update(Users data);
        void Delete(Users data);
    }
}
