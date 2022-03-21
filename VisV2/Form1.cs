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


namespace VisV2
{
    public partial class Form1 : Form
    {
       // Form2 form2 = new Form2();

        string data;
        int dataLenght;
        int dataint1;
        int dataint2;
        int dataint3;
        int dataint4;
        string dataText1;
        string dataText2;
        string dataText3;
        int[] nums = new int[40];
        string text = "011812312312312312312312";
        string text1 = "011823123123123123123123";
        bool TimerOn = false;

        public Form1()
        {
            
            InitializeComponent();
            MoveCtrl.EnableMove(Ind1);
            MoveCtrl.EnableMove(Ind2);
            MoveCtrl.EnableMove(Ind3);
            MoveCtrl.EnableMove(Ind4);
            MoveCtrl.EnableMove(Ind5);
            MoveCtrl.EnableMove(Ind6);
            MoveCtrl.EnableMove(Ind7);
            MoveCtrl.EnableMove(Ind8);
            MoveCtrl.EnableMove(Ind9);
            MoveCtrl.EnableMove(Ind10);
            MoveCtrl.EnableMove(Ind11);
            MoveCtrl.EnableMove(Ind12);
            MoveCtrl.EnableMove(Ind13);
            MoveCtrl.EnableMove(Ind14);
            MoveCtrl.EnableMove(Ind15);
            MoveCtrl.EnableMove(Ind16);
            MoveCtrl.EnableMove(Ind17);
            MoveCtrl.EnableMove(Ind18);
            MoveCtrl.EnableMove(Ind19);
            MoveCtrl.EnableMove(Ind20);

            


            if (Properties.Settings.Default.ActPosInd == null)
            { 
                Properties.Settings.Default.ActPosInd = new int[40];
           }

            if (Properties.Settings.Default.Mem1PosInd == null)
            {
                Properties.Settings.Default.Mem1PosInd = new int[40];
            }

            if (Properties.Settings.Default.Mem2PosInd == null)
            {
                Properties.Settings.Default.Mem2PosInd = new int[40];
            }

            if (Properties.Settings.Default.Mem3PosInd == null)
            {
                Properties.Settings.Default.Mem3PosInd = new int[40];
            }

            if (Properties.Settings.Default.Mem4PosInd == null)
            {
                Properties.Settings.Default.Mem4PosInd = new int[40];
            }

            if (Properties.Settings.Default.Mem5PosInd == null)
            {
                Properties.Settings.Default.Mem5PosInd = new int[40];
            }

            ser_IPaddressTB.Text = Properties.Settings.Default.IpAdres ;
            


        }
        SimpleTcpServer server;
        private void Form1_Load_1(object sender, EventArgs e)
        {

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

        }



