using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IMovieTicketInterface
    {
        string GetTicketStatus(string stringToPrint);
    }

    public class MovieTicket : MarshalByRefObject, IMovieTicketInterface
    {

        public string GetTicketStatus(string stringToPrint)
        {
            string returnStatus = "Ticket Confirmed";
            Console.WriteLine("Enquiry for {0}", stringToPrint);
            Console.WriteLine("Sending back status: {0}", returnStatus);

            return returnStatus;
        }

    }
}
