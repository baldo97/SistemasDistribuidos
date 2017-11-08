using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newshore.Common
{
    public class AppConfiguration : IAppConfiguration
    {
        public string GetRegistradosRepo() 
        {
            return ConfigurationManager.AppSettings["FileToRead"] ?? "";
        }

        public string GetSuperHeroRepo()
        {
            return ConfigurationManager.AppSettings["FileSuperHeroe"] ?? ""; 
        }

        public string GetVillansrepo()
        {
            return ConfigurationManager.AppSettings["FileVillans"] ?? "";
        }

        public string GetRuleForVillains()
        {
            return ConfigurationManager.AppSettings["RuleForVillains"] ?? "";
        }
        
    }
}
