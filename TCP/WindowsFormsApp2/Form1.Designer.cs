namespace TCP
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
            this.label2 = new System.Windows.Forms.Label();
            this.ser_DataLogTB = new System.Windows.Forms.TextBox();
            this.ser_portTB = new System.Windows.Forms.TextBox();
            this.ser_IPaddressTB = new System.Windows.Forms.TextBox();
            this.ser_StartBT = new System.Windows.Forms.Button();
            this.ser_StopBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Server";
            // 
            // ser_DataLogTB
            // 
            this.ser_DataLogTB.Location = new System.Drawing.Point(9, 79);
            this.ser_DataLogTB.Multiline = true;
            this.ser_DataLogTB.Name = "ser_DataLogTB";
            this.ser_DataLogTB.Size = new System.Drawing.Size(338, 355);
            this.ser_DataLogTB.TabIndex = 19;
            // 
            // ser_portTB
            // 
            this.ser_portTB.Location = new System.Drawing.Point(115, 38);
            this.ser_portTB.Name = "ser_portTB";
            this.ser_portTB.Size = new System.Drawing.Size(65, 20);
            this.ser_portTB.TabIndex = 17;
            this.ser_portTB.Text = "8989";
            // 
            // ser_IPaddressTB
            // 
            this.ser_IPaddressTB.Location = new System.Drawing.Point(9, 38);
            this.ser_IPaddressTB.Name = "ser_IPaddressTB";
            this.ser_IPaddressTB.Size = new System.Drawing.Size(100, 20);
            this.ser_IPaddressTB.TabIndex = 16;
            this.ser_IPaddressTB.Text = "192.168.0.228";
            // 
            // ser_StartBT
            // 
            this.ser_StartBT.Location = new System.Drawing.Point(186, 36);
            this.ser_StartBT.Name = "ser_StartBT";
            this.ser_StartBT.Size = new System.Drawing.Size(75, 23);
            this.ser_StartBT.TabIndex = 15;
            this.ser_StartBT.Text = "Start";
            this.ser_StartBT.UseVisualStyleBackColor = true;
            this.ser_StartBT.Click += new System.EventHandler(this.ser_StartBT_Click);
            // 
            // ser_StopBT
            // 
            this.ser_StopBT.Location = new System.Drawing.Point(272, 36);
            this.ser_StopBT.Name = "ser_StopBT";
            this.ser_StopBT.Size = new System.Drawing.Size(75, 23);
            this.ser_StopBT.TabIndex = 20;
            this.ser_StopBT.Text = "Stop";
            this.ser_StopBT.UseVisualStyleBackColor = true;
            this.ser_StopBT.Click += new System.EventHandler(this.ser_StopBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.ser_StopBT);
            this.Controls.Add(this.ser_DataLogTB);
            this.Controls.Add(this.ser_portTB);
            this.Controls.Add(this.ser_IPaddressTB);
            this.Controls.Add(this.ser_StartBT);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ser_DataLogTB;
        private System.Windows.Forms.TextBox ser_portTB;
        private System.Windows.Forms.TextBox ser_IPaddressTB;
        private System.Windows.Forms.Button ser_StartBT;
        private System.Windows.Forms.Button ser_StopBT;
    }
}