        private void butSave_Click(object sender, EventArgs e)
        {
            if (TB_Ntask.Text == "01")
            {
                Properties.Settings.Default.Mem1PosInd[0] = Ind1.Location.X;
                Properties.Settings.Default.Mem1PosInd[1] = Ind1.Location.Y;
                Properties.Settings.Default.Mem1PosInd[2] = Ind2.Location.X;
                Properties.Settings.Default.Mem1PosInd[3] = Ind2.Location.Y;
                Properties.Settings.Default.Mem1PosInd[4] = Ind3.Location.X;
                Properties.Settings.Default.Mem1PosInd[5] = Ind3.Location.Y;
                Properties.Settings.Default.Mem1PosInd[6] = Ind4.Location.X;
                Properties.Settings.Default.Mem1PosInd[7] = Ind4.Location.Y;
                Properties.Settings.Default.Mem1PosInd[8] = Ind5.Location.X;
                Properties.Settings.Default.Mem1PosInd[9] = Ind5.Location.Y;
                Properties.Settings.Default.Mem1PosInd[10] = Ind6.Location.X;
                Properties.Settings.Default.Mem1PosInd[11] = Ind6.Location.Y;
                Properties.Settings.Default.Mem1PosInd[12] = Ind7.Location.X;
                Properties.Settings.Default.Mem1PosInd[13] = Ind7.Location.Y;
                Properties.Settings.Default.Mem1PosInd[14] = Ind8.Location.X;
                Properties.Settings.Default.Mem1PosInd[15] = Ind8.Location.Y;
                Properties.Settings.Default.Mem1PosInd[16] = Ind9.Location.X;
                Properties.Settings.Default.Mem1PosInd[17] = Ind9.Location.Y;
                Properties.Settings.Default.Mem1PosInd[18] = Ind10.Location.X;
                Properties.Settings.Default.Mem1PosInd[19] = Ind10.Location.Y;
                Properties.Settings.Default.Mem1PosInd[20] = Ind11.Location.X;
                Properties.Settings.Default.Mem1PosInd[21] = Ind11.Location.Y;
                Properties.Settings.Default.Mem1PosInd[22] = Ind12.Location.X;
                Properties.Settings.Default.Mem1PosInd[23] = Ind12.Location.Y;
                Properties.Settings.Default.Mem1PosInd[24] = Ind13.Location.X;
                Properties.Settings.Default.Mem1PosInd[25] = Ind13.Location.Y;
                Properties.Settings.Default.Mem1PosInd[26] = Ind14.Location.X;
                Properties.Settings.Default.Mem1PosInd[27] = Ind14.Location.Y;
                Properties.Settings.Default.Mem1PosInd[28] = Ind15.Location.X;
                Properties.Settings.Default.Mem1PosInd[29] = Ind15.Location.Y;
                Properties.Settings.Default.Mem1PosInd[30] = Ind16.Location.X;
                Properties.Settings.Default.Mem1PosInd[31] = Ind16.Location.Y;
                Properties.Settings.Default.Mem1PosInd[32] = Ind17.Location.X;
                Properties.Settings.Default.Mem1PosInd[33] = Ind17.Location.Y;
                Properties.Settings.Default.Mem1PosInd[34] = Ind18.Location.X;
                Properties.Settings.Default.Mem1PosInd[35] = Ind18.Location.Y;
                Properties.Settings.Default.Mem1PosInd[36] = Ind19.Location.X;
                Properties.Settings.Default.Mem1PosInd[37] = Ind19.Location.Y;
                Properties.Settings.Default.Mem1PosInd[38] = Ind20.Location.X;
                Properties.Settings.Default.Mem1PosInd[39] = Ind20.Location.Y;
               
            }

            if (TB_Ntask.Text == "02")
            {
                Properties.Settings.Default.Mem2PosInd[0] = Ind1.Location.X;
                Properties.Settings.Default.Mem2PosInd[1] = Ind1.Location.Y;
                Properties.Settings.Default.Mem2PosInd[2] = Ind2.Location.X;
                Properties.Settings.Default.Mem2PosInd[3] = Ind2.Location.Y;
                Properties.Settings.Default.Mem2PosInd[4] = Ind3.Location.X;
                Properties.Settings.Default.Mem2PosInd[5] = Ind3.Location.Y;
                Properties.Settings.Default.Mem2PosInd[6] = Ind4.Location.X;
                Properties.Settings.Default.Mem2PosInd[7] = Ind4.Location.Y;
                Properties.Settings.Default.Mem2PosInd[8] = Ind5.Location.X;
                Properties.Settings.Default.Mem2PosInd[9] = Ind5.Location.Y;
                Properties.Settings.Default.Mem2PosInd[10] = Ind6.Location.X;
                Properties.Settings.Default.Mem2PosInd[11] = Ind6.Location.Y;
                Properties.Settings.Default.Mem2PosInd[12] = Ind7.Location.X;
                Properties.Settings.Default.Mem2PosInd[13] = Ind7.Location.Y;
                Properties.Settings.Default.Mem2PosInd[14] = Ind8.Location.X;
                Properties.Settings.Default.Mem2PosInd[15] = Ind8.Location.Y;
                Properties.Settings.Default.Mem2PosInd[16] = Ind9.Location.X;
                Properties.Settings.Default.Mem2PosInd[17] = Ind9.Location.Y;
                Properties.Settings.Default.Mem2PosInd[18] = Ind10.Location.X;
                Properties.Settings.Default.Mem2PosInd[19] = Ind10.Location.Y;
                Properties.Settings.Default.Mem2PosInd[20] = Ind11.Location.X;
                Properties.Settings.Default.Mem2PosInd[21] = Ind11.Location.Y;
                Properties.Settings.Default.Mem2PosInd[22] = Ind12.Location.X;
                Properties.Settings.Default.Mem2PosInd[23] = Ind12.Location.Y;
                Properties.Settings.Default.Mem2PosInd[24] = Ind13.Location.X;
                Properties.Settings.Default.Mem2PosInd[25] = Ind13.Location.Y;
                Properties.Settings.Default.Mem2PosInd[26] = Ind14.Location.X;
                Properties.Settings.Default.Mem2PosInd[27] = Ind14.Location.Y;
                Properties.Settings.Default.Mem2PosInd[28] = Ind15.Location.X;
                Properties.Settings.Default.Mem2PosInd[29] = Ind15.Location.Y;
                Properties.Settings.Default.Mem2PosInd[30] = Ind16.Location.X;
                Properties.Settings.Default.Mem2PosInd[31] = Ind16.Location.Y;
                Properties.Settings.Default.Mem2PosInd[32] = Ind17.Location.X;
                Properties.Settings.Default.Mem2PosInd[33] = Ind17.Location.Y;
                Properties.Settings.Default.Mem2PosInd[34] = Ind18.Location.X;
                Properties.Settings.Default.Mem2PosInd[35] = Ind18.Location.Y;
                Properties.Settings.Default.Mem2PosInd[36] = Ind19.Location.X;
                Properties.Settings.Default.Mem2PosInd[37] = Ind19.Location.Y;
                Properties.Settings.Default.Mem2PosInd[38] = Ind20.Location.X;
                Properties.Settings.Default.Mem2PosInd[39] = Ind20.Location.Y;

            }

            if (TB_Ntask.Text == "03")
            {
                Properties.Settings.Default.Mem3PosInd[0] = Ind1.Location.X;
                Properties.Settings.Default.Mem3PosInd[1] = Ind1.Location.Y;
                Properties.Settings.Default.Mem3PosInd[2] = Ind2.Location.X;
                Properties.Settings.Default.Mem3PosInd[3] = Ind2.Location.Y;
                Properties.Settings.Default.Mem3PosInd[4] = Ind3.Location.X;
                Properties.Settings.Default.Mem3PosInd[5] = Ind3.Location.Y;
                Properties.Settings.Default.Mem3PosInd[6] = Ind4.Location.X;
                Properties.Settings.Default.Mem3PosInd[7] = Ind4.Location.Y;
                Properties.Settings.Default.Mem3PosInd[8] = Ind5.Location.X;
                Properties.Settings.Default.Mem3PosInd[9] = Ind5.Location.Y;
                Properties.Settings.Default.Mem3PosInd[10] = Ind6.Location.X;
                Properties.Settings.Default.Mem3PosInd[11] = Ind6.Location.Y;
                Properties.Settings.Default.Mem3PosInd[12] = Ind7.Location.X;
                Properties.Settings.Default.Mem3PosInd[13] = Ind7.Location.Y;
                Properties.Settings.Default.Mem3PosInd[14] = Ind8.Location.X;
                Properties.Settings.Default.Mem3PosInd[15] = Ind8.Location.Y;
                Properties.Settings.Default.Mem3PosInd[16] = Ind9.Location.X;
                Properties.Settings.Default.Mem3PosInd[17] = Ind9.Location.Y;
                Properties.Settings.Default.Mem3PosInd[18] = Ind10.Location.X;
                Properties.Settings.Default.Mem3PosInd[19] = Ind10.Location.Y;
                Properties.Settings.Default.Mem3PosInd[20] = Ind11.Location.X;
                Properties.Settings.Default.Mem3PosInd[21] = Ind11.Location.Y;
                Properties.Settings.Default.Mem3PosInd[22] = Ind12.Location.X;
                Properties.Settings.Default.Mem3PosInd[23] = Ind12.Location.Y;
                Properties.Settings.Default.Mem3PosInd[24] = Ind13.Location.X;
                Properties.Settings.Default.Mem3PosInd[25] = Ind13.Location.Y;
                Properties.Settings.Default.Mem3PosInd[26] = Ind14.Location.X;
                Properties.Settings.Default.Mem3PosInd[27] = Ind14.Location.Y;
                Properties.Settings.Default.Mem3PosInd[28] = Ind15.Location.X;
                Properties.Settings.Default.Mem3PosInd[29] = Ind15.Location.Y;
                Properties.Settings.Default.Mem3PosInd[30] = Ind16.Location.X;
                Properties.Settings.Default.Mem3PosInd[31] = Ind16.Location.Y;
                Properties.Settings.Default.Mem3PosInd[32] = Ind17.Location.X;
                Properties.Settings.Default.Mem3PosInd[33] = Ind17.Location.Y;
                Properties.Settings.Default.Mem3PosInd[34] = Ind18.Location.X;
                Properties.Settings.Default.Mem3PosInd[35] = Ind18.Location.Y;
                Properties.Settings.Default.Mem3PosInd[36] = Ind19.Location.X;
                Properties.Settings.Default.Mem3PosInd[37] = Ind19.Location.Y;
                Properties.Settings.Default.Mem3PosInd[38] = Ind20.Location.X;
                Properties.Settings.Default.Mem3PosInd[39] = Ind20.Location.Y;

            }

            if (TB_Ntask.Text == "04")
            {
                Properties.Settings.Default.Mem4PosInd[0] = Ind1.Location.X;
                Properties.Settings.Default.Mem4PosInd[1] = Ind1.Location.Y;
                Properties.Settings.Default.Mem4PosInd[2] = Ind2.Location.X;
                Properties.Settings.Default.Mem4PosInd[3] = Ind2.Location.Y;
                Properties.Settings.Default.Mem4PosInd[4] = Ind3.Location.X;
                Properties.Settings.Default.Mem4PosInd[5] = Ind3.Location.Y;
                Properties.Settings.Default.Mem4PosInd[6] = Ind4.Location.X;
                Properties.Settings.Default.Mem4PosInd[7] = Ind4.Location.Y;
                Properties.Settings.Default.Mem4PosInd[8] = Ind5.Location.X;
                Properties.Settings.Default.Mem4PosInd[9] = Ind5.Location.Y;
                Properties.Settings.Default.Mem4PosInd[10] = Ind6.Location.X;
                Properties.Settings.Default.Mem4PosInd[11] = Ind6.Location.Y;
                Properties.Settings.Default.Mem4PosInd[12] = Ind7.Location.X;
                Properties.Settings.Default.Mem4PosInd[13] = Ind7.Location.Y;
                Properties.Settings.Default.Mem4PosInd[14] = Ind8.Location.X;
                Properties.Settings.Default.Mem4PosInd[15] = Ind8.Location.Y;
                Properties.Settings.Default.Mem4PosInd[16] = Ind9.Location.X;
                Properties.Settings.Default.Mem4PosInd[17] = Ind9.Location.Y;
                Properties.Settings.Default.Mem4PosInd[18] = Ind10.Location.X;
                Properties.Settings.Default.Mem4PosInd[19] = Ind10.Location.Y;
                Properties.Settings.Default.Mem4PosInd[20] = Ind11.Location.X;
                Properties.Settings.Default.Mem4PosInd[21] = Ind11.Location.Y;
                Properties.Settings.Default.Mem4PosInd[22] = Ind12.Location.X;
                Properties.Settings.Default.Mem4PosInd[23] = Ind12.Location.Y;
                Properties.Settings.Default.Mem4PosInd[24] = Ind13.Location.X;
                Properties.Settings.Default.Mem4PosInd[25] = Ind13.Location.Y;
                Properties.Settings.Default.Mem4PosInd[26] = Ind14.Location.X;
                Properties.Settings.Default.Mem4PosInd[27] = Ind14.Location.Y;
                Properties.Settings.Default.Mem4PosInd[28] = Ind15.Location.X;
                Properties.Settings.Default.Mem4PosInd[29] = Ind15.Location.Y;
                Properties.Settings.Default.Mem4PosInd[30] = Ind16.Location.X;
                Properties.Settings.Default.Mem4PosInd[31] = Ind16.Location.Y;
                Properties.Settings.Default.Mem4PosInd[32] = Ind17.Location.X;
                Properties.Settings.Default.Mem4PosInd[33] = Ind17.Location.Y;
                Properties.Settings.Default.Mem4PosInd[34] = Ind18.Location.X;
                Properties.Settings.Default.Mem4PosInd[35] = Ind18.Location.Y;
                Properties.Settings.Default.Mem4PosInd[36] = Ind19.Location.X;
                Properties.Settings.Default.Mem4PosInd[37] = Ind19.Location.Y;
                Properties.Settings.Default.Mem4PosInd[38] = Ind20.Location.X;
                Properties.Settings.Default.Mem4PosInd[39] = Ind20.Location.Y;

            }

            if (TB_Ntask.Text == "05")
            {
                Properties.Settings.Default.Mem5PosInd[0] = Ind1.Location.X;
                Properties.Settings.Default.Mem5PosInd[1] = Ind1.Location.Y;
                Properties.Settings.Default.Mem5PosInd[2] = Ind2.Location.X;
                Properties.Settings.Default.Mem5PosInd[3] = Ind2.Location.Y;
                Properties.Settings.Default.Mem5PosInd[4] = Ind3.Location.X;
                Properties.Settings.Default.Mem5PosInd[5] = Ind3.Location.Y;
                Properties.Settings.Default.Mem5PosInd[6] = Ind4.Location.X;
                Properties.Settings.Default.Mem5PosInd[7] = Ind4.Location.Y;
                Properties.Settings.Default.Mem5PosInd[8] = Ind5.Location.X;
                Properties.Settings.Default.Mem5PosInd[9] = Ind5.Location.Y;
                Properties.Settings.Default.Mem5PosInd[10] = Ind6.Location.X;
                Properties.Settings.Default.Mem5PosInd[11] = Ind6.Location.Y;
                Properties.Settings.Default.Mem5PosInd[12] = Ind7.Location.X;
                Properties.Settings.Default.Mem5PosInd[13] = Ind7.Location.Y;
                Properties.Settings.Default.Mem5PosInd[14] = Ind8.Location.X;
                Properties.Settings.Default.Mem5PosInd[15] = Ind8.Location.Y;
                Properties.Settings.Default.Mem5PosInd[16] = Ind9.Location.X;
                Properties.Settings.Default.Mem5PosInd[17] = Ind9.Location.Y;
                Properties.Settings.Default.Mem5PosInd[18] = Ind10.Location.X;
                Properties.Settings.Default.Mem5PosInd[19] = Ind10.Location.Y;
                Properties.Settings.Default.Mem5PosInd[20] = Ind11.Location.X;
                Properties.Settings.Default.Mem5PosInd[21] = Ind11.Location.Y;
                Properties.Settings.Default.Mem5PosInd[22] = Ind12.Location.X;
                Properties.Settings.Default.Mem5PosInd[23] = Ind12.Location.Y;
                Properties.Settings.Default.Mem5PosInd[24] = Ind13.Location.X;
                Properties.Settings.Default.Mem5PosInd[25] = Ind13.Location.Y;
                Properties.Settings.Default.Mem5PosInd[26] = Ind14.Location.X;
                Properties.Settings.Default.Mem5PosInd[27] = Ind14.Location.Y;
                Properties.Settings.Default.Mem5PosInd[28] = Ind15.Location.X;
                Properties.Settings.Default.Mem5PosInd[29] = Ind15.Location.Y;
                Properties.Settings.Default.Mem5PosInd[30] = Ind16.Location.X;
                Properties.Settings.Default.Mem5PosInd[31] = Ind16.Location.Y;
                Properties.Settings.Default.Mem5PosInd[32] = Ind17.Location.X;
                Properties.Settings.Default.Mem5PosInd[33] = Ind17.Location.Y;
                Properties.Settings.Default.Mem5PosInd[34] = Ind18.Location.X;
                Properties.Settings.Default.Mem5PosInd[35] = Ind18.Location.Y;
                Properties.Settings.Default.Mem5PosInd[36] = Ind19.Location.X;
                Properties.Settings.Default.Mem5PosInd[37] = Ind19.Location.Y;
                Properties.Settings.Default.Mem5PosInd[38] = Ind20.Location.X;
                Properties.Settings.Default.Mem5PosInd[39] = Ind20.Location.Y;

            }

            Properties.Settings.Default.IpAdres = ser_IPaddressTB.Text;
            Properties.Settings.Default.Save();

        }

