using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace NewshoreWebService
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract(Name = "GetAllSuperPoweredEntitiesXml")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml)]
        IEnumerable<PersonType> GetAllSuperPoweredEntities();

        [OperationContract(Name = "GetAllSuperHeroesXml")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml)]
        IEnumerable<PersonType> GetAllSuperHeroes();

        [OperationContract(Name = "GetAllVillainsXml")]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml)]
        IEnumerable<PersonType> GetAllVillains();
    }
}