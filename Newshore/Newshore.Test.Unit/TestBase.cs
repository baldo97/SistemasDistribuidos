using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newshore.Data;
using Newshore.Entities;
using Newshore.Service;
using Ploeh.AutoFixture;
using Rhino.Mocks;
using StructureMap;

namespace Newshore.Test.Unit
{
    public class TestBase
    {
        internal Container Container = null;
        internal MockRepository Mocks = null;
        internal Fixture Fixture = null;

        public TestBase()
        {
            Mocks = new MockRepository();
            Fixture = new Fixture();
            LoadDependancies();
        }

        //Defining dependancies
        private void LoadDependancies()
        {
            Service.ProjectRegistry.InitIoC();            
        }

        internal IEnumerable<T> GetFake<T>(int count)
        {
            var list = new List<T>();
            Fixture.AddManyTo(list,count);
            return list;
        }
    }
}
