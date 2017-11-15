using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Entities;

namespace DivisaSolution.DataAccess
{
    public class XmlFileRepository : IRepository
    {
        XmlDocument doc = new XmlDocument();

        public List<Currency> GetAllCurrencies()
        {
            doc.Load("currency.xml");
            throw new NotImplementedException();
        }
    }
}
