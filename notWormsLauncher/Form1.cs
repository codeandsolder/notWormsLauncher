using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            client.Send("l True");
            sendAvailability();
            this.Invoke((MethodInvoker)delegate {
                this.serverLabel.Text = "Server state: connected";
                this.connectButton.Text = "Disconnect";
            });
        }
        private bool trySetName() {
            string name = nicknameBox.Text;
            if (name.Contains('/')) {
                MessageBox.Show("Invalid character in name: /", "Error!");
                return false;
            }
            if (clientListbox.Items.Contains(name)) {
                MessageBox.Show("Name is in use!", "Error!");
                return false;
            }
            if (!string.IsNullOrEmpty(name) && connected) {
                client.Send("s " + name);
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
        private void runGame(string args) {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python";
            start.Arguments = "game.py " + args;
            start.UseShellExecute = true;
            using (Process process = Process.Start(start)) {
            }
        }
        private void handleMessage(MessageEventArgs a) {
            Console.WriteLine(a.Data);
            string argument = a.Data.Substring(2);
            switch (a.Data[0]) {
                case 't':
                    if(!trySetName())
                        this.Invoke((MethodInvoker)delegate {
                            this.nicknameBox.Text = argument;
                        });
                    break;
                case 'l':
                    this.Invoke((MethodInvoker)delegate {
                        this.clientListbox.Items.Clear();
                    });
                    foreach (string player in argument.Split('/')) {
                        if (player != nicknameBox.Text && player != "")
                            this.Invoke((MethodInvoker)delegate {
                                this.clientListbox.Items.Add(player);
                            });
                    }
                    break;
                case 'c':
                    DialogResult accepted = MessageBox.Show("You have been challenged by: " + argument + "\nDo you accept?", "You have been challenged!", MessageBoxButtons.YesNo);
                    if (accepted == DialogResult.Yes) {
                        client.Send("y " + argument);
                        //starting game goes here
                    } else if (accepted == DialogResult.No) {
                        client.Send("n " + argument);
                    }
                    break;
                case 'n':
                    MessageBox.Show(argument + " has rejected your challenge :(", "Challenge rejected.");
                    break;
                case 'y':
                    runGame(client.Url.OriginalString + " " + nicknameBox.Text);
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

        private void challengeButton_Click(object sender, EventArgs e) {
            string target = clientListbox.GetItemText(clientListbox.SelectedItem);
            if (target != "")
                client.Send("c " + target);
        }

        private void debug_Click(object sender, EventArgs e) {
            runGame(client.Url.OriginalString + " " + nicknameBox.Text);
        }
    }
}
