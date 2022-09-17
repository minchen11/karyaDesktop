namespace TiketBioskop
{
    partial class FilmDanJadwal
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
            this.CBX_NamaFilm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBX_JamTayang = new System.Windows.Forms.ComboBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.BukaFoto = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CBX_NamaFilm
            // 
            this.CBX_NamaFilm.FormattingEnabled = true;
            this.CBX_NamaFilm.Location = new System.Drawing.Point(170, 215);
            this.CBX_NamaFilm.Name = "CBX_NamaFilm";
            this.CBX_NamaFilm.Size = new System.Drawing.Size(156, 21);
            this.CBX_NamaFilm.TabIndex = 0;
            this.CBX_NamaFilm.SelectedIndexChanged += new System.EventHandler(this.CBX_NamaFilm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "JUDUL FILM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "JAM TAYANG";
            // 
            // CBX_JamTayang
            // 
            this.CBX_JamTayang.FormattingEnabled = true;
            this.CBX_JamTayang.Location = new System.Drawing.Point(170, 271);
            this.CBX_JamTayang.Name = "CBX_JamTayang";
            this.CBX_JamTayang.Size = new System.Drawing.Size(156, 21);
            this.CBX_JamTayang.TabIndex = 3;
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PB1.Location = new System.Drawing.Point(170, 30);
            this.PB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(154, 156);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 5;
            this.PB1.TabStop = false;
            // 
            // BukaFoto
            // 
            this.BukaFoto.FileName = "BukaFoto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.ubahPasswordToolStripMenuItem,
            this.adminLevelToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin ";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // ubahPasswordToolStripMenuItem
            // 
            this.ubahPasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ubahPasswordToolStripMenuItem.Name = "ubahPasswordToolStripMenuItem";
            this.ubahPasswordToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.ubahPasswordToolStripMenuItem.Text = "Ubah Password";
            this.ubahPasswordToolStripMenuItem.Click += new System.EventHandler(this.ubahPasswordToolStripMenuItem_Click);
            // 
            // adminLevelToolStripMenuItem
            // 
            this.adminLevelToolStripMenuItem.Enabled = false;
            this.adminLevelToolStripMenuItem.Name = "adminLevelToolStripMenuItem";
            this.adminLevelToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.adminLevelToolStripMenuItem.Text = "admin level ";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // BTN_Next
            // 
            this.BTN_Next.Location = new System.Drawing.Point(218, 310);
            this.BTN_Next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(56, 19);
            this.BTN_Next.TabIndex = 11;
            this.BTN_Next.Text = "Next";
            this.BTN_Next.UseVisualStyleBackColor = true;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TiketBioskop.Properties.Resources.Premium_Photo___Retro_film_reel_on_burn_background_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(2, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TiketBioskop.Properties.Resources.Premium_Photo___Retro_film_reel_on_burn_background_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(343, 284);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // FilmDanJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TiketBioskop.Properties.Resources.admin_design;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.BTN_Next);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBX_JamTayang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBX_NamaFilm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FilmDanJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.OpenFileDialog BukaFoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ubahPasswordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminLevelToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Next;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ComboBox CBX_NamaFilm;
        public System.Windows.Forms.ComboBox CBX_JamTayang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}