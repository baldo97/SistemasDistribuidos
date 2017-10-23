using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CounterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static string file = System.Configuration.ConfigurationManager.AppSettings["counterfile"];
        static int  stateLess = 0;
        static int nostateless = Convert.ToInt16(System.IO.File.ReadAllText(file));

        public int GetCounter(bool stateless)
        {
            if (stateless)
            {
                stateLess += 1;
                return stateLess;
            }
            else
            {
                nostateless += 1;
                System.IO.File.WriteAllText(file, nostateless.ToString());
                return nostateless;
            }
        }

    }
}
