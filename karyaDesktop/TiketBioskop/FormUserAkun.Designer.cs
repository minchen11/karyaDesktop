namespace TiketBioskop
{
    partial class FormUserAkun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserAkun));
            this.LBL_username = new System.Windows.Forms.Label();
            this.LBL_PassLama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_username = new System.Windows.Forms.TextBox();
            this.TXT_PassLama = new System.Windows.Forms.TextBox();
            this.TXT_PassBaru = new System.Windows.Forms.TextBox();
            this.BTN_UbahPassword = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kembaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_username
            // 
            this.LBL_username.AutoSize = true;
            this.LBL_username.BackColor = System.Drawing.Color.Transparent;
            this.LBL_username.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_username.Location = new System.Drawing.Point(197, 115);
            this.LBL_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_username.Name = "LBL_username";
            this.LBL_username.Size = new System.Drawing.Size(78, 27);
            this.LBL_username.TabIndex = 0;
            this.LBL_username.Text = "Username";
            // 
            // LBL_PassLama
            // 
            this.LBL_PassLama.AutoSize = true;
            this.LBL_PassLama.BackColor = System.Drawing.Color.Transparent;
            this.LBL_PassLama.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PassLama.Location = new System.Drawing.Point(184, 179);
            this.LBL_PassLama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_PassLama.Name = "LBL_PassLama";
            this.LBL_PassLama.Size = new System.Drawing.Size(111, 27);
            this.LBL_PassLama.TabIndex = 1;
            this.LBL_PassLama.Text = "Password Lama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password Baru";
            // 
            // TXT_username
            // 
            this.TXT_username.Location = new System.Drawing.Point(174, 144);
            this.TXT_username.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_username.Name = "TXT_username";
            this.TXT_username.Size = new System.Drawing.Size(126, 20);
            this.TXT_username.TabIndex = 3;
            // 
            // TXT_PassLama
            // 
            this.TXT_PassLama.Location = new System.Drawing.Point(174, 207);
            this.TXT_PassLama.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_PassLama.Name = "TXT_PassLama";
            this.TXT_PassLama.Size = new System.Drawing.Size(126, 20);
            this.TXT_PassLama.TabIndex = 4;
            // 
            // TXT_PassBaru
            // 
            this.TXT_PassBaru.Location = new System.Drawing.Point(174, 270);
            this.TXT_PassBaru.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_PassBaru.Name = "TXT_PassBaru";
            this.TXT_PassBaru.Size = new System.Drawing.Size(126, 20);
            this.TXT_PassBaru.TabIndex = 5;
            // 
            // BTN_UbahPassword
            // 
            this.BTN_UbahPassword.BackColor = System.Drawing.Color.Transparent;
            this.BTN_UbahPassword.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UbahPassword.Location = new System.Drawing.Point(173, 310);
            this.BTN_UbahPassword.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UbahPassword.Name = "BTN_UbahPassword";
            this.BTN_UbahPassword.Size = new System.Drawing.Size(127, 38);
            this.BTN_UbahPassword.TabIndex = 6;
            this.BTN_UbahPassword.Text = "Ubah Password";
            this.BTN_UbahPassword.UseVisualStyleBackColor = false;
            this.BTN_UbahPassword.Click += new System.EventHandler(this.BTN_UbahPassword_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kembaliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kembaliToolStripMenuItem
            // 
            this.kembaliToolStripMenuItem.Name = "kembaliToolStripMenuItem";
            this.kembaliToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.kembaliToolStripMenuItem.Text = "Kembali";
            this.kembaliToolStripMenuItem.Click += new System.EventHandler(this.kembaliToolStripMenuItem_Click);
            // 
            // FormUserAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TiketBioskop.Properties.Resources.ganti_pass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 487);
            this.Controls.Add(this.BTN_UbahPassword);
            this.Controls.Add(this.TXT_PassBaru);
            this.Controls.Add(this.TXT_PassLama);
            this.Controls.Add(this.TXT_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_PassLama);
            this.Controls.Add(this.LBL_username);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUserAkun";
            this.Text = "Ganti Password";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_username;
        private System.Windows.Forms.Label LBL_PassLama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_username;
        private System.Windows.Forms.TextBox TXT_PassLama;
        private System.Windows.Forms.TextBox TXT_PassBaru;
        private System.Windows.Forms.Button BTN_UbahPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kembaliToolStripMenuItem;
    }
}