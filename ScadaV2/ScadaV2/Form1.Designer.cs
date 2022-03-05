namespace ScadaV2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Bt = new System.Windows.Forms.Button();
            this.Settings_Bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataText3_TB = new System.Windows.Forms.TextBox();
            this.dataText2_TB = new System.Windows.Forms.TextBox();
            this.dataText1_TB = new System.Windows.Forms.TextBox();
            this.dataint4_TB = new System.Windows.Forms.TextBox();
            this.dataint3_TB = new System.Windows.Forms.TextBox();
            this.dataint2_TB = new System.Windows.Forms.TextBox();
            this.dataint1_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataReceivLenght = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ser_StopBT = new System.Windows.Forms.Button();
            this.ser_portTB = new System.Windows.Forms.TextBox();
            this.ser_DataLogTB = new System.Windows.Forms.TextBox();
            this.ser_IPaddressTB = new System.Windows.Forms.TextBox();
            this.ser_StartBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Chart_Bt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Bt
            // 
            this.Main_Bt.Location = new System.Drawing.Point(420, 3);
            this.Main_Bt.Name = "Main_Bt";
            this.Main_Bt.Size = new System.Drawing.Size(75, 23);
            this.Main_Bt.TabIndex = 0;
            this.Main_Bt.Text = "Main";
            this.Main_Bt.UseVisualStyleBackColor = true;
            this.Main_Bt.Click += new System.EventHandler(this.Main_Bt_Click);
            // 
            // Settings_Bt
            // 
            this.Settings_Bt.Location = new System.Drawing.Point(501, 3);
            this.Settings_Bt.Name = "Settings_Bt";
            this.Settings_Bt.Size = new System.Drawing.Size(75, 23);
            this.Settings_Bt.TabIndex = 1;
            this.Settings_Bt.Text = "Settings";
            this.Settings_Bt.UseVisualStyleBackColor = true;
            this.Settings_Bt.Click += new System.EventHandler(this.Settings_Bt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.circularProgressBar1);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 397);
            this.panel1.TabIndex = 0;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(173, 58);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(267, 257);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataText3_TB);
            this.panel2.Controls.Add(this.dataText2_TB);
            this.panel2.Controls.Add(this.dataText1_TB);
            this.panel2.Controls.Add(this.dataint4_TB);
            this.panel2.Controls.Add(this.dataint3_TB);
            this.panel2.Controls.Add(this.dataint2_TB);
            this.panel2.Controls.Add(this.dataint1_TB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DataReceivLenght);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.ser_StopBT);
            this.panel2.Controls.Add(this.ser_portTB);
            this.panel2.Controls.Add(this.ser_DataLogTB);
            this.panel2.Controls.Add(this.ser_IPaddressTB);
            this.panel2.Controls.Add(this.ser_StartBT);
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 397);
            this.panel2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(401, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Data Receiv";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "dataText3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "dataText2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "dataText1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "dataint4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "dataint3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "dataint2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "dataint1";
            // 
            // dataText3_TB
            // 
            this.dataText3_TB.Location = new System.Drawing.Point(431, 280);
            this.dataText3_TB.Name = "dataText3_TB";
            this.dataText3_TB.Size = new System.Drawing.Size(100, 20);
            this.dataText3_TB.TabIndex = 39;
            // 
            // dataText2_TB
            // 
            this.dataText2_TB.Location = new System.Drawing.Point(431, 253);
            this.dataText2_TB.Name = "dataText2_TB";
            this.dataText2_TB.Size = new System.Drawing.Size(100, 20);
            this.dataText2_TB.TabIndex = 38;
            // 
            // dataText1_TB
            // 
            this.dataText1_TB.Location = new System.Drawing.Point(431, 226);
            this.dataText1_TB.Name = "dataText1_TB";
            this.dataText1_TB.Size = new System.Drawing.Size(100, 20);
            this.dataText1_TB.TabIndex = 37;
            // 
            // dataint4_TB
            // 
            this.dataint4_TB.Location = new System.Drawing.Point(431, 199);
            this.dataint4_TB.Name = "dataint4_TB";
            this.dataint4_TB.Size = new System.Drawing.Size(100, 20);
            this.dataint4_TB.TabIndex = 36;
            // 
            // dataint3_TB
            // 
            this.dataint3_TB.Location = new System.Drawing.Point(431, 172);
            this.dataint3_TB.Name = "dataint3_TB";
            this.dataint3_TB.Size = new System.Drawing.Size(100, 20);
            this.dataint3_TB.TabIndex = 35;
            // 
            // dataint2_TB
            // 
            this.dataint2_TB.Location = new System.Drawing.Point(431, 145);
            this.dataint2_TB.Name = "dataint2_TB";
            this.dataint2_TB.Size = new System.Drawing.Size(100, 20);
            this.dataint2_TB.TabIndex = 34;
            // 
            // dataint1_TB
            // 
            this.dataint1_TB.Location = new System.Drawing.Point(431, 118);
            this.dataint1_TB.Name = "dataint1_TB";
            this.dataint1_TB.Size = new System.Drawing.Size(100, 20);
            this.dataint1_TB.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "IP adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "DataReceiv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "DataReceivLenght";
            // 
            // DataReceivLenght
            // 
            this.DataReceivLenght.Location = new System.Drawing.Point(498, 42);
            this.DataReceivLenght.Name = "DataReceivLenght";
            this.DataReceivLenght.ReadOnly = true;
            this.DataReceivLenght.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataReceivLenght.Size = new System.Drawing.Size(43, 20);
            this.DataReceivLenght.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ser_StopBT
            // 
            this.ser_StopBT.Location = new System.Drawing.Point(280, 36);
            this.ser_StopBT.Name = "ser_StopBT";
            this.ser_StopBT.Size = new System.Drawing.Size(75, 26);
            this.ser_StopBT.TabIndex = 26;
            this.ser_StopBT.Text = "Stop";
            this.ser_StopBT.UseVisualStyleBackColor = true;
            this.ser_StopBT.Click += new System.EventHandler(this.ser_StopBT_Click);
            // 
            // ser_portTB
            // 
            this.ser_portTB.Location = new System.Drawing.Point(123, 42);
            this.ser_portTB.Name = "ser_portTB";
            this.ser_portTB.Size = new System.Drawing.Size(65, 20);
            this.ser_portTB.TabIndex = 24;
            this.ser_portTB.Text = "8989";
            // 
            // ser_DataLogTB
            // 
            this.ser_DataLogTB.Location = new System.Drawing.Point(18, 83);
            this.ser_DataLogTB.Multiline = true;
            this.ser_DataLogTB.Name = "ser_DataLogTB";
            this.ser_DataLogTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ser_DataLogTB.Size = new System.Drawing.Size(338, 252);
            this.ser_DataLogTB.TabIndex = 25;
            // 
            // ser_IPaddressTB
            // 
            this.ser_IPaddressTB.Location = new System.Drawing.Point(17, 43);
            this.ser_IPaddressTB.Name = "ser_IPaddressTB";
            this.ser_IPaddressTB.Size = new System.Drawing.Size(100, 20);
            this.ser_IPaddressTB.TabIndex = 23;
            this.ser_IPaddressTB.Text = "192.168.31.226";
            // 
            // ser_StartBT
            // 
            this.ser_StartBT.Location = new System.Drawing.Point(195, 37);
            this.ser_StartBT.Name = "ser_StartBT";
            this.ser_StartBT.Size = new System.Drawing.Size(75, 26);
            this.ser_StartBT.TabIndex = 22;
            this.ser_StartBT.Text = "Start";
            this.ser_StartBT.UseVisualStyleBackColor = true;
            this.ser_StartBT.Click += new System.EventHandler(this.ser_StartBT_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 397);
            this.panel3.TabIndex = 2;
            // 
            // Chart_Bt
            // 
            this.Chart_Bt.Location = new System.Drawing.Point(582, 3);
            this.Chart_Bt.Name = "Chart_Bt";
            this.Chart_Bt.Size = new System.Drawing.Size(75, 23);
            this.Chart_Bt.TabIndex = 2;
            this.Chart_Bt.Text = "Chart";
            this.Chart_Bt.UseVisualStyleBackColor = true;
            this.Chart_Bt.Click += new System.EventHandler(this.Chart_Bt_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.Chart_Bt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Settings_Bt);
            this.Controls.Add(this.Main_Bt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "EvgScada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Main_Bt;
        private System.Windows.Forms.Button Settings_Bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ser_StopBT;
        private System.Windows.Forms.TextBox ser_DataLogTB;
        private System.Windows.Forms.TextBox ser_portTB;
        private System.Windows.Forms.TextBox ser_IPaddressTB;
        private System.Windows.Forms.Button ser_StartBT;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DataReceivLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataText3_TB;
        private System.Windows.Forms.TextBox dataText2_TB;
        private System.Windows.Forms.TextBox dataText1_TB;
        private System.Windows.Forms.TextBox dataint4_TB;
        private System.Windows.Forms.TextBox dataint3_TB;
        private System.Windows.Forms.TextBox dataint2_TB;
        private System.Windows.Forms.TextBox dataint1_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Chart_Bt;
    }
}

