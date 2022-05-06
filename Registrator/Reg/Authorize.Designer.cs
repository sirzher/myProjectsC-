namespace Reg
{
    partial class Authorize
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
            this.label2 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.entrBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(194, 130);
            this.passTB.Multiline = true;
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(137, 25);
            this.passTB.TabIndex = 2;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(194, 92);
            this.loginTB.Multiline = true;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(137, 25);
            this.loginTB.TabIndex = 3;
            // 
            // entrBtn
            // 
            this.entrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entrBtn.Location = new System.Drawing.Point(194, 178);
            this.entrBtn.Name = "entrBtn";
            this.entrBtn.Size = new System.Drawing.Size(137, 31);
            this.entrBtn.TabIndex = 4;
            this.entrBtn.Text = "Enter";
            this.entrBtn.UseVisualStyleBackColor = true;
            this.entrBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(194, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Registration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.entrBtn);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authorize";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Button entrBtn;
        private System.Windows.Forms.Button button2;
    }
}