        private void BtSetengs_Click_1(object sender, EventArgs e)
        {
            //form2.ser_IPaddressTB.Text = Properties.Settings.Default.IpAdres;
            //form2.ShowDialog();


            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }

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
                if (dataLenght >=4 )
                {
                    if (dataLenght == Convert.ToInt32(data.Substring(2, 2)) + 4)
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

                if (dataLenght >= 5)
                {
                    TB_Ntask.Text = data.Substring(0, 2);
                    TB_ReqInd.Text = data.Substring(2, 2);
                    TB_Ind1.Text = data.Substring(4, 1);
                    if (dataLenght >= 6)
                    {
                        TB_Ind2.Text = data.Substring(5, 1);
                        if (dataLenght >= 7)
                        {
                            TB_Ind3.Text = data.Substring(6, 1);
                            if (dataLenght >= 8)
                            {
                                TB_Ind4.Text = data.Substring(7, 1);
                                if (dataLenght >= 9)
                                {
                                    TB_Ind5.Text = data.Substring(8, 1);
                                    if (dataLenght >= 10)
                                    {
                                        TB_Ind6.Text = data.Substring(9, 1);
                                        if (dataLenght >= 11)
                                        {
                                            TB_Ind7.Text = data.Substring(10, 1);
                                            if (dataLenght >= 12)
                                            {
                                                TB_Ind8.Text = data.Substring(11, 1);
                                                if (dataLenght >= 13)
                                                {
                                                    TB_Ind9.Text = data.Substring(12, 1);
                                                    if (dataLenght >= 14)
                                                    {
                                                        TB_Ind10.Text = data.Substring(13, 1);
                                                        if (dataLenght >= 15)
                                                        {
                                                            TB_Ind11.Text = data.Substring(14, 1);
                                                            if (dataLenght >= 16)
                                                            {
                                                                TB_Ind12.Text = data.Substring(15, 1);
                                                                if (dataLenght >= 17)
                                                                {
                                                                    TB_Ind13.Text = data.Substring(16, 1);
                                                                    if (dataLenght >= 18)
                                                                    {
                                                                        TB_Ind14.Text = data.Substring(17, 1);
                                                                        if (dataLenght >= 19)
                                                                        {
                                                                            TB_Ind15.Text = data.Substring(18, 1);
                                                                            if (dataLenght >= 20)
                                                                            {
                                                                                TB_Ind16.Text = data.Substring(19, 1);
                                                                                if (dataLenght >= 21)
                                                                                {
                                                                                    TB_Ind17.Text = data.Substring(20, 1);
                                                                                    if (dataLenght >= 22)
                                                                                    {
                                                                                        TB_Ind18.Text = data.Substring(21, 1);
                                                                                        if (dataLenght >= 23)
                                                                                        {
                                                                                            TB_Ind19.Text = data.Substring(22, 1);
                                                                                            if (dataLenght >= 24)
                                                                                            {
                                                                                                TB_Ind20.Text = data.Substring(23, 1);

                                                                                            }

                                                                                            else
                                                                                            {
                                                                                                TB_Ind20.Text = "";
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            TB_Ind19.Text = "";
                                                                                            TB_Ind20.Text = "";
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        TB_Ind18.Text = "";
                                                                                        TB_Ind19.Text = "";
                                                                                        TB_Ind20.Text = "";
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    TB_Ind17.Text = "";
                                                                                    TB_Ind18.Text = "";
                                                                                    TB_Ind19.Text = "";
                                                                                    TB_Ind20.Text = "";
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                TB_Ind16.Text = "";
                                                                                TB_Ind17.Text = "";
                                                                                TB_Ind18.Text = "";
                                                                                TB_Ind19.Text = "";
                                                                                TB_Ind20.Text = "";
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            TB_Ind15.Text = "";
                                                                            TB_Ind16.Text = "";
                                                                            TB_Ind17.Text = "";
                                                                            TB_Ind18.Text = "";
                                                                            TB_Ind19.Text = "";
                                                                            TB_Ind20.Text = "";
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        TB_Ind14.Text = "";
                                                                        TB_Ind15.Text = "";
                                                                        TB_Ind16.Text = "";
                                                                        TB_Ind17.Text = "";
                                                                        TB_Ind18.Text = "";
                                                                        TB_Ind19.Text = "";
                                                                        TB_Ind20.Text = "";
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    TB_Ind13.Text = "";
                                                                    TB_Ind14.Text = "";
                                                                    TB_Ind15.Text = "";
                                                                    TB_Ind16.Text = "";
                                                                    TB_Ind17.Text = "";
                                                                    TB_Ind18.Text = "";
                                                                    TB_Ind19.Text = "";
                                                                    TB_Ind20.Text = "";
                                                                }
                                                            }
                                                            else
                                                            {

                                                                TB_Ind12.Text = "";
                                                                TB_Ind13.Text = "";
                                                                TB_Ind15.Text = "";
                                                                TB_Ind16.Text = "";
                                                                TB_Ind17.Text = "";
                                                                TB_Ind18.Text = "";
                                                                TB_Ind19.Text = "";
                                                                TB_Ind20.Text = "";
                                                            }
                                                        }
                                                        else
                                                        {
                                                            TB_Ind11.Text = "";
                                                            TB_Ind12.Text = "";
                                                            TB_Ind13.Text = "";
                                                            TB_Ind14.Text = "";
                                                            TB_Ind15.Text = "";
                                                            TB_Ind16.Text = "";
                                                            TB_Ind17.Text = "";
                                                            TB_Ind18.Text = "";
                                                            TB_Ind19.Text = "";
                                                            TB_Ind20.Text = "";
                                                        }
                                                    }
                                                  
                                                    else
                                                  {
                                                TB_Ind10.Text = "";
                                                TB_Ind11.Text = "";
                                                TB_Ind12.Text = "";
                                                TB_Ind13.Text = "";
                                                TB_Ind14.Text = "";
                                                TB_Ind15.Text = "";
                                                TB_Ind16.Text = "";
                                                TB_Ind17.Text = "";
                                                TB_Ind18.Text = "";
                                                TB_Ind19.Text = "";
                                                TB_Ind20.Text = "";
                                            }
                                        }
                                        else
                                        {
                                            TB_Ind9.Text = "";
                                            TB_Ind10.Text = "";
                                            TB_Ind11.Text = "";
                                            TB_Ind12.Text = "";
                                            TB_Ind13.Text = "";
                                            TB_Ind14.Text = "";
                                            TB_Ind15.Text = "";
                                            TB_Ind16.Text = "";
                                            TB_Ind17.Text = "";
                                            TB_Ind18.Text = "";
                                            TB_Ind19.Text = "";
                                            TB_Ind20.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        TB_Ind8.Text = "";
                                        TB_Ind9.Text = "";
                                        TB_Ind10.Text = "";
                                        TB_Ind11.Text = "";
                                        TB_Ind12.Text = "";
                                        TB_Ind13.Text = "";
                                        TB_Ind14.Text = "";
                                        TB_Ind15.Text = "";
                                        TB_Ind16.Text = "";
                                        TB_Ind17.Text = "";
                                        TB_Ind18.Text = "";
                                        TB_Ind19.Text = "";
                                        TB_Ind20.Text = "";
                                    }
                                }
                                else
                                {
                                    TB_Ind7.Text = "";
                                    TB_Ind8.Text = "";
                                    TB_Ind9.Text = "";
                                    TB_Ind10.Text = "";
                                    TB_Ind11.Text = "";
                                    TB_Ind12.Text = "";
                                    TB_Ind13.Text = "";
                                    TB_Ind14.Text = "";
                                    TB_Ind15.Text = "";
                                    TB_Ind16.Text = "";
                                    TB_Ind17.Text = "";
                                    TB_Ind18.Text = "";
                                    TB_Ind19.Text = "";
                                    TB_Ind20.Text = "";
                                }
                            }
                            else
                            {
                                TB_Ind6.Text = "";
                                TB_Ind7.Text = "";
                                TB_Ind8.Text = "";
                                TB_Ind9.Text = "";
                                TB_Ind10.Text = "";
                                TB_Ind11.Text = "";
                                TB_Ind12.Text = "";
                                TB_Ind13.Text = "";
                                TB_Ind14.Text = "";
                                TB_Ind15.Text = "";
                                TB_Ind16.Text = "";
                                TB_Ind17.Text = "";
                                TB_Ind18.Text = "";
                                TB_Ind19.Text = "";
                                TB_Ind20.Text = "";
                            }
                        }
                        else
                        {
                            TB_Ind5.Text = "";
                            TB_Ind6.Text = "";
                            TB_Ind7.Text = "";
                            TB_Ind8.Text = "";
                            TB_Ind9.Text = "";
                            TB_Ind10.Text = "";
                            TB_Ind11.Text = "";
                            TB_Ind12.Text = "";
                            TB_Ind13.Text = "";
                            TB_Ind14.Text = "";
                            TB_Ind15.Text = "";
                            TB_Ind16.Text = "";
                            TB_Ind17.Text = "";
                            TB_Ind18.Text = "";
                            TB_Ind19.Text = "";
                            TB_Ind20.Text = "";
                        }
                    }
                    else
                    {
                        TB_Ind4.Text = "";
                        TB_Ind5.Text = "";
                        TB_Ind6.Text = "";
                        TB_Ind7.Text = "";
                        TB_Ind8.Text = "";
                        TB_Ind9.Text = "";
                        TB_Ind10.Text = "";
                        TB_Ind11.Text = "";
                        TB_Ind12.Text = "";
                        TB_Ind13.Text = "";
                        TB_Ind14.Text = "";
                        TB_Ind15.Text = "";
                        TB_Ind16.Text = "";
                        TB_Ind17.Text = "";
                        TB_Ind18.Text = "";
                        TB_Ind19.Text = "";
                        TB_Ind20.Text = "";
                    }
                }
                else
                {
                    TB_Ind3.Text = "";
                    TB_Ind4.Text = "";
                    TB_Ind5.Text = "";
                    TB_Ind6.Text = "";
                    TB_Ind7.Text = "";
                    TB_Ind8.Text = "";
                    TB_Ind9.Text = "";
                    TB_Ind10.Text = "";
                    TB_Ind11.Text = "";
                    TB_Ind12.Text = "";
                    TB_Ind13.Text = "";
                    TB_Ind14.Text = "";
                    TB_Ind15.Text = "";
                    TB_Ind16.Text = "";
                    TB_Ind17.Text = "";
                    TB_Ind18.Text = "";
                    TB_Ind19.Text = "";
                    TB_Ind20.Text = "";
                }
            }
             else
            {
                TB_Ind2.Text = "";
                TB_Ind3.Text = "";
                TB_Ind4.Text = "";
                TB_Ind5.Text = "";
                TB_Ind6.Text = "";
                TB_Ind7.Text = "";
                TB_Ind8.Text = "";
                TB_Ind9.Text = "";
                TB_Ind10.Text = "";
                TB_Ind11.Text = "";
                TB_Ind12.Text = "";
                TB_Ind13.Text = "";
                TB_Ind14.Text = "";
                TB_Ind15.Text = "";
                TB_Ind16.Text = "";
                TB_Ind17.Text = "";
                TB_Ind18.Text = "";
                TB_Ind19.Text = "";
                TB_Ind20.Text = "";
            }
        }
                else
                {
                    TB_Ntask.Text = "";
                    TB_Ind1.Text = "";
                    TB_Ind2.Text = "";
                    TB_Ind3.Text = "";
                    TB_Ind4.Text = "";
                    TB_Ind5.Text = "";
                    TB_Ind6.Text = "";
                    TB_Ind7.Text = "";
                    TB_Ind8.Text = "";
                    TB_Ind9.Text = "";
                    TB_Ind10.Text = "";
                    TB_Ind11.Text = "";
                    TB_Ind12.Text = "";
                    TB_Ind13.Text = "";
                    TB_Ind14.Text = "";
                    TB_Ind15.Text = "";
                    TB_Ind16.Text = "";
                    TB_Ind17.Text = "";
                    TB_Ind18.Text = "";
                    TB_Ind19.Text = "";
                    TB_Ind20.Text = "";
                }

                if (Convert.ToInt32(TB_ReqInd.Text) >= 1)
                {
                    Ind1.Visible = true;
                    Ind2.Visible = false;
                    Ind3.Visible = false;
                    Ind4.Visible = false;
                    Ind5.Visible = false;
                    Ind6.Visible = false;
                    Ind7.Visible = false;
                    Ind8.Visible = false;
                    Ind9.Visible = false;
                    Ind10.Visible = false;
                    Ind11.Visible = false;
                    Ind12.Visible = false;
                    Ind13.Visible = false;
                    Ind14.Visible = false;
                    Ind15.Visible = false;
                    Ind16.Visible = false;
                    Ind17.Visible = false;
                    Ind18.Visible = false;
                    Ind19.Visible = false;
                    Ind20.Visible = false;

                    if (Convert.ToInt32(TB_ReqInd.Text) >= 2)
                    {
                        Ind2.Visible = true;
                        if (Convert.ToInt32(TB_ReqInd.Text) >= 3)
                        {
                            Ind3.Visible = true;
                            if (Convert.ToInt32(TB_ReqInd.Text) >= 4)
                            {
                                Ind4.Visible = true;
                                if (Convert.ToInt32(TB_ReqInd.Text) >= 5)
                                {
                                    Ind5.Visible = true;
                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 6)
                                    {
                                        Ind6.Visible = true;
                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 7)
                                        {
                                            Ind7.Visible = true;
                                            if (Convert.ToInt32(TB_ReqInd.Text) >= 8)
                                            {
                                                Ind8.Visible = true;
                                                if (Convert.ToInt32(TB_ReqInd.Text) >= 9)
                                                {
                                                    Ind9.Visible = true;
                                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 10)
                                                    {
                                                        Ind10.Visible = true;
                                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 11)
                                                        {
                                                            Ind11.Visible = true;
                                                            if (Convert.ToInt32(TB_ReqInd.Text) >= 12)
                                                            {
                                                                Ind12.Visible = true;
                                                                if (Convert.ToInt32(TB_ReqInd.Text) >= 13)
                                                                {
                                                                    Ind13.Visible = true;
                                                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 14)
                                                                    {
                                                                        Ind14.Visible = true;
                                                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 15)
                                                                        {
                                                                            Ind15.Visible = true;
                                                                            if (Convert.ToInt32(TB_ReqInd.Text) >= 16)
                                                                            {
                                                                                Ind16.Visible = true;
                                                                                if (Convert.ToInt32(TB_ReqInd.Text) >= 17)
                                                                                {
                                                                                    Ind17.Visible = true;
                                                                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 18)
                                                                                    {
                                                                                        Ind18.Visible = true;
                                                                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 19)
                                                                                        {
                                                                                            Ind19.Visible = true;
                                                                                            if (Convert.ToInt32(TB_ReqInd.Text) >= 20)
                                                                                            {
                                                                                                Ind20.Visible = true;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                e.ReplyLine(string.Format("You said: {0}", e.MessageString));


            });

            

            if (Convert.ToInt32(TB_Ntask.Text) == 1)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem1PosInd;

            }
            if (Convert.ToInt32(TB_Ntask.Text) == 2)
            {
                pictureBox1.Image = Image.FromFile("2.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem2PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 3)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem3PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 4)
            {
                pictureBox1.Image = Image.FromFile("4.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem4PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 5)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem5PosInd;

            }

            Invoke(new Action(() =>
            {
              
                Ind1.Location = new Point(Properties.Settings.Default.ActPosInd[0], Properties.Settings.Default.ActPosInd[1]);
                Ind2.Location = new Point(Properties.Settings.Default.ActPosInd[2], Properties.Settings.Default.ActPosInd[3]);
                Ind3.Location = new Point(Properties.Settings.Default.ActPosInd[4], Properties.Settings.Default.ActPosInd[5]);
                Ind4.Location = new Point(Properties.Settings.Default.ActPosInd[6], Properties.Settings.Default.ActPosInd[7]);
                Ind5.Location = new Point(Properties.Settings.Default.ActPosInd[8], Properties.Settings.Default.ActPosInd[9]);
                Ind6.Location = new Point(Properties.Settings.Default.ActPosInd[10], Properties.Settings.Default.ActPosInd[11]);
                Ind7.Location = new Point(Properties.Settings.Default.ActPosInd[12], Properties.Settings.Default.ActPosInd[13]);
                Ind8.Location = new Point(Properties.Settings.Default.ActPosInd[14], Properties.Settings.Default.ActPosInd[15]);
                Ind9.Location = new Point(Properties.Settings.Default.ActPosInd[16], Properties.Settings.Default.ActPosInd[17]);
                Ind10.Location = new Point(Properties.Settings.Default.ActPosInd[18], Properties.Settings.Default.ActPosInd[19]);
                Ind11.Location = new Point(Properties.Settings.Default.ActPosInd[20], Properties.Settings.Default.ActPosInd[21]);
                Ind12.Location = new Point(Properties.Settings.Default.ActPosInd[22], Properties.Settings.Default.ActPosInd[23]);
                Ind13.Location = new Point(Properties.Settings.Default.ActPosInd[24], Properties.Settings.Default.ActPosInd[25]);
                Ind14.Location = new Point(Properties.Settings.Default.ActPosInd[26], Properties.Settings.Default.ActPosInd[27]);
                Ind15.Location = new Point(Properties.Settings.Default.ActPosInd[28], Properties.Settings.Default.ActPosInd[29]);
                Ind16.Location = new Point(Properties.Settings.Default.ActPosInd[30], Properties.Settings.Default.ActPosInd[31]);
                Ind17.Location = new Point(Properties.Settings.Default.ActPosInd[32], Properties.Settings.Default.ActPosInd[33]);
                Ind18.Location = new Point(Properties.Settings.Default.ActPosInd[34], Properties.Settings.Default.ActPosInd[35]);
                Ind19.Location = new Point(Properties.Settings.Default.ActPosInd[36], Properties.Settings.Default.ActPosInd[37]);
                Ind20.Location = new Point(Properties.Settings.Default.ActPosInd[38], Properties.Settings.Default.ActPosInd[39]);

            }));



            if (TB_Ind1.Text == "1") 
            {
                Ind1.BackColor = Color.Yellow;
                            }
            else if (TB_Ind1.Text == "2")

            {
                Ind1.BackColor = Color.LightGreen;
            }
            else if (TB_Ind1.Text == "3")

            {
                Ind1.BackColor = Color.Red;
            }
            else  
            {
                Ind1.BackColor = Color.Blue;
            }

            if (TB_Ind2.Text == "1")
            {
                Ind2.BackColor = Color.Yellow;
            }
            else if (TB_Ind2.Text == "2")

            {
                Ind2.BackColor = Color.LightGreen;
            }
            else if (TB_Ind2.Text == "3")

            {
                Ind2.BackColor = Color.Red;
            }
            else
            {
                Ind2.BackColor = Color.Blue;
            }

            if (TB_Ind3.Text == "1")
            {
                Ind3.BackColor = Color.Yellow;
            }
            else if (TB_Ind3.Text == "2")

            {
                Ind3.BackColor = Color.LightGreen;
            }
            else if (TB_Ind3.Text == "3")

            {
                Ind3.BackColor = Color.Red;
            }
            else
            {
                Ind3.BackColor = Color.Blue;
            }

            if (TB_Ind4.Text == "1")
            {
                Ind4.BackColor = Color.Yellow;
            }
            else if (TB_Ind4.Text == "2")

            {
                Ind4.BackColor = Color.LightGreen;
            }
            else if (TB_Ind4.Text == "3")

            {
                Ind4.BackColor = Color.Red;
            }
            else
            {
                Ind4.BackColor = Color.Blue;
            }

            if (TB_Ind5.Text == "1")
            {
                Ind5.BackColor = Color.Yellow;
            }
            else if (TB_Ind5.Text == "2")

            {
                Ind5.BackColor = Color.LightGreen;
            }
            else if (TB_Ind5.Text == "3")

            {
                Ind5.BackColor = Color.Red;
            }
            else
            {
                Ind5.BackColor = Color.Blue;
            }

            if (TB_Ind6.Text == "1")
            {
                Ind6.BackColor = Color.Yellow;
            }
            else if (TB_Ind6.Text == "2")

            {
                Ind6.BackColor = Color.LightGreen;
            }
            else if (TB_Ind6.Text == "3")

            {
                Ind6.BackColor = Color.Red;
            }
            else
            {
                Ind6.BackColor = Color.Blue;
            }

            if (TB_Ind7.Text == "1")
            {
                Ind7.BackColor = Color.Yellow;
            }
            else if (TB_Ind7.Text == "2")

            {
                Ind7.BackColor = Color.LightGreen;
            }
            else if (TB_Ind7.Text == "3")

            {
                Ind7.BackColor = Color.Red;
            }
            else
            {
                Ind7.BackColor = Color.Blue;
            }

            if (TB_Ind8.Text == "1")
            {
                Ind8.BackColor = Color.Yellow;
            }
            else if (TB_Ind8.Text == "2")

            {
                Ind8.BackColor = Color.LightGreen;
            }
            else if (TB_Ind8.Text == "3")

            {
                Ind8.BackColor = Color.Red;
            }
            else
            {
                Ind8.BackColor = Color.Blue;
            }

            if (TB_Ind9.Text == "1")
            {
                Ind9.BackColor = Color.Yellow;
            }
            else if (TB_Ind9.Text == "2")

            {
                Ind9.BackColor = Color.LightGreen;
            }
            else if (TB_Ind9.Text == "3")

            {
                Ind9.BackColor = Color.Red;
            }
            else
            {
                Ind9.BackColor = Color.Blue;
            }

            if (TB_Ind10.Text == "1")
            {
                Ind10.BackColor = Color.Yellow;
            }
            else if (TB_Ind10.Text == "2")

            {
                Ind10.BackColor = Color.LightGreen;
            }
            else if (TB_Ind10.Text == "3")

            {
                Ind10.BackColor = Color.Red;
            }
            else
            {
                Ind10.BackColor = Color.Blue;
            }

            if (TB_Ind11.Text == "1")
            {
                Ind11.BackColor = Color.Yellow;
            }
            else if (TB_Ind11.Text == "2")

            {
                Ind11.BackColor = Color.LightGreen;
            }
            else if (TB_Ind11.Text == "3")

            {
                Ind11.BackColor = Color.Red;
            }
            else
            {
                Ind11.BackColor = Color.Blue;
            }

            if (TB_Ind12.Text == "1")
            {
                Ind12.BackColor = Color.Yellow;
            }
            else if (TB_Ind12.Text == "2")

            {
                Ind12.BackColor = Color.LightGreen;
            }
            else if (TB_Ind12.Text == "3")

            {
                Ind12.BackColor = Color.Red;
            }
            else
            {
                Ind12.BackColor = Color.Blue;
            }

            if (TB_Ind13.Text == "1")
            {
                Ind13.BackColor = Color.Yellow;
            }
            else if (TB_Ind13.Text == "2")

            {
                Ind13.BackColor = Color.LightGreen;
            }
            else if (TB_Ind13.Text == "3")

            {
                Ind13.BackColor = Color.Red;
            }
            else
            {
                Ind13.BackColor = Color.Blue;
            }

            if (TB_Ind14.Text == "1")
            {
                Ind14.BackColor = Color.Yellow;
            }
            else if (TB_Ind14.Text == "2")

            {
                Ind14.BackColor = Color.LightGreen;
            }
            else if (TB_Ind14.Text == "3")

            {
                Ind14.BackColor = Color.Red;
            }
            else
            {
                Ind14.BackColor = Color.Blue;
            }

            if (TB_Ind15.Text == "1")
            {
                Ind15.BackColor = Color.Yellow;
            }
            else if (TB_Ind15.Text == "2")

            {
                Ind15.BackColor = Color.LightGreen;
            }
            else if (TB_Ind15.Text == "3")

            {
                Ind15.BackColor = Color.Red;
            }
            else
            {
                Ind15.BackColor = Color.Blue;
            }

            if (TB_Ind16.Text == "1")
            {
                Ind16.BackColor = Color.Yellow;
            }
            else if (TB_Ind16.Text == "2")

            {
                Ind16.BackColor = Color.LightGreen;
            }
            else if (TB_Ind16.Text == "3")

            {
                Ind16.BackColor = Color.Red;
            }
            else
            {
                Ind16.BackColor = Color.Blue;
            }

            if (TB_Ind17.Text == "1")
            {
                Ind17.BackColor = Color.Yellow;
            }
            else if (TB_Ind17.Text == "2")

            {
                Ind17.BackColor = Color.LightGreen;
            }
            else if (TB_Ind17.Text == "3")

            {
                Ind17.BackColor = Color.Red;
            }
            else
            {
                Ind17.BackColor = Color.Blue;
            }

            if (TB_Ind18.Text == "1")
            {
                Ind18.BackColor = Color.Yellow;
            }
            else if (TB_Ind18.Text == "2")

            {
                Ind18.BackColor = Color.LightGreen;
            }
            else if (TB_Ind18.Text == "3")

            {
                Ind18.BackColor = Color.Red;
            }
            else
            {
                Ind18.BackColor = Color.Blue;
            }

            if (TB_Ind19.Text == "1")
            {
                Ind19.BackColor = Color.Yellow;
            }
            else if (TB_Ind19.Text == "2")

            {
                Ind19.BackColor = Color.LightGreen;
            }
            else if (TB_Ind19.Text == "3")

            {
                Ind19.BackColor = Color.Red;
            }
            else
            {
                Ind19.BackColor = Color.Blue;
            }

            if (TB_Ind20.Text == "1")
            {
                Ind20.BackColor = Color.Yellow;
            }
            else if (TB_Ind20.Text == "2")

            {
                Ind20.BackColor = Color.LightGreen;
            }
            else if (TB_Ind20.Text == "3")

            {
                Ind20.BackColor = Color.Red;
            }
            else
            {
                Ind20.BackColor = Color.Blue;
            }


        }
        void HZ()

        {
            
           
        }

       

        


        private void ser_StartBT_Click_1(object sender, EventArgs e)
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


        private void timer1_Tick(object sender, EventArgs e)
        {

            

            if (textBox1.Text == text)
            {
                textBox1.Text = text1;
                data = text1;
            }
            else
            {

                textBox1.Text = text;
                data = text;
            }

            if (dataLenght >= 4)
            {
                if (dataLenght == Convert.ToInt32(data.Substring(2, 2)) + 4)
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

            if (dataLenght >= 5)
            {
                TB_Ntask.Text = data.Substring(0, 2);
                TB_ReqInd.Text = data.Substring(2, 2);
                TB_Ind1.Text = data.Substring(4, 1);
                if (dataLenght >= 6)
                {
                    TB_Ind2.Text = data.Substring(5, 1);
                    if (dataLenght >= 7)
                    {
                        TB_Ind3.Text = data.Substring(6, 1);
                        if (dataLenght >= 8)
                        {
                            TB_Ind4.Text = data.Substring(7, 1);
                            if (dataLenght >= 9)
                            {
                                TB_Ind5.Text = data.Substring(8, 1);
                                if (dataLenght >= 10)
                                {
                                    TB_Ind6.Text = data.Substring(9, 1);
                                    if (dataLenght >= 11)
                                    {
                                        TB_Ind7.Text = data.Substring(10, 1);
                                        if (dataLenght >= 12)
                                        {
                                            TB_Ind8.Text = data.Substring(11, 1);
                                            if (dataLenght >= 13)
                                            {
                                                TB_Ind9.Text = data.Substring(12, 1);
                                                if (dataLenght >= 14)
                                                {
                                                    TB_Ind10.Text = data.Substring(13, 1);
                                                    if (dataLenght >= 15)
                                                    {
                                                        TB_Ind11.Text = data.Substring(14, 1);
                                                        if (dataLenght >= 16)
                                                        {
                                                            TB_Ind12.Text = data.Substring(15, 1);
                                                            if (dataLenght >= 17)
                                                            {
                                                                TB_Ind13.Text = data.Substring(16, 1);
                                                                if (dataLenght >= 18)
                                                                {
                                                                    TB_Ind14.Text = data.Substring(17, 1);
                                                                    if (dataLenght >= 19)
                                                                    {
                                                                        TB_Ind15.Text = data.Substring(18, 1);
                                                                        if (dataLenght >= 20)
                                                                        {
                                                                            TB_Ind16.Text = data.Substring(19, 1);
                                                                            if (dataLenght >= 21)
                                                                            {
                                                                                TB_Ind17.Text = data.Substring(20, 1);
                                                                                if (dataLenght >= 22)
                                                                                {
                                                                                    TB_Ind18.Text = data.Substring(21, 1);
                                                                                    if (dataLenght >= 23)
                                                                                    {
                                                                                        TB_Ind19.Text = data.Substring(22, 1);
                                                                                        if (dataLenght >= 24)
                                                                                        {
                                                                                            TB_Ind20.Text = data.Substring(23, 1);

                                                                                        }

                                                                                        else
                                                                                        {
                                                                                            TB_Ind20.Text = "";
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        TB_Ind19.Text = "";
                                                                                        TB_Ind20.Text = "";
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    TB_Ind18.Text = "";
                                                                                    TB_Ind19.Text = "";
                                                                                    TB_Ind20.Text = "";
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                TB_Ind17.Text = "";
                                                                                TB_Ind18.Text = "";
                                                                                TB_Ind19.Text = "";
                                                                                TB_Ind20.Text = "";
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            TB_Ind16.Text = "";
                                                                            TB_Ind17.Text = "";
                                                                            TB_Ind18.Text = "";
                                                                            TB_Ind19.Text = "";
                                                                            TB_Ind20.Text = "";
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        TB_Ind15.Text = "";
                                                                        TB_Ind16.Text = "";
                                                                        TB_Ind17.Text = "";
                                                                        TB_Ind18.Text = "";
                                                                        TB_Ind19.Text = "";
                                                                        TB_Ind20.Text = "";
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    TB_Ind14.Text = "";
                                                                    TB_Ind15.Text = "";
                                                                    TB_Ind16.Text = "";
                                                                    TB_Ind17.Text = "";
                                                                    TB_Ind18.Text = "";
                                                                    TB_Ind19.Text = "";
                                                                    TB_Ind20.Text = "";
                                                                }
                                                            }
                                                            else
                                                            {
                                                                TB_Ind13.Text = "";
                                                                TB_Ind14.Text = "";
                                                                TB_Ind15.Text = "";
                                                                TB_Ind16.Text = "";
                                                                TB_Ind17.Text = "";
                                                                TB_Ind18.Text = "";
                                                                TB_Ind19.Text = "";
                                                                TB_Ind20.Text = "";
                                                            }
                                                        }
                                                        else
                                                        {

                                                            TB_Ind12.Text = "";
                                                            TB_Ind13.Text = "";
                                                            TB_Ind15.Text = "";
                                                            TB_Ind16.Text = "";
                                                            TB_Ind17.Text = "";
                                                            TB_Ind18.Text = "";
                                                            TB_Ind19.Text = "";
                                                            TB_Ind20.Text = "";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        TB_Ind11.Text = "";
                                                        TB_Ind12.Text = "";
                                                        TB_Ind13.Text = "";
                                                        TB_Ind14.Text = "";
                                                        TB_Ind15.Text = "";
                                                        TB_Ind16.Text = "";
                                                        TB_Ind17.Text = "";
                                                        TB_Ind18.Text = "";
                                                        TB_Ind19.Text = "";
                                                        TB_Ind20.Text = "";
                                                    }
                                                }

                                                else
                                                {
                                                    TB_Ind10.Text = "";
                                                    TB_Ind11.Text = "";
                                                    TB_Ind12.Text = "";
                                                    TB_Ind13.Text = "";
                                                    TB_Ind14.Text = "";
                                                    TB_Ind15.Text = "";
                                                    TB_Ind16.Text = "";
                                                    TB_Ind17.Text = "";
                                                    TB_Ind18.Text = "";
                                                    TB_Ind19.Text = "";
                                                    TB_Ind20.Text = "";
                                                }
                                            }
                                            else
                                            {
                                                TB_Ind9.Text = "";
                                                TB_Ind10.Text = "";
                                                TB_Ind11.Text = "";
                                                TB_Ind12.Text = "";
                                                TB_Ind13.Text = "";
                                                TB_Ind14.Text = "";
                                                TB_Ind15.Text = "";
                                                TB_Ind16.Text = "";
                                                TB_Ind17.Text = "";
                                                TB_Ind18.Text = "";
                                                TB_Ind19.Text = "";
                                                TB_Ind20.Text = "";
                                            }
                                        }
                                        else
                                        {
                                            TB_Ind8.Text = "";
                                            TB_Ind9.Text = "";
                                            TB_Ind10.Text = "";
                                            TB_Ind11.Text = "";
                                            TB_Ind12.Text = "";
                                            TB_Ind13.Text = "";
                                            TB_Ind14.Text = "";
                                            TB_Ind15.Text = "";
                                            TB_Ind16.Text = "";
                                            TB_Ind17.Text = "";
                                            TB_Ind18.Text = "";
                                            TB_Ind19.Text = "";
                                            TB_Ind20.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        TB_Ind7.Text = "";
                                        TB_Ind8.Text = "";
                                        TB_Ind9.Text = "";
                                        TB_Ind10.Text = "";
                                        TB_Ind11.Text = "";
                                        TB_Ind12.Text = "";
                                        TB_Ind13.Text = "";
                                        TB_Ind14.Text = "";
                                        TB_Ind15.Text = "";
                                        TB_Ind16.Text = "";
                                        TB_Ind17.Text = "";
                                        TB_Ind18.Text = "";
                                        TB_Ind19.Text = "";
                                        TB_Ind20.Text = "";
                                    }
                                }
                                else
                                {
                                    TB_Ind6.Text = "";
                                    TB_Ind7.Text = "";
                                    TB_Ind8.Text = "";
                                    TB_Ind9.Text = "";
                                    TB_Ind10.Text = "";
                                    TB_Ind11.Text = "";
                                    TB_Ind12.Text = "";
                                    TB_Ind13.Text = "";
                                    TB_Ind14.Text = "";
                                    TB_Ind15.Text = "";
                                    TB_Ind16.Text = "";
                                    TB_Ind17.Text = "";
                                    TB_Ind18.Text = "";
                                    TB_Ind19.Text = "";
                                    TB_Ind20.Text = "";
                                }
                            }
                            else
                            {
                                TB_Ind5.Text = "";
                                TB_Ind6.Text = "";
                                TB_Ind7.Text = "";
                                TB_Ind8.Text = "";
                                TB_Ind9.Text = "";
                                TB_Ind10.Text = "";
                                TB_Ind11.Text = "";
                                TB_Ind12.Text = "";
                                TB_Ind13.Text = "";
                                TB_Ind14.Text = "";
                                TB_Ind15.Text = "";
                                TB_Ind16.Text = "";
                                TB_Ind17.Text = "";
                                TB_Ind18.Text = "";
                                TB_Ind19.Text = "";
                                TB_Ind20.Text = "";
                            }
                        }
                        else
                        {
                            TB_Ind4.Text = "";
                            TB_Ind5.Text = "";
                            TB_Ind6.Text = "";
                            TB_Ind7.Text = "";
                            TB_Ind8.Text = "";
                            TB_Ind9.Text = "";
                            TB_Ind10.Text = "";
                            TB_Ind11.Text = "";
                            TB_Ind12.Text = "";
                            TB_Ind13.Text = "";
                            TB_Ind14.Text = "";
                            TB_Ind15.Text = "";
                            TB_Ind16.Text = "";
                            TB_Ind17.Text = "";
                            TB_Ind18.Text = "";
                            TB_Ind19.Text = "";
                            TB_Ind20.Text = "";
                        }
                    }
                    else
                    {
                        TB_Ind3.Text = "";
                        TB_Ind4.Text = "";
                        TB_Ind5.Text = "";
                        TB_Ind6.Text = "";
                        TB_Ind7.Text = "";
                        TB_Ind8.Text = "";
                        TB_Ind9.Text = "";
                        TB_Ind10.Text = "";
                        TB_Ind11.Text = "";
                        TB_Ind12.Text = "";
                        TB_Ind13.Text = "";
                        TB_Ind14.Text = "";
                        TB_Ind15.Text = "";
                        TB_Ind16.Text = "";
                        TB_Ind17.Text = "";
                        TB_Ind18.Text = "";
                        TB_Ind19.Text = "";
                        TB_Ind20.Text = "";
                    }
                }
                else
                {
                    TB_Ind2.Text = "";
                    TB_Ind3.Text = "";
                    TB_Ind4.Text = "";
                    TB_Ind5.Text = "";
                    TB_Ind6.Text = "";
                    TB_Ind7.Text = "";
                    TB_Ind8.Text = "";
                    TB_Ind9.Text = "";
                    TB_Ind10.Text = "";
                    TB_Ind11.Text = "";
                    TB_Ind12.Text = "";
                    TB_Ind13.Text = "";
                    TB_Ind14.Text = "";
                    TB_Ind15.Text = "";
                    TB_Ind16.Text = "";
                    TB_Ind17.Text = "";
                    TB_Ind18.Text = "";
                    TB_Ind19.Text = "";
                    //TB_Ind20.Text = "";
                }
            }
            else
            {
                TB_Ntask.Text = "";
                TB_Ind1.Text = "";
                TB_Ind2.Text = "";
                TB_Ind3.Text = "";
                TB_Ind4.Text = "";
                TB_Ind5.Text = "";
                TB_Ind6.Text = "";
                TB_Ind7.Text = "";
                TB_Ind8.Text = "";
                TB_Ind9.Text = "";
                TB_Ind10.Text = "";
                TB_Ind11.Text = "";
                TB_Ind12.Text = "";
                TB_Ind13.Text = "";
                TB_Ind14.Text = "";
                TB_Ind15.Text = "";
                TB_Ind16.Text = "";
                TB_Ind17.Text = "";
                TB_Ind18.Text = "";
                TB_Ind19.Text = "";
                TB_Ind20.Text = "";
            }

            if (Convert.ToInt32(TB_ReqInd.Text) >= 1)
            {
                Ind1.Visible = true;
                Ind2.Visible = false;
                Ind3.Visible = false;
                Ind4.Visible = false;
                Ind5.Visible = false;
                Ind6.Visible = false;
                Ind7.Visible = false;
                Ind8.Visible = false;
                Ind9.Visible = false;
                Ind10.Visible = false;
                Ind11.Visible = false;
                Ind12.Visible = false;
                Ind13.Visible = false;
                Ind14.Visible = false;
                Ind15.Visible = false;
                Ind16.Visible = false;
                Ind17.Visible = false;
                Ind18.Visible = false;
                Ind19.Visible = false;
                Ind20.Visible = false;

                if (Convert.ToInt32(TB_ReqInd.Text) >= 2)
                {
                    Ind2.Visible = true;
                    if (Convert.ToInt32(TB_ReqInd.Text) >= 3)
                    {
                        Ind3.Visible = true;
                        if (Convert.ToInt32(TB_ReqInd.Text) >= 4)
                        {
                            Ind4.Visible = true;
                            if (Convert.ToInt32(TB_ReqInd.Text) >= 5)
                            {
                                Ind5.Visible = true;
                                if (Convert.ToInt32(TB_ReqInd.Text) >= 6)
                                {
                                    Ind6.Visible = true;
                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 7)
                                    {
                                        Ind7.Visible = true;
                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 8)
                                        {
                                            Ind8.Visible = true;
                                            if (Convert.ToInt32(TB_ReqInd.Text) >= 9)
                                            {
                                                Ind9.Visible = true;
                                                if (Convert.ToInt32(TB_ReqInd.Text) >= 10)
                                                {
                                                    Ind10.Visible = true;
                                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 11)
                                                    {
                                                        Ind11.Visible = true;
                                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 12)
                                                        {
                                                            Ind12.Visible = true;
                                                            if (Convert.ToInt32(TB_ReqInd.Text) >= 13)
                                                            {
                                                                Ind13.Visible = true;
                                                                if (Convert.ToInt32(TB_ReqInd.Text) >= 14)
                                                                {
                                                                    Ind14.Visible = true;
                                                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 15)
                                                                    {
                                                                        Ind15.Visible = true;
                                                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 16)
                                                                        {
                                                                            Ind16.Visible = true;
                                                                            if (Convert.ToInt32(TB_ReqInd.Text) >= 17)
                                                                            {
                                                                                Ind17.Visible = true;
                                                                                if (Convert.ToInt32(TB_ReqInd.Text) >= 18)
                                                                                {
                                                                                    Ind18.Visible = true;
                                                                                    if (Convert.ToInt32(TB_ReqInd.Text) >= 19)
                                                                                    {
                                                                                        Ind19.Visible = true;
                                                                                        if (Convert.ToInt32(TB_ReqInd.Text) >= 20)
                                                                                        {
                                                                                            Ind20.Visible = true;
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            

            if (Convert.ToInt32(TB_Ntask.Text) == 1)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem1PosInd;

            }
            if (Convert.ToInt32(TB_Ntask.Text) == 2)
            {
                pictureBox1.Image = Image.FromFile("2.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem2PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 3)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem3PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 4)
            {
                pictureBox1.Image = Image.FromFile("4.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem4PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 5)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem5PosInd;

            }

            Invoke(new Action(() =>
            {

                Ind1.Location = new Point(Properties.Settings.Default.ActPosInd[0], Properties.Settings.Default.ActPosInd[1]);
                Ind2.Location = new Point(Properties.Settings.Default.ActPosInd[2], Properties.Settings.Default.ActPosInd[3]);
                Ind3.Location = new Point(Properties.Settings.Default.ActPosInd[4], Properties.Settings.Default.ActPosInd[5]);
                Ind4.Location = new Point(Properties.Settings.Default.ActPosInd[6], Properties.Settings.Default.ActPosInd[7]);
                Ind5.Location = new Point(Properties.Settings.Default.ActPosInd[8], Properties.Settings.Default.ActPosInd[9]);
                Ind6.Location = new Point(Properties.Settings.Default.ActPosInd[10], Properties.Settings.Default.ActPosInd[11]);
                Ind7.Location = new Point(Properties.Settings.Default.ActPosInd[12], Properties.Settings.Default.ActPosInd[13]);
                Ind8.Location = new Point(Properties.Settings.Default.ActPosInd[14], Properties.Settings.Default.ActPosInd[15]);
                Ind9.Location = new Point(Properties.Settings.Default.ActPosInd[16], Properties.Settings.Default.ActPosInd[17]);
                Ind10.Location = new Point(Properties.Settings.Default.ActPosInd[18], Properties.Settings.Default.ActPosInd[19]);
                Ind11.Location = new Point(Properties.Settings.Default.ActPosInd[20], Properties.Settings.Default.ActPosInd[21]);
                Ind12.Location = new Point(Properties.Settings.Default.ActPosInd[22], Properties.Settings.Default.ActPosInd[23]);
                Ind13.Location = new Point(Properties.Settings.Default.ActPosInd[24], Properties.Settings.Default.ActPosInd[25]);
                Ind14.Location = new Point(Properties.Settings.Default.ActPosInd[26], Properties.Settings.Default.ActPosInd[27]);
                Ind15.Location = new Point(Properties.Settings.Default.ActPosInd[28], Properties.Settings.Default.ActPosInd[29]);
                Ind16.Location = new Point(Properties.Settings.Default.ActPosInd[30], Properties.Settings.Default.ActPosInd[31]);
                Ind17.Location = new Point(Properties.Settings.Default.ActPosInd[32], Properties.Settings.Default.ActPosInd[33]);
                Ind18.Location = new Point(Properties.Settings.Default.ActPosInd[34], Properties.Settings.Default.ActPosInd[35]);
                Ind19.Location = new Point(Properties.Settings.Default.ActPosInd[36], Properties.Settings.Default.ActPosInd[37]);
                Ind20.Location = new Point(Properties.Settings.Default.ActPosInd[38], Properties.Settings.Default.ActPosInd[39]);

            }));



            if (TB_Ind1.Text == "1")
            {
                Ind1.BackColor = Color.Yellow;
            }
            else if (TB_Ind1.Text == "2")

            {
                Ind1.BackColor = Color.LightGreen;
            }
            else if (TB_Ind1.Text == "3")

            {
                Ind1.BackColor = Color.Red;
            }
            else
            {
                Ind1.BackColor = Color.Blue;
            }

            if (TB_Ind2.Text == "1")
            {
                Ind2.BackColor = Color.Yellow;
            }
            else if (TB_Ind2.Text == "2")

            {
                Ind2.BackColor = Color.LightGreen;
            }
            else if (TB_Ind2.Text == "3")

            {
                Ind2.BackColor = Color.Red;
            }
            else
            {
                Ind2.BackColor = Color.Blue;
            }

            if (TB_Ind3.Text == "1")
            {
                Ind3.BackColor = Color.Yellow;
            }
            else if (TB_Ind3.Text == "2")

            {
                Ind3.BackColor = Color.LightGreen;
            }
            else if (TB_Ind3.Text == "3")

            {
                Ind3.BackColor = Color.Red;
            }
            else
            {
                Ind3.BackColor = Color.Blue;
            }

            if (TB_Ind4.Text == "1")
            {
                Ind4.BackColor = Color.Yellow;
            }
            else if (TB_Ind4.Text == "2")

            {
                Ind4.BackColor = Color.LightGreen;
            }
            else if (TB_Ind4.Text == "3")

            {
                Ind4.BackColor = Color.Red;
            }
            else
            {
                Ind4.BackColor = Color.Blue;
            }

            if (TB_Ind5.Text == "1")
            {
                Ind5.BackColor = Color.Yellow;
            }
            else if (TB_Ind5.Text == "2")

            {
                Ind5.BackColor = Color.LightGreen;
            }
            else if (TB_Ind5.Text == "3")

            {
                Ind5.BackColor = Color.Red;
            }
            else
            {
                Ind5.BackColor = Color.Blue;
            }

            if (TB_Ind6.Text == "1")
            {
                Ind6.BackColor = Color.Yellow;
            }
            else if (TB_Ind6.Text == "2")

            {
                Ind6.BackColor = Color.LightGreen;
            }
            else if (TB_Ind6.Text == "3")

            {
                Ind6.BackColor = Color.Red;
            }
            else
            {
                Ind6.BackColor = Color.Blue;
            }

            if (TB_Ind7.Text == "1")
            {
                Ind7.BackColor = Color.Yellow;
            }
            else if (TB_Ind7.Text == "2")

            {
                Ind7.BackColor = Color.LightGreen;
            }
            else if (TB_Ind7.Text == "3")

            {
                Ind7.BackColor = Color.Red;
            }
            else
            {
                Ind7.BackColor = Color.Blue;
            }

            if (TB_Ind8.Text == "1")
            {
                Ind8.BackColor = Color.Yellow;
            }
            else if (TB_Ind8.Text == "2")

            {
                Ind8.BackColor = Color.LightGreen;
            }
            else if (TB_Ind8.Text == "3")

            {
                Ind8.BackColor = Color.Red;
            }
            else
            {
                Ind8.BackColor = Color.Blue;
            }

            if (TB_Ind9.Text == "1")
            {
                Ind9.BackColor = Color.Yellow;
            }
            else if (TB_Ind9.Text == "2")

            {
                Ind9.BackColor = Color.LightGreen;
            }
            else if (TB_Ind9.Text == "3")

            {
                Ind9.BackColor = Color.Red;
            }
            else
            {
                Ind9.BackColor = Color.Blue;
            }

            if (TB_Ind10.Text == "1")
            {
                Ind10.BackColor = Color.Yellow;
            }
            else if (TB_Ind10.Text == "2")

            {
                Ind10.BackColor = Color.LightGreen;
            }
            else if (TB_Ind10.Text == "3")

            {
                Ind10.BackColor = Color.Red;
            }
            else
            {
                Ind10.BackColor = Color.Blue;
            }

            if (TB_Ind11.Text == "1")
            {
                Ind11.BackColor = Color.Yellow;
            }
            else if (TB_Ind11.Text == "2")

            {
                Ind11.BackColor = Color.LightGreen;
            }
            else if (TB_Ind11.Text == "3")

            {
                Ind11.BackColor = Color.Red;
            }
            else
            {
                Ind11.BackColor = Color.Blue;
            }

            if (TB_Ind12.Text == "1")
            {
                Ind12.BackColor = Color.Yellow;
            }
            else if (TB_Ind12.Text == "2")

            {
                Ind12.BackColor = Color.LightGreen;
            }
            else if (TB_Ind12.Text == "3")

            {
                Ind12.BackColor = Color.Red;
            }
            else
            {
                Ind12.BackColor = Color.Blue;
            }

            if (TB_Ind13.Text == "1")
            {
                Ind13.BackColor = Color.Yellow;
            }
            else if (TB_Ind13.Text == "2")

            {
                Ind13.BackColor = Color.LightGreen;
            }
            else if (TB_Ind13.Text == "3")

            {
                Ind13.BackColor = Color.Red;
            }
            else
            {
                Ind13.BackColor = Color.Blue;
            }

            if (TB_Ind14.Text == "1")
            {
                Ind14.BackColor = Color.Yellow;
            }
            else if (TB_Ind14.Text == "2")

            {
                Ind14.BackColor = Color.LightGreen;
            }
            else if (TB_Ind14.Text == "3")

            {
                Ind14.BackColor = Color.Red;
            }
            else
            {
                Ind14.BackColor = Color.Blue;
            }

            if (TB_Ind15.Text == "1")
            {
                Ind15.BackColor = Color.Yellow;
            }
            else if (TB_Ind15.Text == "2")

            {
                Ind15.BackColor = Color.LightGreen;
            }
            else if (TB_Ind15.Text == "3")

            {
                Ind15.BackColor = Color.Red;
            }
            else
            {
                Ind15.BackColor = Color.Blue;
            }

            if (TB_Ind16.Text == "1")
            {
                Ind16.BackColor = Color.Yellow;
            }
            else if (TB_Ind16.Text == "2")

            {
                Ind16.BackColor = Color.LightGreen;
            }
            else if (TB_Ind16.Text == "3")

            {
                Ind16.BackColor = Color.Red;
            }
            else
            {
                Ind16.BackColor = Color.Blue;
            }

            if (TB_Ind17.Text == "1")
            {
                Ind17.BackColor = Color.Yellow;
            }
            else if (TB_Ind17.Text == "2")

            {
                Ind17.BackColor = Color.LightGreen;
            }
            else if (TB_Ind17.Text == "3")

            {
                Ind17.BackColor = Color.Red;
            }
            else
            {
                Ind17.BackColor = Color.Blue;
            }

            if (TB_Ind18.Text == "1")
            {
                Ind18.BackColor = Color.Yellow;
            }
            else if (TB_Ind18.Text == "2")

            {
                Ind18.BackColor = Color.LightGreen;
            }
            else if (TB_Ind18.Text == "3")

            {
                Ind18.BackColor = Color.Red;
            }
            else
            {
                Ind18.BackColor = Color.Blue;
            }

            if (TB_Ind19.Text == "1")
            {
                Ind19.BackColor = Color.Yellow;
            }
            else if (TB_Ind19.Text == "2")

            {
                Ind19.BackColor = Color.LightGreen;
            }
            else if (TB_Ind19.Text == "3")

            {
                Ind19.BackColor = Color.Red;
            }
            else
            {
                Ind19.BackColor = Color.Blue;
            }

            if (TB_Ind20.Text == "1")
            {
                Ind20.BackColor = Color.Yellow;
            }
            else if (TB_Ind20.Text == "2")

            {
                Ind20.BackColor = Color.LightGreen;
            }
            else if (TB_Ind20.Text == "3")

            {
                Ind20.BackColor = Color.Red;
            }
            else
            {
                Ind20.BackColor = Color.Blue;
            }



            dataint1 = ++dataint1;
            

            if (dataint1 == 3)
            {
                text = "021312312312312312312312";
                text1 = "021323123123123123123123";
            }
            if (dataint1 == 6)
            {
                text = "030812312312312312312312";
                text1 = "030823123123123123123123";
               
            }

            if (dataint1 == 9)
            {
                text = "041612312312312312312312";
                text1 = "041623123123123123123123";
               
            }
            if (dataint1 == 12)
            {
                text = "051012312312312312312312";
                text1 = "051023123123123123123123";
             
            }
            if (dataint1 == 15)
            {
                text = "011812312312312312312312";
                text1 = "011823123123123123123123";
                dataint1 = 0;
            }

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
                textBox1.Text = text;
                dataLenght = 24;
                data = text;
                timer1.Start();
                TimerOn = true;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butN1_Click(object sender, EventArgs e)
        {

            TB_Ntask.Text = "01";
            data = text;
            dataLenght = 24;

         


            if (Convert.ToInt32(TB_Ntask.Text) == 1)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem1PosInd;

            }
            if (Convert.ToInt32(TB_Ntask.Text) == 2)
            {
                pictureBox1.Image = Image.FromFile("2.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem2PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 3)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem3PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 4)
            {
                pictureBox1.Image = Image.FromFile("4.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem4PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 5)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem5PosInd;

            }


                Ind1.Location = new Point(Properties.Settings.Default.ActPosInd[0], Properties.Settings.Default.ActPosInd[1]);
                Ind2.Location = new Point(Properties.Settings.Default.ActPosInd[2], Properties.Settings.Default.ActPosInd[3]);
                Ind3.Location = new Point(Properties.Settings.Default.ActPosInd[4], Properties.Settings.Default.ActPosInd[5]);
                Ind4.Location = new Point(Properties.Settings.Default.ActPosInd[6], Properties.Settings.Default.ActPosInd[7]);
                Ind5.Location = new Point(Properties.Settings.Default.ActPosInd[8], Properties.Settings.Default.ActPosInd[9]);
                Ind6.Location = new Point(Properties.Settings.Default.ActPosInd[10], Properties.Settings.Default.ActPosInd[11]);
                Ind7.Location = new Point(Properties.Settings.Default.ActPosInd[12], Properties.Settings.Default.ActPosInd[13]);
                Ind8.Location = new Point(Properties.Settings.Default.ActPosInd[14], Properties.Settings.Default.ActPosInd[15]);
                Ind9.Location = new Point(Properties.Settings.Default.ActPosInd[16], Properties.Settings.Default.ActPosInd[17]);
                Ind10.Location = new Point(Properties.Settings.Default.ActPosInd[18], Properties.Settings.Default.ActPosInd[19]);
                Ind11.Location = new Point(Properties.Settings.Default.ActPosInd[20], Properties.Settings.Default.ActPosInd[21]);
                Ind12.Location = new Point(Properties.Settings.Default.ActPosInd[22], Properties.Settings.Default.ActPosInd[23]);
                Ind13.Location = new Point(Properties.Settings.Default.ActPosInd[24], Properties.Settings.Default.ActPosInd[25]);
                Ind14.Location = new Point(Properties.Settings.Default.ActPosInd[26], Properties.Settings.Default.ActPosInd[27]);
                Ind15.Location = new Point(Properties.Settings.Default.ActPosInd[28], Properties.Settings.Default.ActPosInd[29]);
                Ind16.Location = new Point(Properties.Settings.Default.ActPosInd[30], Properties.Settings.Default.ActPosInd[31]);
                Ind17.Location = new Point(Properties.Settings.Default.ActPosInd[32], Properties.Settings.Default.ActPosInd[33]);
                Ind18.Location = new Point(Properties.Settings.Default.ActPosInd[34], Properties.Settings.Default.ActPosInd[35]);
                Ind19.Location = new Point(Properties.Settings.Default.ActPosInd[36], Properties.Settings.Default.ActPosInd[37]);
                Ind20.Location = new Point(Properties.Settings.Default.ActPosInd[38], Properties.Settings.Default.ActPosInd[39]);

            
        }

        private void butN2_Click(object sender, EventArgs e)
        {
            TB_Ntask.Text = "02";
            data = text;
            dataLenght = 24;




            if (Convert.ToInt32(TB_Ntask.Text) == 1)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem1PosInd;

            }
            if (Convert.ToInt32(TB_Ntask.Text) == 2)
            {
                pictureBox1.Image = Image.FromFile("2.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem2PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 3)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem3PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 4)
            {
                pictureBox1.Image = Image.FromFile("4.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem4PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 5)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem5PosInd;

            }

            Invoke(new Action(() =>
            {

                Ind1.Location = new Point(Properties.Settings.Default.ActPosInd[0], Properties.Settings.Default.ActPosInd[1]);
                Ind2.Location = new Point(Properties.Settings.Default.ActPosInd[2], Properties.Settings.Default.ActPosInd[3]);
                Ind3.Location = new Point(Properties.Settings.Default.ActPosInd[4], Properties.Settings.Default.ActPosInd[5]);
                Ind4.Location = new Point(Properties.Settings.Default.ActPosInd[6], Properties.Settings.Default.ActPosInd[7]);
                Ind5.Location = new Point(Properties.Settings.Default.ActPosInd[8], Properties.Settings.Default.ActPosInd[9]);
                Ind6.Location = new Point(Properties.Settings.Default.ActPosInd[10], Properties.Settings.Default.ActPosInd[11]);
                Ind7.Location = new Point(Properties.Settings.Default.ActPosInd[12], Properties.Settings.Default.ActPosInd[13]);
                Ind8.Location = new Point(Properties.Settings.Default.ActPosInd[14], Properties.Settings.Default.ActPosInd[15]);
                Ind9.Location = new Point(Properties.Settings.Default.ActPosInd[16], Properties.Settings.Default.ActPosInd[17]);
                Ind10.Location = new Point(Properties.Settings.Default.ActPosInd[18], Properties.Settings.Default.ActPosInd[19]);
                Ind11.Location = new Point(Properties.Settings.Default.ActPosInd[20], Properties.Settings.Default.ActPosInd[21]);
                Ind12.Location = new Point(Properties.Settings.Default.ActPosInd[22], Properties.Settings.Default.ActPosInd[23]);
                Ind13.Location = new Point(Properties.Settings.Default.ActPosInd[24], Properties.Settings.Default.ActPosInd[25]);
                Ind14.Location = new Point(Properties.Settings.Default.ActPosInd[26], Properties.Settings.Default.ActPosInd[27]);
                Ind15.Location = new Point(Properties.Settings.Default.ActPosInd[28], Properties.Settings.Default.ActPosInd[29]);
                Ind16.Location = new Point(Properties.Settings.Default.ActPosInd[30], Properties.Settings.Default.ActPosInd[31]);
                Ind17.Location = new Point(Properties.Settings.Default.ActPosInd[32], Properties.Settings.Default.ActPosInd[33]);
                Ind18.Location = new Point(Properties.Settings.Default.ActPosInd[34], Properties.Settings.Default.ActPosInd[35]);
                Ind19.Location = new Point(Properties.Settings.Default.ActPosInd[36], Properties.Settings.Default.ActPosInd[37]);
                Ind20.Location = new Point(Properties.Settings.Default.ActPosInd[38], Properties.Settings.Default.ActPosInd[39]);

            }));
        }

        private void butN3_Click_1(object sender, EventArgs e)
        {
            TB_Ntask.Text = "03";
            data = text;
            dataLenght = 24;




            if (Convert.ToInt32(TB_Ntask.Text) == 1)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem1PosInd;

            }
            if (Convert.ToInt32(TB_Ntask.Text) == 2)
            {
                pictureBox1.Image = Image.FromFile("2.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem2PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 3)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem3PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 4)
            {
                pictureBox1.Image = Image.FromFile("4.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem4PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 5)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem5PosInd;

            }

            Invoke(new Action(() =>
            {

                Ind1.Location = new Point(Properties.Settings.Default.ActPosInd[0], Properties.Settings.Default.ActPosInd[1]);
                Ind2.Location = new Point(Properties.Settings.Default.ActPosInd[2], Properties.Settings.Default.ActPosInd[3]);
                Ind3.Location = new Point(Properties.Settings.Default.ActPosInd[4], Properties.Settings.Default.ActPosInd[5]);
                Ind4.Location = new Point(Properties.Settings.Default.ActPosInd[6], Properties.Settings.Default.ActPosInd[7]);
                Ind5.Location = new Point(Properties.Settings.Default.ActPosInd[8], Properties.Settings.Default.ActPosInd[9]);
                Ind6.Location = new Point(Properties.Settings.Default.ActPosInd[10], Properties.Settings.Default.ActPosInd[11]);
                Ind7.Location = new Point(Properties.Settings.Default.ActPosInd[12], Properties.Settings.Default.ActPosInd[13]);
                Ind8.Location = new Point(Properties.Settings.Default.ActPosInd[14], Properties.Settings.Default.ActPosInd[15]);
                Ind9.Location = new Point(Properties.Settings.Default.ActPosInd[16], Properties.Settings.Default.ActPosInd[17]);
                Ind10.Location = new Point(Properties.Settings.Default.ActPosInd[18], Properties.Settings.Default.ActPosInd[19]);
                Ind11.Location = new Point(Properties.Settings.Default.ActPosInd[20], Properties.Settings.Default.ActPosInd[21]);
                Ind12.Location = new Point(Properties.Settings.Default.ActPosInd[22], Properties.Settings.Default.ActPosInd[23]);
                Ind13.Location = new Point(Properties.Settings.Default.ActPosInd[24], Properties.Settings.Default.ActPosInd[25]);
                Ind14.Location = new Point(Properties.Settings.Default.ActPosInd[26], Properties.Settings.Default.ActPosInd[27]);
                Ind15.Location = new Point(Properties.Settings.Default.ActPosInd[28], Properties.Settings.Default.ActPosInd[29]);
                Ind16.Location = new Point(Properties.Settings.Default.ActPosInd[30], Properties.Settings.Default.ActPosInd[31]);
                Ind17.Location = new Point(Properties.Settings.Default.ActPosInd[32], Properties.Settings.Default.ActPosInd[33]);
                Ind18.Location = new Point(Properties.Settings.Default.ActPosInd[34], Properties.Settings.Default.ActPosInd[35]);
                Ind19.Location = new Point(Properties.Settings.Default.ActPosInd[36], Properties.Settings.Default.ActPosInd[37]);
                Ind20.Location = new Point(Properties.Settings.Default.ActPosInd[38], Properties.Settings.Default.ActPosInd[39]);

            }));
        }

        private void butN4_Click_1(object sender, EventArgs e)
        {
            TB_Ntask.Text = "04";
            data = text;
            dataLenght = 24;




            if (Convert.ToInt32(TB_Ntask.Text) == 1)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem1PosInd;

            }
            if (Convert.ToInt32(TB_Ntask.Text) == 2)
            {
                pictureBox1.Image = Image.FromFile("2.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem2PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 3)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem3PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 4)
            {
                pictureBox1.Image = Image.FromFile("4.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem4PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 5)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem5PosInd;

            }

            Invoke(new Action(() =>
            {

                Ind1.Location = new Point(Properties.Settings.Default.ActPosInd[0], Properties.Settings.Default.ActPosInd[1]);
                Ind2.Location = new Point(Properties.Settings.Default.ActPosInd[2], Properties.Settings.Default.ActPosInd[3]);
                Ind3.Location = new Point(Properties.Settings.Default.ActPosInd[4], Properties.Settings.Default.ActPosInd[5]);
                Ind4.Location = new Point(Properties.Settings.Default.ActPosInd[6], Properties.Settings.Default.ActPosInd[7]);
                Ind5.Location = new Point(Properties.Settings.Default.ActPosInd[8], Properties.Settings.Default.ActPosInd[9]);
                Ind6.Location = new Point(Properties.Settings.Default.ActPosInd[10], Properties.Settings.Default.ActPosInd[11]);
                Ind7.Location = new Point(Properties.Settings.Default.ActPosInd[12], Properties.Settings.Default.ActPosInd[13]);
                Ind8.Location = new Point(Properties.Settings.Default.ActPosInd[14], Properties.Settings.Default.ActPosInd[15]);
                Ind9.Location = new Point(Properties.Settings.Default.ActPosInd[16], Properties.Settings.Default.ActPosInd[17]);
                Ind10.Location = new Point(Properties.Settings.Default.ActPosInd[18], Properties.Settings.Default.ActPosInd[19]);
                Ind11.Location = new Point(Properties.Settings.Default.ActPosInd[20], Properties.Settings.Default.ActPosInd[21]);
                Ind12.Location = new Point(Properties.Settings.Default.ActPosInd[22], Properties.Settings.Default.ActPosInd[23]);
                Ind13.Location = new Point(Properties.Settings.Default.ActPosInd[24], Properties.Settings.Default.ActPosInd[25]);
                Ind14.Location = new Point(Properties.Settings.Default.ActPosInd[26], Properties.Settings.Default.ActPosInd[27]);
                Ind15.Location = new Point(Properties.Settings.Default.ActPosInd[28], Properties.Settings.Default.ActPosInd[29]);
                Ind16.Location = new Point(Properties.Settings.Default.ActPosInd[30], Properties.Settings.Default.ActPosInd[31]);
                Ind17.Location = new Point(Properties.Settings.Default.ActPosInd[32], Properties.Settings.Default.ActPosInd[33]);
                Ind18.Location = new Point(Properties.Settings.Default.ActPosInd[34], Properties.Settings.Default.ActPosInd[35]);
                Ind19.Location = new Point(Properties.Settings.Default.ActPosInd[36], Properties.Settings.Default.ActPosInd[37]);
                Ind20.Location = new Point(Properties.Settings.Default.ActPosInd[38], Properties.Settings.Default.ActPosInd[39]);

            }));
        }

        private void butN5_Click_1(object sender, EventArgs e)
        {
            TB_Ntask.Text = "05";
            data = text;
            dataLenght = 24;




            if (Convert.ToInt32(TB_Ntask.Text) == 1)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem1PosInd;

            }
            if (Convert.ToInt32(TB_Ntask.Text) == 2)
            {
                pictureBox1.Image = Image.FromFile("2.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem2PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 3)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem3PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 4)
            {
                pictureBox1.Image = Image.FromFile("4.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem4PosInd;
            }
            if (Convert.ToInt32(TB_Ntask.Text) == 5)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
                Properties.Settings.Default.ActPosInd = Properties.Settings.Default.Mem5PosInd;

            }

            Invoke(new Action(() =>
            {

                Ind1.Location = new Point(Properties.Settings.Default.ActPosInd[0], Properties.Settings.Default.ActPosInd[1]);
                Ind2.Location = new Point(Properties.Settings.Default.ActPosInd[2], Properties.Settings.Default.ActPosInd[3]);
                Ind3.Location = new Point(Properties.Settings.Default.ActPosInd[4], Properties.Settings.Default.ActPosInd[5]);
                Ind4.Location = new Point(Properties.Settings.Default.ActPosInd[6], Properties.Settings.Default.ActPosInd[7]);
                Ind5.Location = new Point(Properties.Settings.Default.ActPosInd[8], Properties.Settings.Default.ActPosInd[9]);
                Ind6.Location = new Point(Properties.Settings.Default.ActPosInd[10], Properties.Settings.Default.ActPosInd[11]);
                Ind7.Location = new Point(Properties.Settings.Default.ActPosInd[12], Properties.Settings.Default.ActPosInd[13]);
                Ind8.Location = new Point(Properties.Settings.Default.ActPosInd[14], Properties.Settings.Default.ActPosInd[15]);
                Ind9.Location = new Point(Properties.Settings.Default.ActPosInd[16], Properties.Settings.Default.ActPosInd[17]);
                Ind10.Location = new Point(Properties.Settings.Default.ActPosInd[18], Properties.Settings.Default.ActPosInd[19]);
                Ind11.Location = new Point(Properties.Settings.Default.ActPosInd[20], Properties.Settings.Default.ActPosInd[21]);
                Ind12.Location = new Point(Properties.Settings.Default.ActPosInd[22], Properties.Settings.Default.ActPosInd[23]);
                Ind13.Location = new Point(Properties.Settings.Default.ActPosInd[24], Properties.Settings.Default.ActPosInd[25]);
                Ind14.Location = new Point(Properties.Settings.Default.ActPosInd[26], Properties.Settings.Default.ActPosInd[27]);
                Ind15.Location = new Point(Properties.Settings.Default.ActPosInd[28], Properties.Settings.Default.ActPosInd[29]);
                Ind16.Location = new Point(Properties.Settings.Default.ActPosInd[30], Properties.Settings.Default.ActPosInd[31]);
                Ind17.Location = new Point(Properties.Settings.Default.ActPosInd[32], Properties.Settings.Default.ActPosInd[33]);
                Ind18.Location = new Point(Properties.Settings.Default.ActPosInd[34], Properties.Settings.Default.ActPosInd[35]);
                Ind19.Location = new Point(Properties.Settings.Default.ActPosInd[36], Properties.Settings.Default.ActPosInd[37]);
                Ind20.Location = new Point(Properties.Settings.Default.ActPosInd[38], Properties.Settings.Default.ActPosInd[39]);

            }));
        }

        //С:\ Users \ [user name] \ AppData \ Local \ [ (Project Name) or(AssemblyCompany)] \ [name project_cashBuild] \ [AssemblyVersion] \ user.config


    }
}
