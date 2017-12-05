using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.TicketServer();

        }

        static void TicketServer()
        {
            Console.WriteLine("Ticket Server started...");
            TcpChannel tcpChannel = new TcpChannel(8000);
            ChannelServices.RegisterChannel(tcpChannel);

            Type commonInterfaceType = Type.GetType("Server.MovieTicket");

            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
            "MovieTicketBooking", WellKnownObjectMode.SingleCall);

            System.Console.WriteLine("Press ENTER to quitnn");
            System.Console.ReadLine();

        }
    }
}
