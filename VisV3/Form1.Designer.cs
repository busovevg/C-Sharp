
namespace VisV3
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
            this.components = new System.ComponentModel.Container();
            this.Req = new System.Windows.Forms.Label();
            this.TB_ReqInd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butDem = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataReceivLenght = new System.Windows.Forms.TextBox();
            this.TB_Ntask = new System.Windows.Forms.TextBox();
            this.ser_StopBT = new System.Windows.Forms.Button();
            this.ser_portTB = new System.Windows.Forms.TextBox();
            this.ser_DataLogTB = new System.Windows.Forms.TextBox();
            this.ser_IPaddressTB = new System.Windows.Forms.TextBox();
            this.ser_StartBT = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.BtSetengs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TaskIndex = new System.Windows.Forms.NumericUpDown();
            this.tb_QPS = new System.Windows.Forms.TextBox();
            this.pb_CycleTime = new System.Windows.Forms.ProgressBar();
            this.tb_CycleTime = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // Req
            // 
            this.Req.AutoSize = true;
            this.Req.Location = new System.Drawing.Point(546, 86);
            this.Req.Name = "Req";
            this.Req.Size = new System.Drawing.Size(27, 13);
            this.Req.TabIndex = 75;
            this.Req.Text = "Req";
            // 
            // TB_ReqInd
            // 
            this.TB_ReqInd.Location = new System.Drawing.Point(576, 83);
            this.TB_ReqInd.Name = "TB_ReqInd";
            this.TB_ReqInd.Size = new System.Drawing.Size(38, 20);
            this.TB_ReqInd.TabIndex = 74;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 64;
            // 
            // butDem
            // 
            this.butDem.Location = new System.Drawing.Point(87, 1);
            this.butDem.Name = "butDem";
            this.butDem.Size = new System.Drawing.Size(75, 23);
            this.butDem.TabIndex = 63;
            this.butDem.Text = "Demo";
            this.butDem.UseVisualStyleBackColor = true;
            this.butDem.Click += new System.EventHandler(this.butDem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(403, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Data Receiv";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Req);
            this.panel2.Controls.Add(this.TB_ReqInd);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.butDem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DataReceivLenght);
            this.panel2.Controls.Add(this.TB_Ntask);
            this.panel2.Controls.Add(this.ser_StopBT);
            this.panel2.Controls.Add(this.ser_portTB);
            this.panel2.Controls.Add(this.ser_DataLogTB);
            this.panel2.Controls.Add(this.ser_IPaddressTB);
            this.panel2.Controls.Add(this.ser_StartBT);
            this.panel2.Location = new System.Drawing.Point(238, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 462);
            this.panel2.TabIndex = 62;
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
            this.label2.Location = new System.Drawing.Point(389, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "NumTask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "DataReceivLenght";
            // 
            // DataReceivLenght
            // 
            this.DataReceivLenght.Location = new System.Drawing.Point(507, 47);
            this.DataReceivLenght.Name = "DataReceivLenght";
            this.DataReceivLenght.ReadOnly = true;
            this.DataReceivLenght.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataReceivLenght.Size = new System.Drawing.Size(43, 20);
            this.DataReceivLenght.TabIndex = 28;
            // 
            // TB_Ntask
            // 
            this.TB_Ntask.Location = new System.Drawing.Point(459, 83);
            this.TB_Ntask.Name = "TB_Ntask";
            this.TB_Ntask.Size = new System.Drawing.Size(38, 20);
            this.TB_Ntask.TabIndex = 27;
            this.TB_Ntask.Text = "0";
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
            this.ser_DataLogTB.Size = new System.Drawing.Size(338, 353);
            this.ser_DataLogTB.TabIndex = 25;
            // 
            // ser_IPaddressTB
            // 
            this.ser_IPaddressTB.Location = new System.Drawing.Point(17, 43);
            this.ser_IPaddressTB.Name = "ser_IPaddressTB";
            this.ser_IPaddressTB.Size = new System.Drawing.Size(100, 20);
            this.ser_IPaddressTB.TabIndex = 23;
            this.ser_IPaddressTB.Text = "192.168.31.227";
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
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(723, 1);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 39;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // BtSetengs
            // 
            this.BtSetengs.Location = new System.Drawing.Point(840, 1);
            this.BtSetengs.Name = "BtSetengs";
            this.BtSetengs.Size = new System.Drawing.Size(75, 23);
            this.BtSetengs.TabIndex = 61;
            this.BtSetengs.Text = "Setings";
            this.BtSetengs.UseVisualStyleBackColor = true;
            this.BtSetengs.Click += new System.EventHandler(this.BtSetengs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // TaskIndex
            // 
            this.TaskIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskIndex.Location = new System.Drawing.Point(86, 0);
            this.TaskIndex.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.TaskIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TaskIndex.Name = "TaskIndex";
            this.TaskIndex.Size = new System.Drawing.Size(50, 26);
            this.TaskIndex.TabIndex = 70;
            this.TaskIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TaskIndex.ValueChanged += new System.EventHandler(this.TaskIndex_ValueChanged);
            // 
            // tb_QPS
            // 
            this.tb_QPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_QPS.Location = new System.Drawing.Point(914, 31);
            this.tb_QPS.Multiline = true;
            this.tb_QPS.Name = "tb_QPS";
            this.tb_QPS.Size = new System.Drawing.Size(450, 700);
            this.tb_QPS.TabIndex = 71;
            this.tb_QPS.TextChanged += new System.EventHandler(this.tb_QPS_TextChanged);
            // 
            // pb_CycleTime
            // 
            this.pb_CycleTime.Location = new System.Drawing.Point(167, 2);
            this.pb_CycleTime.Name = "pb_CycleTime";
            this.pb_CycleTime.Size = new System.Drawing.Size(205, 23);
            this.pb_CycleTime.Step = 1;
            this.pb_CycleTime.TabIndex = 72;
            // 
            // tb_CycleTime
            // 
            this.tb_CycleTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_CycleTime.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CycleTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_CycleTime.Location = new System.Drawing.Point(379, 5);
            this.tb_CycleTime.Name = "tb_CycleTime";
            this.tb_CycleTime.ReadOnly = true;
            this.tb_CycleTime.Size = new System.Drawing.Size(62, 19);
            this.tb_CycleTime.TabIndex = 73;
            this.tb_CycleTime.Text = "00:00";
            this.tb_CycleTime.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tb_CycleTime);
            this.Controls.Add(this.pb_CycleTime);
            this.Controls.Add(this.tb_QPS);
            this.Controls.Add(this.TaskIndex);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.BtSetengs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Req;
        private System.Windows.Forms.TextBox TB_ReqInd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butDem;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataReceivLenght;
        private System.Windows.Forms.TextBox TB_Ntask;
        private System.Windows.Forms.Button ser_StopBT;
        private System.Windows.Forms.TextBox ser_portTB;
        private System.Windows.Forms.TextBox ser_DataLogTB;
        private System.Windows.Forms.TextBox ser_IPaddressTB;
        private System.Windows.Forms.Button ser_StartBT;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button BtSetengs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown TaskIndex;
        private System.Windows.Forms.TextBox tb_QPS;
        private System.Windows.Forms.ProgressBar pb_CycleTime;
        private System.Windows.Forms.TextBox tb_CycleTime;
    }
}

