using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public partial class ChatForm : Form , IQuickReturnTraderChat
    {
        public ChatForm()
        {
            InitializeComponent();
            StartService();
        }
       
        IQuickReturnTraderChat channel;
        ServiceHost host = null;
        ChannelFactory<IQuickReturnTraderChat> channelFactory = null;
        string userID = Environment.UserName;
        private void StartService()
        {
            //Instantiate new ServiceHost
            host = new ServiceHost(this);
            //Open ServiceHost
            host.Open();
            //Create a ChannelFactory and load the configuration setting
            channelFactory = new ChannelFactory<IQuickReturnTraderChat>
                                             ("QuickTraderChatEndpoint");
            channel = channelFactory.CreateChannel();
            //Lets others know that someone new has joined
            channel.Say("Admin", "*** New User " + userID + " Joined ****" +
                                                        Environment.NewLine);
        }
        private void StopService()
        {
            if (host != null)
            {
                channel.Say("Admin", "*** User " + userID + " Leaving ****" +
                                                   Environment.NewLine);
                if (host.State != CommunicationState.Closed)
                {
                    channelFactory.Close();
                    host.Close();
                }
            }
        }

        public void Say(string user, string message)
        {
            richTextBoxScreen.Text += user + " says: " + message;
        }
        

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string temp = textBoxMessage.Text + Environment.NewLine;
            //Invoke the Service
            channel.Say(userID, temp);
            textBoxMessage.Clear();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
