using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NewshoreWebService
{
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract(Name = "GetAllSuperPoweredEntitiesJson")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PersonType> GetAllSuperPoweredEntities();

        [OperationContract(Name = "GetAllSuperHeroesJson")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PersonType> GetAllSuperHeroes();

        [OperationContract(Name = "GetAllVillainsJson")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PersonType> GetAllVillains();
    }    
}
