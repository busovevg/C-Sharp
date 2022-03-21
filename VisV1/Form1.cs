using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisV1

{
   
    public partial class Form1 : Form
    {
        int ButIndex;


        public Form1()
        {
            InitializeComponent();
            MoveCtrl.EnableMove(Ind1);
            MoveCtrl.EnableMove(Ind2);
            MoveCtrl.EnableMove(Ind3);
            MoveCtrl.EnableMove(Ind4);
            MoveCtrl.EnableMove(Ind5);
            MoveCtrl.EnableMove(Ind6);

        }

        private void butSave_Click(object sender, EventArgs e)
        {

            

            ButIndex++;


            Controls["Ind" + ButIndex].BackColor = Color.LawnGreen;

            MoveBut btn = new MoveBut();
            btn.Name = "btn" + ButIndex;
            btn.SetBounds(10, 10, 130, 23);
            btn.Text = "" + ButIndex;
            this.Controls.Add(btn);
            if (ButIndex == 5)
            {
                Controls["btn" + ButIndex].BackColor = Color.LawnGreen;
                Controls["btn" + 1].BackColor = Color.LawnGreen;
                Controls["btn" + 2].BackColor = Color.LawnGreen;
                Controls["btn" + 3].BackColor = Color.LawnGreen;
                Controls["btn" + 4].BackColor = Color.LawnGreen;
            }
        }

         public void Enae()
        {
            if (ButIndex == 5)
            {
                Controls["btn" + ButIndex].BackColor = Color.LawnGreen;
            }
}
        
        
        

      
    }
}
