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
        int dataLenght;
        int dataint1;
        int dataint2;
        int dataint3;
        int dataint4;
        string dataText1;
        string dataText2;
        string dataText3;
        



        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
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
                ser_DataLogTB.Text += e.MessageString + "/>";
                data = e.MessageString;
                //textBox1.Text = data;
                
                dataLenght = e.MessageString.Length;
                DataReceivLenght.Text = dataLenght.ToString();


                if (dataLenght == 42)
                {
                    dataint1_TB.Text = data.Substring(0, 3);
                    dataint2_TB.Text = data.Substring(3, 3);
                    dataint3_TB.Text = data.Substring(6, 3);
                    dataint4_TB.Text = data.Substring(9, 3);
                    dataText1_TB.Text = data.Substring(12, 10);
                    dataText2_TB.Text = data.Substring(22, 10);
                    dataText3_TB.Text = data.Substring(32, 10);
                    textBox1.Text = dataint1_TB.Text;
                }

                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
               
                
            });

            
        }

        private void Main_Bt_Click(object sender, EventArgs e)
        {
            // if (index > 0)
            //   listPanel[--index].BringToFront();
            listPanel[0].BringToFront();
        }

        private void Settings_Bt_Click(object sender, EventArgs e)
        {
            // if (index < listPanel.Count - 1)
            //   listPanel[++index].BringToFront();
            listPanel[1].BringToFront();
        }

        private void Chart_Bt_Click_1(object sender, EventArgs e)
        {
            // if (index < listPanel.Count - 1)
            //   listPanel[++index].BringToFront();
            listPanel[2].BringToFront();
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


        

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
    class chartform : Form
    { 
        public chartform ()
        {
           
        }
    }
}