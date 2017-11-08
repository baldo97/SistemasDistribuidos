using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newshore.Common;
using Newshore.Data;

namespace Newshore.Service
{
    public class SplitService : IServiceSplit
    {
        private readonly IServiceRead _readService;
        private readonly IRepository<string> _dataAccess;
        private readonly IAppConfiguration _appConfig;

        public SplitService(IRepository<string> dataAccess, IServiceRead readService,IAppConfiguration appConfig)
        {
            Require.ArgumentNotNull(dataAccess, "IDataService dataAccess");
            Require.ArgumentNotNull(readService, "IServiceRead readService");
            Require.ArgumentNotNull(dataAccess, "IAppConfiguration appConfig");
            _readService = readService;
            _dataAccess = dataAccess;
            _appConfig = appConfig;
        }

        //Splits all super powered people ito groups
        public void SplitSuperPoweredIntoGroups()
        {
            string rule = _appConfig.GetRuleForVillains();
            var listPeople = _readService.GetAllSuperPoweredEntities().ToList();

            var listVillans = listPeople.Where(x => x.Name.Contains(rule)).Select(x => x.Name);
            _dataAccess.SaveDataList(listVillans.ToList(), _appConfig.GetVillansrepo());

            var listSuperHeroes = listPeople.Where(x => !x.Name.Contains(rule)).Select(x => x.Name);
            _dataAccess.SaveDataList(listSuperHeroes.ToList(), _appConfig.GetSuperHeroRepo());
        }
    }
}
