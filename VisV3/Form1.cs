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
using System.IO;
using System.Configuration;


namespace VisV3
{
    public partial class Form1 : Form
    {
        string data;
        int dataLenght;
        int[] PosAct = new int[60];
        int k;
        bool TimerOn = false;
        string text1 = "0118123123123123123123123123123";
        string text2 = "0218231231231231231231231231231";
        string text3 = "0318123123123123123123123123123";
        string text4 = "0418231231231231231231231231231";
        string text5 = "0518231231231231231231231231231";
        int iTb = 0;

        public Form1()
        {
            InitializeComponent();
            ser_IPaddressTB.Text = ConfigurationManager.AppSettings["IpAdress"];
            ser_portTB.Text = ConfigurationManager.AppSettings["Port"];
                            
        }
        SimpleTcpServer server;
        public void Form1_Load(object sender, EventArgs e)
        {
            Button[] btn = new Button[30];
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i] = new Button();
                btn[i].Location = new Point(40, 5 + i * 2);
                btn[i].Name = "" + (i + 1).ToString();
                btn[i].Size = new Size(35, 35);
                btn[i].TabIndex = i;
                btn[i].BringToFront();
                btn[i].Text = "" + (i + 1).ToString();
                this.Controls.Add(btn[i]);
                MoveCtrl.EnableMove(btn[i]);
                btn[i].Location = new Point(PosAct[i * 2], PosAct[i * 2 + 1]);
            }
            TextBox[] TbInd = new TextBox[30];
            for (int i = 0; i < TbInd.Length; i++)
            {
                TbInd[i] = new TextBox();

                if (i <= 14)
                {
                    TbInd[i].Location = new Point(431, 118 + i * 20);
                }
                else
                {
                    TbInd[i].Location = new Point(544, 118 + (i - 15) * 20);
                }
                TbInd[i].Name = "TbInd" + (i + 1).ToString();
                TbInd[i].Size = new Size(35, 35);
                TbInd[i].TabIndex = i;
                TbInd[i].BringToFront();


                panel2.Controls.Add(TbInd[i]);
               


            }
            pictureBox1.SendToBack();

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            ser_DataLogTB.Invoke((MethodInvoker)delegate ()
            {
              // ser_DataLogTB.Text += e.MessageString + "/>";
                data = e.MessageString;

                if (e.MessageString.Length > 34)
                {
                    dataLenght = 34;
                }
                else
                {
                    dataLenght = e.MessageString.Length;
                }
                ReceivData();

                //e.ReplyLine(string.Format("You said: {0}", e.MessageString));

            });
            IndStat();
            
        }

        private void ReceivData()
        {
            DataReceivLenght.Text = dataLenght.ToString();
            if (dataLenght >= 4)
            {
                if (dataLenght == Convert.ToInt32(data.Substring(2, 2)) + 11)
                {
                    DataReceivLenght.BackColor = Color.LightGreen;
                }
                else
                {
                    DataReceivLenght.BackColor = Color.LightPink;
                }
            }
            else
            {
                DataReceivLenght.BackColor = Color.LightPink;
            }


           for (int j = 0; j < dataLenght - 11; j++)
            {
               if (this.panel2.Controls["TbInd" + (j + 1).ToString()].Created == true)
                {
                    this.panel2.Controls["TbInd" + (j + 1).ToString()].Text = "";
                }
                this.panel2.Controls["TbInd" + (j + 1).ToString()].Text = data.Substring(j + 11, 1);
            }


            
            if (dataLenght >= 5)
            {
                iTb = dataLenght - 4;
                TB_Ntask.Text = data.Substring(0, 2);
                TB_ReqInd.Text = data.Substring(2, 2);
                TaskIndex.Value = Convert.ToInt32(TB_Ntask.Text);

                if (File.Exists(Convert.ToInt32(TB_Ntask.Text).ToString() + ".jpg"))
                {
                    pictureBox1.Image = Image.FromFile(Convert.ToInt32(TB_Ntask.Text).ToString() + ".jpg");
                    tb_QPS.Text = ConfigurationManager.AppSettings["Str" + (Convert.ToInt32(TB_Ntask.Text).ToString())];

                }
                else
                {
                    if (File.Exists("no.jpg"))
                    {
                        pictureBox1.Image = Image.FromFile("no.jpg");
                    }

                }


            }

            pb_CycleTime.Value = Convert.ToInt32(data.Substring(4, 2));
            tb_CycleTime.Text = data.Substring(4, 3)+" : "+data.Substring(7, 2);


            if (dataLenght - 4 > 30)
            {
                iTb = 30;
            }
            if (iTb > k)
            {
                k = iTb;
            }
            

           
        }
        private void IndStat()
        {
            for (int i = 0; i < dataLenght - 11; i++)
            {
               
                if (this.panel2.Controls["TbInd" + (i + 1).ToString()].Text == "1")
                {
                    this.Controls["" + (i + 1).ToString()].BackColor = Color.Yellow;
                }
                else if (this.panel2.Controls["TbInd" + (i + 1).ToString()].Text == "2")

                {
                    this.Controls["" + (i + 1).ToString()].BackColor = Color.LightGreen;
                }
                else if (this.panel2.Controls["TbInd" + (i + 1).ToString()].Text == "3")

                {
                    this.Controls["" + (i + 1).ToString()].BackColor = Color.Red;
                }
                else
                {
                    this.Controls["" + (i + 1).ToString()].BackColor = Color.Blue;
                }
                this.panel2.Controls["TbInd" + (i + 1).ToString()].Text = data.Substring(i + 11, 1);
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 29; i++)
            {
                PosAct[i * 2] = this.Controls["" + (i + 1).ToString()].Location.X;
                PosAct[i * 2 + 1] = this.Controls["" + (i + 1).ToString()].Location.Y;
            }
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["MeMPos" + TaskIndex.Value.ToString()].Value = string.Join(",", Array.ConvertAll(PosAct, x => x.ToString()));
            config.AppSettings.Settings["IpAdress"].Value = ser_IPaddressTB.Text;
            config.AppSettings.Settings["Port"].Value = ser_portTB.Text;
            config.AppSettings.Settings["Str" + TaskIndex.Value.ToString()].Value = tb_QPS.Text;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");

        }

        private void BtSetengs_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }

        }



        private void TaskIndex_ValueChanged(object sender, EventArgs e)
        {
            if (TaskIndex.Value < 10)
            {
                TB_Ntask.Text = "0" + TaskIndex.Value.ToString();
            }
            else
            {
                TB_Ntask.Text = TaskIndex.Value.ToString();
            }
            if (File.Exists(Convert.ToInt32(TB_Ntask.Text) + ".jpg"))
            {
                pictureBox1.Image = Image.FromFile(Convert.ToInt32(TB_Ntask.Text) + ".jpg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("no.jpg");
            }

            PosAct = ConfigurationManager.AppSettings["MeMPos" + TaskIndex.Value.ToString()].Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            for (int i = 0; i < 30; i++)
            {
                this.Controls["" + (i + 1).ToString()].Location = new Point(PosAct[i * 2], PosAct[i * 2 + 1]);
            }

            

            tb_QPS.Text = ConfigurationManager.AppSettings["Str" + (Convert.ToInt32(TB_Ntask.Text).ToString())];

            



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

        private void butDem_Click(object sender, EventArgs e)
        {
            if (TimerOn == true)
            {
                timer1.Stop();
                TimerOn = false;
            }
            else
            {
                textBox1.Text = text1;
                dataLenght = 24;
                data = text5;
                timer1.Start();
                TimerOn = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
             
            if (textBox1.Text == text1)
            {
                textBox1.Text = text2;
                data = text2;
            }
            else
            {
                if (textBox1.Text == text2)
                {
                    textBox1.Text = text3;
                    data = text3;
                }
                else
                {
                    if (textBox1.Text == text2)
                    {
                        textBox1.Text = text3;
                        data = text3;
                    }
                    else
                    {
                        if (textBox1.Text == text3)
                        {
                            textBox1.Text = text4;
                            data = text4;
                        }
                        else
                        {
                            if (textBox1.Text == text4)
                            {
                                textBox1.Text = text5;
                                data = text5;
                            }
                            else
                            {
                                if (textBox1.Text == text5)
                                {
                                    textBox1.Text = text1;
                                    data = text1;
                                }
                            }
                        }
                    }
                }
            }
            
            
           
            ReceivData();
            IndStat();
            
        }

        private void tb_QPS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
