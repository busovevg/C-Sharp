using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private Plc plc = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CpyTypeCB.DataSource = Enum.GetNames(typeof(CpuType));

        }

        private void ConnBT_Click_1(object sender, EventArgs e)
        {

            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), CpyTypeCB.SelectedValue.ToString());

            plc = new Plc(cpu, IPaddressTB.Text, Convert.ToInt16(RackTB.Text), Convert.ToInt16(SlotTB.Text));
            plc.Open();

            if (plc.IsConnected)
            {

                StatConnTB.Text = "Connected";
            }
        }


        private void DisconnBT_Click(object sender, EventArgs e)
        {

            plc.Close();
            StatConnTB.Text = "Disconnected";


        }

       
    }
}
    

