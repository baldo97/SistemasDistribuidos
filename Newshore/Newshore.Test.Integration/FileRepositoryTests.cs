using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newshore.Data;
using NUnit.Framework;

namespace Newshore.Test.Integration
{
    public class FileRepositoryTests
    {
        [Test, ExpectedException(typeof(FileNotFoundException))]
        public void GetSuperPoweredEntitiesCanNotRead()
        {
            var dataService = new FileRepository();
            var list = dataService.GetDataList("NOFILE");
        }

        [Test]
        public void GetSuperPoweredEntitiesCanRead()
        {
            var dataService = new FileRepository();
            var list = dataService.GetDataList("REGISTRADOS.DAT");
            Assert.IsTrue(list.ToList().Count > 0);
        }
    }
}
