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
            this.TXTName = new System.Windows.Forms.TextBox();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.CCBPassword = new System.Windows.Forms.CheckBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTName
            // 
            this.TXTName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTName.Location = new System.Drawing.Point(341, 118);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(100, 20);
            this.TXTName.TabIndex = 2;
            // 
            // TXTPassword
            // 
            this.TXTPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTPassword.Location = new System.Drawing.Point(341, 155);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.Size = new System.Drawing.Size(100, 20);
            this.TXTPassword.TabIndex = 3;
            this.TXTPassword.TextChanged += new System.EventHandler(this.TXTPassword_TextChanged);
            // 
            // CCBPassword
            // 
            this.CCBPassword.AutoSize = true;
            this.CCBPassword.BackColor = System.Drawing.Color.Transparent;
            this.CCBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCBPassword.Location = new System.Drawing.Point(327, 192);
            this.CCBPassword.Name = "CCBPassword";
            this.CCBPassword.Size = new System.Drawing.Size(102, 17);
            this.CCBPassword.TabIndex = 4;
            this.CCBPassword.Text = "Show Password";
            this.CCBPassword.UseVisualStyleBackColor = false;
            this.CCBPassword.CheckedChanged += new System.EventHandler(this.CCBPassword_CheckedChanged);
            // 
            // BTNLogin
            // 
            this.BTNLogin.Location = new System.Drawing.Point(326, 221);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(100, 28);
            this.BTNLogin.TabIndex = 5;
            this.BTNLogin.Text = "LOGIN";
            this.BTNLogin.UseVisualStyleBackColor = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TiketBioskop.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(307, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TiketBioskop.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(307, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TiketBioskop.Properties.Resources.admin_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.CCBPassword);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.TXTName);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.TextBox TXTPassword;
        private System.Windows.Forms.CheckBox CCBPassword;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

