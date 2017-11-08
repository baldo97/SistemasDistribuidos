using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NewshoreWebService
{
    [DataContract]
    public class PersonList
    {
        public IEnumerable<PersonType> List { get; set; }
    }

    public class PersonType 
    {
        [DataMember(Name = "name")]
        public string Name;

        
    }
}