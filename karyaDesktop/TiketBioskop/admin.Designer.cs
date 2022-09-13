namespace TiketBioskop
{
    partial class admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Film = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_akun = new System.Windows.Forms.Button();
            this.BTN_Studio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.BukaFoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Film);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.BTN_akun);
            this.panel1.Controls.Add(this.BTN_Studio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 675);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(3, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 25);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Film
            // 
            this.Film.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Film.Location = new System.Drawing.Point(44, 353);
            this.Film.Name = "Film";
            this.Film.Size = new System.Drawing.Size(173, 43);
            this.Film.TabIndex = 6;
            this.Film.Text = "Film";
            this.Film.UseVisualStyleBackColor = true;
            this.Film.Click += new System.EventHandler(this.Film_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(44, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Admin";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BTN_akun
            // 
            this.BTN_akun.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_akun.Location = new System.Drawing.Point(44, 282);
            this.BTN_akun.Name = "BTN_akun";
            this.BTN_akun.Size = new System.Drawing.Size(173, 43);
            this.BTN_akun.TabIndex = 4;
            this.BTN_akun.Text = "Akun";
            this.BTN_akun.UseVisualStyleBackColor = true;
            this.BTN_akun.Click += new System.EventHandler(this.BTN_akun_Click);
            // 
            // BTN_Studio
            // 
            this.BTN_Studio.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Studio.Location = new System.Drawing.Point(44, 210);
            this.BTN_Studio.Name = "BTN_Studio";
            this.BTN_Studio.Size = new System.Drawing.Size(173, 43);
            this.BTN_Studio.TabIndex = 3;
            this.BTN_Studio.Text = "Studio";
            this.BTN_Studio.UseVisualStyleBackColor = true;
            this.BTN_Studio.Click += new System.EventHandler(this.BTN_Studio_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(305, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 675);
            this.panel2.TabIndex = 1;
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Location = new System.Drawing.Point(279, 12);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(948, 675);
            this.PanelAdmin.TabIndex = 1;
            // 
            // BukaFoto
            // 
            this.BukaFoto.FileName = "openFileDialog1";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 714);
            this.Controls.Add(this.PanelAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTN_akun;
        private System.Windows.Forms.Button BTN_Studio;
        private System.Windows.Forms.Button Film;
        private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.OpenFileDialog BukaFoto;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}