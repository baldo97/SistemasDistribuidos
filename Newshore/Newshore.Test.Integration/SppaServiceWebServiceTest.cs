using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newshore.Test.Integration.SspaServiceReference;
using NewshoreWebService;
using NUnit.Framework;

namespace Newshore.Test.Integration
{
    //Tests for SOAP Service
    public class SppaServiceWebServiceTest
    {
        [Test]
        public void GetAllSuperPoweredEntitiesRequest()
        {
            var service = new SspaService();
            var listPeople = service.GetAllSuperPoweredEntities();
            Assert.IsTrue(listPeople.Any());
        }

        [Test]
        public void GetAllSuperHeroesRequest()
        {
            var service = new SspaService();
            var listPeople = service.GetAllSuperHeroes();
            Assert.IsTrue(listPeople.Any());

        }

        [Test]
        public void GetAllVillainsRequest()
        {
            var service = new SspaService();
            var listPeople = service.GetAllVillains();
            Assert.IsTrue(listPeople.Any());

        }
    }
}
