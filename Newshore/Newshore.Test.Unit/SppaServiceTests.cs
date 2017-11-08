using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newshore.Common;
using Newshore.Data;
using Newshore.Entities;
using Newshore.Service;
using NUnit.Framework;
using Rhino.Mocks;
using StructureMap;

namespace Newshore.Test.Unit
{
    public class SppaServiceTests : TestBase
    {		

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorIsNull()
        {
            var sppaService = new SppaService(null,null);
        }

        [Test]
        public void GetAllSuperPoweredEntitiesTests()
        {
            var mockDataAccess = Mocks.Stub<IRepository<string>>();
            var mockAppConfiguration = Mocks.Stub<IAppConfiguration>();

            var sppaService = new SppaService(mockDataAccess, mockAppConfiguration);
            
            
            using (Mocks.Record())
            {
                SetupResult.For(mockAppConfiguration.GetRegistradosRepo()).Return("");
                SetupResult.For(mockDataAccess.GetDataList("")).Return(GetFake<string>(10));
            }

            Assert.AreEqual(sppaService.GetAllSuperPoweredEntities().Count(), 10);
        }

        [Test]
        public void GetAllSuperHeroesEntitiesTests()
        {
            var mockDataAccess = Mocks.Stub<IRepository<string>>();
            var mockAppConfiguration = Mocks.Stub<IAppConfiguration>();

            var sppaService = new SppaService(mockDataAccess, mockAppConfiguration);

            using (Mocks.Record())
            {
                SetupResult.For(mockAppConfiguration.GetSuperHeroRepo()).Return("");
                SetupResult.For(mockDataAccess.GetDataList("")).Return(GetFake<string>(10));
            }
            Assert.AreEqual(sppaService.GetSuperHeroes().Count(), 10);
        }

        [Test]
        public void GetAllSuperVillansEntitiesTests()
        {
            var mockDataAccess = Mocks.Stub<IRepository<string>>();
            var mockAppConfiguration = Mocks.Stub<IAppConfiguration>();

            var sppaService = new SppaService(mockDataAccess, mockAppConfiguration);

            using (Mocks.Record())
            {
                SetupResult.For(mockAppConfiguration.GetVillansrepo()).Return("");
                SetupResult.For(mockDataAccess.GetDataList("")).Return(GetFake<string>(10));
            }
            Assert.AreEqual(sppaService.GetVillains().Count(), 10);
        }
       
    }
}
