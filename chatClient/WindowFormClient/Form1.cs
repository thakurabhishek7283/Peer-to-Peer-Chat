using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void connect_button_Click(object sender, EventArgs e)
        {
            String ip = this.ipList.SelectedItem.ToString();
            try
            {
                await ConnectToClient.connect(ip);
                this.connect_button.Text = "Connected";
                Chat();
            }
            catch (Exception ex)
            {
                string message = "failed to connect. try again";
                MessageBox.Show(message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Chat_Window.Items.Clear();
        }

        private void send_Click(object sender, EventArgs e)
        {
            String message = this.message_box.Text; 
            WriteToComplete(message);
        }

        private async void Fetch_server_Click(object sender, EventArgs e)
        {
            this.ipList.Items.Clear();
            String port = this.port_input.Text;
            
            List<String> iplist = await Controller.GetIPList(port);
            foreach (var ip in iplist)
            {
                this.ipList.Items.Add(ip.ToString());
            }
            if (this.port_input.Enabled == true)
            {
                Listen_Client(port);

            }
            //if (port.Length > 3 && port.Length < 6 && int.Parse(port) < 65000)
            {
                this.port_input.Enabled = false;
            }
        }

        public StreamReader reader;
        public StreamWriter writer;
        public Task Chat()
        {
            reader = new StreamReader(Controller.stream);
            writer = new StreamWriter(Controller.stream);
            this.Invoke((MethodInvoker)delegate
            {
                this.send.Enabled = true;
                this.connect_button.Text = "Connected";
            });
            return Task.Run(() =>
            {
                while (true)
                {
                    ReadToComplete();
                }
            });
        }
        public async Task ReadToComplete()
        {
            String message = reader.ReadLine();
            this.Invoke((MethodInvoker)delegate
            {
                this.Chat_Window.Items.Add(message);
                
            });
        }
        public async Task WriteToComplete(String message)
        {
            writer.WriteLine(message);
            writer.Flush();
            this.Invoke((MethodInvoker)delegate
            {
                this.Chat_Window.Items.Add(message);
            });
        }
        public Task Listen_Client(String port)
        {

            return Task.Run(() =>
            {
                TcpListener listener = new TcpListener(int.Parse(port));
                listener.Start();
                while (true)
                {
                    if (listener.Pending())
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        Controller.stream = client.GetStream();
                        string message = "new client connected";
                        MessageBox.Show(message);
                        Chat();
                    }
                    


                }
            });
                
           
            
        }

    }
}
