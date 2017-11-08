using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newshore.Common;
using Newshore.Data;
using Newshore.Entities;
using Newshore.Service;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Rhino.Mocks;
using StructureMap;

namespace Newshore.Test.Unit
{
    public class SplitServiceTest : TestBase
    {

        [Test]
        public void SplitSuperPoweredIntoGroupsTest()
        {
            var mockDataAccess = Mocks.Stub<IRepository<string>>();
            var mockServiceRead = Mocks.Stub<IServiceRead>();
            var mockAppConfiguration = Mocks.Stub<IAppConfiguration>();
            var serviceSplit = new SplitService(mockDataAccess, mockServiceRead, mockAppConfiguration);

            using (Mocks.Record())
            {
                SetupResult.For(mockAppConfiguration.GetRuleForVillains()).Return("");
                SetupResult.For(mockServiceRead.GetAllSuperPoweredEntities()).Return(GetFake<Person>(3));
                SetupResult.For(mockServiceRead.GetSuperHeroes()).Return(GetFake<Person>(5));
                SetupResult.For(mockServiceRead.GetVillains()).Return(GetFake<Person>(10));
            }

            serviceSplit.SplitSuperPoweredIntoGroups();
            Assert.IsTrue(true);
        }

    }
}
