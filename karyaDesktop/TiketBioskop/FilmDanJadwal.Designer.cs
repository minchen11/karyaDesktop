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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CBX_NamaFilm
            // 
            this.CBX_NamaFilm.FormattingEnabled = true;
            this.CBX_NamaFilm.Location = new System.Drawing.Point(254, 331);
            this.CBX_NamaFilm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBX_NamaFilm.Name = "CBX_NamaFilm";
            this.CBX_NamaFilm.Size = new System.Drawing.Size(232, 28);
            this.CBX_NamaFilm.TabIndex = 0;
            this.CBX_NamaFilm.SelectedIndexChanged += new System.EventHandler(this.CBX_NamaFilm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "JUDUL FILM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "JAM TAYANG";
            // 
            // CBX_JamTayang
            // 
            this.CBX_JamTayang.FormattingEnabled = true;
            this.CBX_JamTayang.Location = new System.Drawing.Point(254, 417);
            this.CBX_JamTayang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBX_JamTayang.Name = "CBX_JamTayang";
            this.CBX_JamTayang.Size = new System.Drawing.Size(232, 28);
            this.CBX_JamTayang.TabIndex = 3;
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PB1.Location = new System.Drawing.Point(255, 40);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(232, 240);
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
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.ubahPasswordToolStripMenuItem,
            this.adminLevelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(736, 35);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.adminToolStripMenuItem.Text = "Admin ";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // ubahPasswordToolStripMenuItem
            // 
            this.ubahPasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ubahPasswordToolStripMenuItem.Name = "ubahPasswordToolStripMenuItem";
            this.ubahPasswordToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.ubahPasswordToolStripMenuItem.Text = "Ubah Password";
            this.ubahPasswordToolStripMenuItem.Click += new System.EventHandler(this.ubahPasswordToolStripMenuItem_Click);
            // 
            // adminLevelToolStripMenuItem
            // 
            this.adminLevelToolStripMenuItem.Enabled = false;
            this.adminLevelToolStripMenuItem.Name = "adminLevelToolStripMenuItem";
            this.adminLevelToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.adminLevelToolStripMenuItem.Text = "admin level ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TiketBioskop.Properties.Resources.Premium_Photo___Retro_film_reel_on_burn_background_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(2, 437);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TiketBioskop.Properties.Resources.Premium_Photo___Retro_film_reel_on_burn_background_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(228, 534);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TiketBioskop.Properties.Resources.Premium_Photo___Retro_film_reel_on_burn_background_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(514, 437);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 255);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // FilmDanJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TiketBioskop.Properties.Resources.walpaper;
            this.ClientSize = new System.Drawing.Size(736, 692);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBX_JamTayang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBX_NamaFilm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FilmDanJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX_NamaFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBX_JamTayang;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.OpenFileDialog BukaFoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ubahPasswordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.ToolStripMenuItem adminLevelToolStripMenuItem;
    }
}