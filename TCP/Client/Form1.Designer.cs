namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.cl_DataLogTB = new System.Windows.Forms.TextBox();
            this.cl_DataTB = new System.Windows.Forms.TextBox();
            this.cl_portTB = new System.Windows.Forms.TextBox();
            this.cl_IPaddressTB = new System.Windows.Forms.TextBox();
            this.cl_conectBT = new System.Windows.Forms.Button();
            this.cl_sendBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Client";
            // 
            // cl_DataLogTB
            // 
            this.cl_DataLogTB.Location = new System.Drawing.Point(51, 154);
            this.cl_DataLogTB.Multiline = true;
            this.cl_DataLogTB.Name = "cl_DataLogTB";
            this.cl_DataLogTB.Size = new System.Drawing.Size(338, 286);
            this.cl_DataLogTB.TabIndex = 18;
            // 
            // cl_DataTB
            // 
            this.cl_DataTB.Location = new System.Drawing.Point(51, 70);
            this.cl_DataTB.Multiline = true;
            this.cl_DataTB.Name = "cl_DataTB";
            this.cl_DataTB.Size = new System.Drawing.Size(338, 49);
            this.cl_DataTB.TabIndex = 17;
            // 
            // cl_portTB
            // 
            this.cl_portTB.Location = new System.Drawing.Point(157, 44);
            this.cl_portTB.Name = "cl_portTB";
            this.cl_portTB.Size = new System.Drawing.Size(65, 20);
            this.cl_portTB.TabIndex = 16;
            this.cl_portTB.Text = "8989";
            // 
            // cl_IPaddressTB
            // 
            this.cl_IPaddressTB.Location = new System.Drawing.Point(51, 44);
            this.cl_IPaddressTB.Name = "cl_IPaddressTB";
            this.cl_IPaddressTB.Size = new System.Drawing.Size(100, 20);
            this.cl_IPaddressTB.TabIndex = 15;
            this.cl_IPaddressTB.Text = "192.168.0.228";
            // 
            // cl_conectBT
            // 
            this.cl_conectBT.Location = new System.Drawing.Point(228, 42);
            this.cl_conectBT.Name = "cl_conectBT";
            this.cl_conectBT.Size = new System.Drawing.Size(75, 23);
            this.cl_conectBT.TabIndex = 14;
            this.cl_conectBT.Text = "Connect";
            this.cl_conectBT.UseVisualStyleBackColor = true;
            this.cl_conectBT.Click += new System.EventHandler(this.cl_conectBT_Click_1);
            // 
            // cl_sendBT
            // 
            this.cl_sendBT.Location = new System.Drawing.Point(228, 125);
            this.cl_sendBT.Name = "cl_sendBT";
            this.cl_sendBT.Size = new System.Drawing.Size(75, 23);
            this.cl_sendBT.TabIndex = 13;
            this.cl_sendBT.Text = "Send";
            this.cl_sendBT.UseVisualStyleBackColor = true;
            this.cl_sendBT.Click += new System.EventHandler(this.cl_sendBT_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cl_DataLogTB);
            this.Controls.Add(this.cl_DataTB);
            this.Controls.Add(this.cl_portTB);
            this.Controls.Add(this.cl_IPaddressTB);
            this.Controls.Add(this.cl_conectBT);
            this.Controls.Add(this.cl_sendBT);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cl_DataLogTB;
        private System.Windows.Forms.TextBox cl_DataTB;
        private System.Windows.Forms.TextBox cl_portTB;
        private System.Windows.Forms.TextBox cl_IPaddressTB;
        private System.Windows.Forms.Button cl_conectBT;
        private System.Windows.Forms.Button cl_sendBT;
    }
}

