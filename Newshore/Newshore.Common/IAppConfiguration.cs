using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newshore.Common
{
    public interface IAppConfiguration
    {
        string GetRegistradosRepo();
        string GetSuperHeroRepo();
        string GetVillansrepo();
        string GetRuleForVillains();
    }
}
