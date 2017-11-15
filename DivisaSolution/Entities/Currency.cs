using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Currency
    {
        string from = "";
        string to = "";
        double rate = 0;

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        public string To
        {
            get { return to; }
            set { to = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

    }
}
