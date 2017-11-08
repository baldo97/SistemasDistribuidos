using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newshore.Common;
using Newshore.Data;
using Newshore.Entities;

namespace Newshore.Service
{
    /// <summary>
    /// Service providing access to the list of Super Powered People
    /// </summary>
    public class SppaService : IServiceRead
    {
        private readonly IRepository<string> _dataAccess;
        private readonly IAppConfiguration _appConfig;

        public SppaService(IRepository<string> dataAccess,IAppConfiguration appConfig) 
        {
            Require.ArgumentNotNull(dataAccess, "IDataService dataAccess");
            Require.ArgumentNotNull(dataAccess, "IAppConfiguration appConfig");
            _dataAccess = dataAccess;
            _appConfig = appConfig;
        }

        //Returns every single person is Super Powered People list
        public IEnumerable<Person> GetAllSuperPoweredEntities()
        {
            var listPeople = _dataAccess.GetDataList(_appConfig.GetRegistradosRepo()).Select(x => new Person { Name = x });
            return listPeople;
        }

        //Returns every single Villain in Super Powered People list
        public IEnumerable<Person> GetVillains()
        {
            return _dataAccess.GetDataList(_appConfig.GetVillansrepo()).Select(x => new Person { Name = x });
        }

        //Returns every single Heroe in Super Powered People list
        public IEnumerable<Person> GetSuperHeroes()
        {
            return _dataAccess.GetDataList(_appConfig.GetSuperHeroRepo()).Select(x => new Person { Name = x });
        }

    }
}
