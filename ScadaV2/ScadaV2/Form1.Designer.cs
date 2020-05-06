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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ser_StopBT = new System.Windows.Forms.Button();
            this.ser_portTB = new System.Windows.Forms.TextBox();
            this.ser_DataLogTB = new System.Windows.Forms.TextBox();
            this.ser_IPaddressTB = new System.Windows.Forms.TextBox();
            this.ser_StartBT = new System.Windows.Forms.Button();
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 115);
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
            this.ser_DataLogTB.Location = new System.Drawing.Point(17, 83);
            this.ser_DataLogTB.Multiline = true;
            this.ser_DataLogTB.Name = "ser_DataLogTB";
            this.ser_DataLogTB.Size = new System.Drawing.Size(338, 252);
            this.ser_DataLogTB.TabIndex = 25;
            // 
            // ser_IPaddressTB
            // 
            this.ser_IPaddressTB.Location = new System.Drawing.Point(17, 43);
            this.ser_IPaddressTB.Name = "ser_IPaddressTB";
            this.ser_IPaddressTB.Size = new System.Drawing.Size(100, 20);
            this.ser_IPaddressTB.TabIndex = 23;
            this.ser_IPaddressTB.Text = "192.168.0.228";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
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
    }
}

