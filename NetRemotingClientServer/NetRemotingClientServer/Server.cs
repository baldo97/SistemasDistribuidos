using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetRemotingClientServer
{
    public class Server
    {
        public static int UsedThreads = 0;
        public static int MaxThreads = 5;
        public static object Locker = new object();
        public static void StartServer()
        {
            TcpListener server = null;
            // Set the TcpListener on port 13000.
            Int32 port = 5000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            // TcpListener server = new TcpListener(port);
            server = new TcpListener(localAddr, port);

            // Start listening for client requests.
            server.Start();

            // Enter the listening loop.
            while (UsedThreads < MaxThreads)
            {
                lock (Server.Locker)
                {
                    Server.UsedThreads += 1;
                }
                Thread th = new Thread(() => ServerRequest.Request(server));
                th.Start();
                    
            }
        }
    }
}

//Interlocked.Increment(ref usedThreads);
//                    Thread th = new Thread(() => ProcessTcpRequest.Request(server));
//th.Start();

