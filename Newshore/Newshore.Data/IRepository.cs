using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Newshore.Data
{
	
    /// <summary>
    /// Interface to be implemented for a repository.
    /// </summary>
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetDataList(string fileName);
        void SaveDataList(IEnumerable<TEntity> list, string targetFileName);
    }
}
