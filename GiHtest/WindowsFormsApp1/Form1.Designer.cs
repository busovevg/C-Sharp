namespace WindowsFormsApp1
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
            this.ConnBT = new System.Windows.Forms.Button();
            this.CpyTypeCB = new System.Windows.Forms.ComboBox();
            this.IPaddressTB = new System.Windows.Forms.TextBox();
            this.DisconnBT = new System.Windows.Forms.Button();
            this.RackTB = new System.Windows.Forms.TextBox();
            this.SlotTB = new System.Windows.Forms.TextBox();
            this.StatConnTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnBT
            // 
            this.ConnBT.Location = new System.Drawing.Point(373, 58);
            this.ConnBT.Name = "ConnBT";
            this.ConnBT.Size = new System.Drawing.Size(75, 23);
            this.ConnBT.TabIndex = 0;
            this.ConnBT.Text = "Connect";
            this.ConnBT.UseVisualStyleBackColor = true;
            this.ConnBT.Click += new System.EventHandler(this.ConnBT_Click_1);
            // 
            // CpyTypeCB
            // 
            this.CpyTypeCB.FormattingEnabled = true;
            this.CpyTypeCB.Location = new System.Drawing.Point(133, 34);
            this.CpyTypeCB.Name = "CpyTypeCB";
            this.CpyTypeCB.Size = new System.Drawing.Size(121, 21);
            this.CpyTypeCB.TabIndex = 1;
            // 
            // IPaddressTB
            // 
            this.IPaddressTB.Location = new System.Drawing.Point(133, 75);
            this.IPaddressTB.Name = "IPaddressTB";
            this.IPaddressTB.Size = new System.Drawing.Size(100, 20);
            this.IPaddressTB.TabIndex = 2;
            this.IPaddressTB.Text = "192.168.0.228";
            // 
            // DisconnBT
            // 
            this.DisconnBT.Location = new System.Drawing.Point(488, 58);
            this.DisconnBT.Name = "DisconnBT";
            this.DisconnBT.Size = new System.Drawing.Size(75, 23);
            this.DisconnBT.TabIndex = 3;
            this.DisconnBT.Text = "Disconnect";
            this.DisconnBT.UseVisualStyleBackColor = true;
            this.DisconnBT.Click += new System.EventHandler(this.DisconnBT_Click);
            // 
            // RackTB
            // 
            this.RackTB.Location = new System.Drawing.Point(133, 101);
            this.RackTB.Name = "RackTB";
            this.RackTB.Size = new System.Drawing.Size(100, 20);
            this.RackTB.TabIndex = 4;
            this.RackTB.Text = "0";
            // 
            // SlotTB
            // 
            this.SlotTB.Location = new System.Drawing.Point(133, 127);
            this.SlotTB.Name = "SlotTB";
            this.SlotTB.Size = new System.Drawing.Size(100, 20);
            this.SlotTB.TabIndex = 5;
            this.SlotTB.Text = "2";
            // 
            // StatConnTB
            // 
            this.StatConnTB.Location = new System.Drawing.Point(373, 111);
            this.StatConnTB.Name = "StatConnTB";
            this.StatConnTB.Size = new System.Drawing.Size(100, 20);
            this.StatConnTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 194);
            this.Controls.Add(this.StatConnTB);
            this.Controls.Add(this.SlotTB);
            this.Controls.Add(this.RackTB);
            this.Controls.Add(this.DisconnBT);
            this.Controls.Add(this.IPaddressTB);
            this.Controls.Add(this.CpyTypeCB);
            this.Controls.Add(this.ConnBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnBT;
        private System.Windows.Forms.ComboBox CpyTypeCB;
        private System.Windows.Forms.TextBox IPaddressTB;
        private System.Windows.Forms.Button DisconnBT;
        private System.Windows.Forms.TextBox RackTB;
        private System.Windows.Forms.TextBox SlotTB;
        private System.Windows.Forms.TextBox StatConnTB;
    }
}

