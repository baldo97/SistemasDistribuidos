using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newshore.Entities;

namespace Newshore.Service
{
    public interface IServiceRead
    {
        IEnumerable<Person> GetAllSuperPoweredEntities();
        IEnumerable<Person> GetVillains();
        IEnumerable<Person> GetSuperHeroes();
    }
}
