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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTName
            // 
            this.TXTName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TXTName.Location = new System.Drawing.Point(314, 154);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(100, 20);
            this.TXTName.TabIndex = 2;
            // 
            // TXTPassword
            // 
            this.TXTPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TXTPassword.Location = new System.Drawing.Point(314, 187);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.Size = new System.Drawing.Size(100, 20);
            this.TXTPassword.TabIndex = 3;
            this.TXTPassword.TextChanged += new System.EventHandler(this.TXTPassword_TextChanged);
            // 
            // CCBPassword
            // 
            this.CCBPassword.AutoSize = true;
            this.CCBPassword.BackColor = System.Drawing.Color.Transparent;
            this.CCBPassword.Location = new System.Drawing.Point(297, 218);
            this.CCBPassword.Name = "CCBPassword";
            this.CCBPassword.Size = new System.Drawing.Size(102, 17);
            this.CCBPassword.TabIndex = 4;
            this.CCBPassword.Text = "Show Password";
            this.CCBPassword.UseVisualStyleBackColor = false;
            this.CCBPassword.CheckedChanged += new System.EventHandler(this.CCBPassword_CheckedChanged);
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackColor = System.Drawing.SystemColors.Window;
            this.BTNLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNLogin.Location = new System.Drawing.Point(306, 242);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(75, 23);
            this.BTNLogin.TabIndex = 5;
            this.BTNLogin.Text = "LOGIN";
            this.BTNLogin.UseVisualStyleBackColor = false;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TiketBioskop.Properties.Resources.loog_cinema1;
            this.pictureBox1.Location = new System.Drawing.Point(278, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TiketBioskop.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(279, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TiketBioskop.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(279, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TiketBioskop.Properties.Resources._Cokelat_Putih_Minimalis_Desktop_Wallpaper__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 344);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.CCBPassword);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.TXTName);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

