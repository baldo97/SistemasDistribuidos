using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);

            Type requiredType = typeof(IMovieTicketInterface);

            IMovieTicketInterface remoteObject = (IMovieTicketInterface)Activator.GetObject(requiredType,
            "tcp://localhost:8000/MovieTicketBooking");

            string respose = remoteObject.GetTicketStatus("Ticket No: " + this.txt_TicketNumber);
            this.txt_Response.Text = respose;

        }
    }
}
