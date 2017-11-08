using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using NewshoreWebService;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Newshore.Test.Integration
{
    //Tests for REST Service
    public class SppaRestServiceTest
    {
        [Test]
        public void GetAllSuperPoweredEntitiesRequest()
        {
            var restProxy = new WebClient();
            byte[] data = restProxy.DownloadData(new Uri("http://localhost:59518/SspaService.svc/rest/GetAllSuperPoweredEntitiesJson"));
            Stream stream = new MemoryStream(data);
            var reader = new StreamReader(stream);
            string jsonString = reader.ReadToEnd();

            var resultPeople = JsonConvert.DeserializeObject<PersonType[]>(jsonString);
            Assert.IsTrue(resultPeople.Any());
        }

        [Test]
        public void GetAllSuperHeroesRequest()
        {
            var restProxy = new WebClient();
            byte[] data = restProxy.DownloadData(new Uri("http://localhost:59518/SspaService.svc/rest/GetAllSuperHeroesJson"));
            Stream stream = new MemoryStream(data);
            var reader = new StreamReader(stream);
            string jsonString = reader.ReadToEnd();

            var resultPeople = JsonConvert.DeserializeObject<PersonType[]>(jsonString);
            Assert.IsTrue(resultPeople.Any());
        }

        [Test]
        public void GetAllVillansEntitiesRequest()
        {
            var restProxy = new WebClient();
            byte[] data = restProxy.DownloadData(new Uri("http://localhost:59518/SspaService.svc/rest/GetAllVillainsJson"));
            Stream stream = new MemoryStream(data);
            var reader = new StreamReader(stream);
            string jsonString = reader.ReadToEnd();

            var resultPeople = JsonConvert.DeserializeObject<PersonType[]>(jsonString);
            Assert.IsTrue(resultPeople.Any());
        }

       
    }
}
