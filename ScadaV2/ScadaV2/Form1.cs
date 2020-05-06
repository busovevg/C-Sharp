using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace ScadaV2
{
    public partial class Form1 : Form
    {

        List<Panel> listPanel = new List<Panel>();
        int index;
        string data;

        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {

            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            ser_DataLogTB.Invoke((MethodInvoker)delegate ()
            {
                ser_DataLogTB.Text += e.MessageString;
                data = e.MessageString;
                textBox1.Text = data;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            });
        }

        private void Main_Bt_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void Settings_Bt_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        

        private void ser_StartBT_Click(object sender, EventArgs e)
        {
            ser_DataLogTB.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(ser_IPaddressTB.Text);
            server.Start(ip, Convert.ToInt32(ser_portTB.Text));
            ser_StartBT.Enabled = false;
        }

        private void ser_StopBT_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
            ser_StartBT.Enabled = true;
        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
            if (textBox1.TextLength > 0)
            {
                if (100 >= Convert.ToInt32(textBox1.Text))
                {
                    circularProgressBar1.Value = Convert.ToInt16(textBox1.Text);


                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}