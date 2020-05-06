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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {

            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            cl_DataLogTB.Invoke((MethodInvoker)delegate ()
            {
                cl_DataLogTB.Text += e.MessageString;

            });
        }


        private void cl_conectBT_Click_1(object sender, EventArgs e)
        {
            cl_DataLogTB.Text += "Connected...";
            cl_conectBT.Enabled = false;
            client.Connect(cl_IPaddressTB.Text, Convert.ToInt32(cl_portTB.Text));

            
        }


       


        private void cl_sendBT_Click_1(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(cl_DataTB.Text, TimeSpan.FromSeconds(1));
        }

       
    }
}
