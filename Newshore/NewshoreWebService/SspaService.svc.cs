using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newshore.Service;
using StructureMap;

namespace NewshoreWebService
{
    /// <summary>
    /// Service to retrieve super powered people by types
    /// </summary>
    public class SspaService : ISoapService , IRestService
    {
        private readonly IServiceRead _dataServiceRead = null;

        public SspaService()
        {
            ProjectRegistry.InitIoC();
            _dataServiceRead = ObjectFactory.GetInstance<IServiceRead>();
        }

        public IEnumerable<PersonType> GetAllSuperPoweredEntities()
        {
            return _dataServiceRead.GetAllSuperPoweredEntities().Select(x => new PersonType {Name = x.Name});
        }

        public IEnumerable<PersonType> GetAllSuperHeroes()
        {
            return _dataServiceRead.GetSuperHeroes().Select(x => new PersonType { Name = x.Name });
        }

        public IEnumerable<PersonType> GetAllVillains()
        {
            return _dataServiceRead.GetVillains().Select(x => new PersonType { Name = x.Name });
        }
    }
}
