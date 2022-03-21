
namespace VisV1
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
            this.butSave = new System.Windows.Forms.Button();
            this.Ind1 = new System.Windows.Forms.Button();
            this.Ind2 = new System.Windows.Forms.Button();
            this.Ind3 = new System.Windows.Forms.Button();
            this.Ind4 = new System.Windows.Forms.Button();
            this.Ind5 = new System.Windows.Forms.Button();
            this.Ind6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(713, 2);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // Ind1
            // 
            this.Ind1.Location = new System.Drawing.Point(318, 96);
            this.Ind1.Name = "Ind1";
            this.Ind1.Size = new System.Drawing.Size(30, 30);
            this.Ind1.TabIndex = 1;
            this.Ind1.Text = "1";
            this.Ind1.UseVisualStyleBackColor = true;
            // 
            // Ind2
            // 
            this.Ind2.Location = new System.Drawing.Point(353, 96);
            this.Ind2.Name = "Ind2";
            this.Ind2.Size = new System.Drawing.Size(29, 30);
            this.Ind2.TabIndex = 2;
            this.Ind2.Text = "2";
            this.Ind2.UseVisualStyleBackColor = true;
            // 
            // Ind3
            // 
            this.Ind3.Location = new System.Drawing.Point(388, 96);
            this.Ind3.Name = "Ind3";
            this.Ind3.Size = new System.Drawing.Size(30, 30);
            this.Ind3.TabIndex = 3;
            this.Ind3.Text = "3";
            this.Ind3.UseVisualStyleBackColor = true;
            // 
            // Ind4
            // 
            this.Ind4.Location = new System.Drawing.Point(424, 96);
            this.Ind4.Name = "Ind4";
            this.Ind4.Size = new System.Drawing.Size(30, 30);
            this.Ind4.TabIndex = 4;
            this.Ind4.Text = "4";
            this.Ind4.UseVisualStyleBackColor = true;
            // 
            // Ind5
            // 
            this.Ind5.Location = new System.Drawing.Point(460, 96);
            this.Ind5.Name = "Ind5";
            this.Ind5.Size = new System.Drawing.Size(30, 30);
            this.Ind5.TabIndex = 5;
            this.Ind5.Text = "5";
            this.Ind5.UseVisualStyleBackColor = true;
            // 
            // Ind6
            // 
            this.Ind6.Location = new System.Drawing.Point(496, 96);
            this.Ind6.Name = "Ind6";
            this.Ind6.Size = new System.Drawing.Size(30, 30);
            this.Ind6.TabIndex = 6;
            this.Ind6.Text = "6";
            this.Ind6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ind6);
            this.Controls.Add(this.Ind5);
            this.Controls.Add(this.Ind4);
            this.Controls.Add(this.Ind3);
            this.Controls.Add(this.Ind2);
            this.Controls.Add(this.Ind1);
            this.Controls.Add(this.butSave);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button Ind1;
        private System.Windows.Forms.Button Ind2;
        private System.Windows.Forms.Button Ind3;
        private System.Windows.Forms.Button Ind4;
        private System.Windows.Forms.Button Ind5;
        private System.Windows.Forms.Button Ind6;
    }
}

