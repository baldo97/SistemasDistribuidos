using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetRemotingClientServer
{
    public class ProcessTcpRequest
    {
        public static void Request(TcpListener server)
        {
            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String data = null;
            Console.WriteLine("Thread Listening: {0}", System.Threading.Thread.CurrentThread.Name);
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Connected!");

            data = null;

            // Get a stream object for reading and writing
            NetworkStream stream = client.GetStream();

            int i;

            // Loop to receive all the data sent by the client.
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                Console.WriteLine("Received: {0}", data);

                // Process the data sent by the client.
                data = data.ToUpper();

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                // Send back a response.
                stream.Write(msg, 0, msg.Length);
                Console.WriteLine("Sent: {0}", data);
            }

            // Shutdown and end connection
            client.Close();
        }
    }
}
