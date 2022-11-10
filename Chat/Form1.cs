using SimpleTCP;
using System.Net;
using System.Text;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            btnStopServer.Enabled = false;
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message m)
        {
            txtMainServer.Invoke((MethodInvoker)delegate ()
            {
                txtMainServer.Text += m.MessageString.Substring(0, m.MessageString.Length - 1);
            });
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(txtHost.Text);
            server.Start(ip, Convert.ToInt32(txtPort.Text));
            if (server.IsStarted)
            {
                txtMainServer.Text += "\r\nServer start...";
                btnStartServer.Enabled = false;
                btnStopServer.Enabled = true;
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                btnStopServer.Enabled = false;
                btnStartServer.Enabled = true;
                txtMainServer.Text += "\r\nServer stoped";
            }
                
        }

        private void btnSendServer_Click(object sender, EventArgs e)
        {
            string message = "\r\nServer chat: " + txtMessageServer.Text;
            txtMessageServer.Clear();
            txtMainServer.Text += message;
            server.BroadcastLine(message);
        }
    }
}