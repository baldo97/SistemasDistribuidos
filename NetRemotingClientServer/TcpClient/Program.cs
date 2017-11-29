using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetRemotingClientServer;

namespace TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Connect("127.0.0.1", "This is a test");
            
        }
    }
}
