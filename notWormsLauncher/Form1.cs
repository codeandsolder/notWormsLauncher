using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace notWormsLauncher
{
    public partial class Form1 : Form
    {

        private WebSocket client;
        const string hostPre = "ws://";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void connectButton_Click(object sender, EventArgs e){
            string host = hostPre + addressBox.Text;
            client = new WebSocket(host);
            client.OnOpen += (ss, ee) => listBox1.Items.Add(string.Format("Connected to {0} successfully ", host));
            client.OnError += (ss, ee) => listBox1.Items.Add("Error: " + ee.Message);
            client.OnMessage += (ss, ee) => MessageBox.Show("Echo: " + ee.Data);
            client.OnClose += (ss, ee) => listBox1.Items.Add(string.Format("Disconnected with {0}", host));
            client.Connect();
        }

        private void nicknameButton_Click(object sender, EventArgs e)
        {
            var content = nicknameBox.Text;
            if (!string.IsNullOrEmpty(content))
                client.Send(content);
        }
    }
}
