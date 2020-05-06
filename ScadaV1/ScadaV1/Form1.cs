using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScadaV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
                }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength>0)
                {
                if (100 >= Convert.ToInt32(textBox1.Text))
                    { circularProgressBar1.Value = Convert.ToInt16(textBox1.Text);


                }
            }

        }
    }
}
