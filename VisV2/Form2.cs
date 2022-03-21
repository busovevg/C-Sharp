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

namespace VisV2
{
    public partial class Form2 : Form
    {

        string data;
        int dataLenght;
        int dataint1;
        int dataint2;
        int dataint3;
        int dataint4;
        string dataText1;
        string dataText2;
        string dataText3;
        public Form2()
        {
            InitializeComponent();
                      

        }

       
        /*
        SimpleTcpServer server;
        public void Form2_Load(object sender, EventArgs e)
        {

            
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

        }

        public void Server_DataReceived(object sender, SimpleTCP.Message e)
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
                    DataReceivLenght.BackColor = Color.LightGreen;
                }
                else
                {
                    DataReceivLenght.BackColor = Color.LightPink;
                }


                if (dataLenght >= 3)
                {
                    dataint1_TB.Text = data.Substring(0, 3);
                    textBox1.Text = dataint1_TB.Text;
                    if (dataLenght >= 6)
                    {
                        dataint2_TB.Text = data.Substring(3, 3);
                        if (dataLenght >= 9)
                        {
                            dataint3_TB.Text = data.Substring(6, 3);
                            if (dataLenght >= 12)
                            {
                               dataint4_TB.Text = data.Substring(9, 3);
                                if (dataLenght >= 22)
                                {
                                    dataText1_TB.Text = data.Substring(12, 10);
                                    if (dataLenght >= 32)
                                    {
                                        dataText2_TB.Text = data.Substring(22, 10);
                                        if (dataLenght >= 42)
                                        {
                                            dataText3_TB.Text = data.Substring(32, 10);

                                        }
                                        else
                                        {
                                            dataText3_TB.Text = "";
                                        }
                                    }
                                    else
                                    {
                                       dataText2_TB.Text = "";
                                        dataText3_TB.Text = "";
                                    }
                                }
                                else
                                {
                                    dataText1_TB.Text = "";
                                    dataText2_TB.Text = "";
                                    dataText3_TB.Text = "";
                                }
                            }
                            else
                            {
                                dataint4_TB.Text = "";
                                dataText1_TB.Text = "";
                                dataText2_TB.Text = "";
                                dataText3_TB.Text = "";
                            }
                        }
                        else
                        {
                            dataint3_TB.Text = "";
                            dataint4_TB.Text = "";
                         dataText1_TB.Text = "";
                            dataText2_TB.Text = "";
                            dataText3_TB.Text = "";
                        }
                    }
                    else
                    {
                        dataint2_TB.Text = "";
                       dataint3_TB.Text = "";
                        dataint4_TB.Text = "";
                        dataText1_TB.Text = "";
                        dataText2_TB.Text = "";
                        dataText3_TB.Text = "";
                    }
                }
                else
                {
                    dataint1_TB.Text = "";
                    dataint2_TB.Text = "";
                   dataint3_TB.Text = "";
                    dataint4_TB.Text = "";
                    dataText1_TB.Text = "";
                   dataText2_TB.Text = "";
                    dataText3_TB.Text = "";
                }


                e.ReplyLine(string.Format("You said: {0}", e.MessageString));


            });


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
      
        */
    }
}
