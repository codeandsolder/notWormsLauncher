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
        private bool connected = false;
        const string hostPre = "ws://";

        public Form1() {
            InitializeComponent();
        }

        private void handleClosed() {
            connected = false;
            this.Invoke((MethodInvoker)delegate {
                this.serverLabel.Text = "Server state: disconnected";
                this.connectButton.Text = "Connect";
            });
        }

        private void handleConnected() {
            connected = true;
            sendAvailability();
            this.Invoke((MethodInvoker)delegate {
                this.serverLabel.Text = "Server state: connected";
                this.connectButton.Text = "Disconnect";
            });
        }
        private bool trySetName() {
            string name = nicknameBox.Text;
            if (name.Contains('/')) {
                MessageBox.Show("Invalid character in name: /");
                return false;
            }
            if (clientListbox.Items.Contains(name)) {
                MessageBox.Show("Name is in use!");
                return false;
            }
            if (!string.IsNullOrEmpty(name) && connected) {
                client.Send("n " + name);
                return true;
            }
            return false;
        }

        private void sendAvailability() {
            if (connected) {
                client.Send("a " + availableCheckbox.Checked);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
        }
        private void handleMessage(MessageEventArgs a) {
            Console.WriteLine(a.Data);
            string arguments = a.Data.Substring(2);
            switch (a.Data[0]) {
                case 't':
                    if(!trySetName())
                        this.Invoke((MethodInvoker)delegate {
                            this.nicknameBox.Text = arguments;
                        });
                    break;
                case 'l':
                    this.Invoke((MethodInvoker)delegate {
                        this.clientListbox.Items.Clear();
                    });
                    foreach (string player in arguments.Split('/')) {
                        if (player != nicknameBox.Text)
                            this.Invoke((MethodInvoker)delegate {
                                this.clientListbox.Items.Add(player);
                            });
                    }
                    break;
            }
        }
        private void connectButton_Click(object sender, EventArgs e){
            if (!connected) {
                string host = hostPre + addressBox.Text;
                client = new WebSocket(host);
                client.OnOpen += (ss, ee) => handleConnected();
                client.OnError += (ss, ee) => Console.WriteLine("Error: " + ee.Message);
                client.OnMessage += (ss, ee) => handleMessage(ee);
                client.OnClose += (ss, ee) => handleClosed();
                client.Connect();
            } else {
                client.Close();
            }
        }

        private void nicknameButton_Click(object sender, EventArgs e) {
            trySetName();
        }
        
        private void availableCheckbox_CheckedChanged(object sender, EventArgs e) {
            sendAvailability();
        }
    }
}
