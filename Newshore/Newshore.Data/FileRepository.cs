using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newshore.Common;

namespace Newshore.Data
{
    /// <summary>
    /// Provides access to the data store in files
    /// </summary>
    public class FileRepository: IRepository<string>
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FileRepository));

        //Retrieve list of entities from disk
        public IEnumerable<string> GetDataList(string fileName)
        {
            var list = new List<string>();

            try
            {
                var file = new System.IO.StreamReader(fileName);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    list.Add(line);
                }
                file.Close();
            }
            catch (Exception e)
            {
                Logger.ErrorFormat("Error while opening and reading file", fileName);
                throw;
            }            

            return list;
        }

        //Persist list of entities to disk
        public void SaveDataList(IEnumerable<string> list, string targetFileName)
        {
            try
            {
                var file = new System.IO.StreamWriter(targetFileName);
                foreach (var item in list)
                {
                    file.WriteLine(item);
                }
                file.Close();
            }
            catch (Exception)
            {
                Logger.ErrorFormat("Error while opening and writing file", targetFileName);
                throw;
            }
            
        }

    }
}
