namespace TiketBioskop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.CCBPassword = new System.Windows.Forms.CheckBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(233, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(233, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // TXTName
            // 
            this.TXTName.Location = new System.Drawing.Point(213, 79);
            this.TXTName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(132, 22);
            this.TXTName.TabIndex = 2;
            // 
            // TXTPassword
            // 
            this.TXTPassword.Location = new System.Drawing.Point(213, 140);
            this.TXTPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.Size = new System.Drawing.Size(132, 22);
            this.TXTPassword.TabIndex = 3;
            this.TXTPassword.TextChanged += new System.EventHandler(this.TXTPassword_TextChanged);
            // 
            // CCBPassword
            // 
            this.CCBPassword.AutoSize = true;
            this.CCBPassword.Location = new System.Drawing.Point(212, 172);
            this.CCBPassword.Margin = new System.Windows.Forms.Padding(4);
            this.CCBPassword.Name = "CCBPassword";
            this.CCBPassword.Size = new System.Drawing.Size(125, 20);
            this.CCBPassword.TabIndex = 4;
            this.CCBPassword.Text = "Show Password";
            this.CCBPassword.UseVisualStyleBackColor = true;
            this.CCBPassword.CheckedChanged += new System.EventHandler(this.CCBPassword_CheckedChanged);
            // 
            // BTNLogin
            // 
            this.BTNLogin.Location = new System.Drawing.Point(227, 208);
            this.BTNLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(100, 28);
            this.BTNLogin.TabIndex = 5;
            this.BTNLogin.Text = "LOGIN";
            this.BTNLogin.UseVisualStyleBackColor = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 554);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.CCBPassword);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.TXTName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.TextBox TXTPassword;
        private System.Windows.Forms.CheckBox CCBPassword;
        private System.Windows.Forms.Button BTNLogin;
    }
}

