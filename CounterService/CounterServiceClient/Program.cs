using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterServiceClient.ServiceCounterReference;

namespace CounterServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            int value = client.GetCounter(false);
            Console.WriteLine("Valor = " + value);
        }
    }
}
