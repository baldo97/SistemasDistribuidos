using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newshore.Common;
using Newshore.Data;
using Newshore.Entities;
using Newshore.Service;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace Newshore.Service
{
    /// <summary>
    /// Uses structure map to build dependancies
    /// </summary>
    public class ProjectRegistry : Registry
    {        
        public static void InitIoC()
        {
            ObjectFactory.Configure(config =>
                {
                    config.Scan(scan => scan.WithDefaultConventions());
                    config.For<IRepository<string>>().Use<FileRepository>();
                    config.For<IServiceRead>().Use<SppaService>();
                    config.For<IServiceSplit>().Use<SplitService>();
                    config.For<IAppConfiguration>().Use<AppConfiguration>();
                });
        }
    }
}
