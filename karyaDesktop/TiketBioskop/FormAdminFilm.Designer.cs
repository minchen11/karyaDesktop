namespace TiketBioskop
{
    partial class FormAdminFilm
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
            this.Bukafoto = new System.Windows.Forms.OpenFileDialog();
            this.HLMN_Film = new System.Windows.Forms.Panel();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.Poster = new System.Windows.Forms.Label();
            this.BTN_HapusFilm = new System.Windows.Forms.Button();
            this.BTN_EditFilm = new System.Windows.Forms.Button();
            this.BTN_TambahFilm = new System.Windows.Forms.Button();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.DTP_JadwalTayang = new System.Windows.Forms.DateTimePicker();
            this.TXT_JamTayang = new System.Windows.Forms.TextBox();
            this.TXT_JudulFilm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_Studio = new System.Windows.Forms.ComboBox();
            this.HLMN_Film.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Bukafoto
            // 
            this.Bukafoto.FileName = "Bukafoto";
            // 
            // HLMN_Film
            // 
            this.HLMN_Film.BackColor = System.Drawing.Color.Tomato;
            this.HLMN_Film.BackgroundImage = global::TiketBioskop.Properties.Resources._Cokelat_Putih_Minimalis_Desktop_Wallpaper__4_;
            this.HLMN_Film.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HLMN_Film.Controls.Add(this.CBX_Studio);
            this.HLMN_Film.Controls.Add(this.label2);
            this.HLMN_Film.Controls.Add(this.BTN_Clear);
            this.HLMN_Film.Controls.Add(this.Poster);
            this.HLMN_Film.Controls.Add(this.BTN_HapusFilm);
            this.HLMN_Film.Controls.Add(this.BTN_EditFilm);
            this.HLMN_Film.Controls.Add(this.BTN_TambahFilm);
            this.HLMN_Film.Controls.Add(this.PB1);
            this.HLMN_Film.Controls.Add(this.DTP_JadwalTayang);
            this.HLMN_Film.Controls.Add(this.TXT_JamTayang);
            this.HLMN_Film.Controls.Add(this.TXT_JudulFilm);
            this.HLMN_Film.Controls.Add(this.label9);
            this.HLMN_Film.Controls.Add(this.label8);
            this.HLMN_Film.Controls.Add(this.label3);
            this.HLMN_Film.Controls.Add(this.dataGridView2);
            this.HLMN_Film.Location = new System.Drawing.Point(0, -1);
            this.HLMN_Film.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HLMN_Film.Name = "HLMN_Film";
            this.HLMN_Film.Size = new System.Drawing.Size(956, 681);
            this.HLMN_Film.TabIndex = 4;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear.Location = new System.Drawing.Point(293, 519);
            this.BTN_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(169, 47);
            this.BTN_Clear.TabIndex = 13;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // Poster
            // 
            this.Poster.AutoSize = true;
            this.Poster.BackColor = System.Drawing.Color.Transparent;
            this.Poster.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poster.Location = new System.Drawing.Point(640, 639);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(75, 26);
            this.Poster.TabIndex = 12;
            this.Poster.Text = "Lokasi Foto";
            // 
            // BTN_HapusFilm
            // 
            this.BTN_HapusFilm.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HapusFilm.Location = new System.Drawing.Point(95, 519);
            this.BTN_HapusFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_HapusFilm.Name = "BTN_HapusFilm";
            this.BTN_HapusFilm.Size = new System.Drawing.Size(169, 47);
            this.BTN_HapusFilm.TabIndex = 10;
            this.BTN_HapusFilm.Text = "Hapus";
            this.BTN_HapusFilm.UseVisualStyleBackColor = true;
            this.BTN_HapusFilm.Click += new System.EventHandler(this.BTN_HapusFilm_Click);
            // 
            // BTN_EditFilm
            // 
            this.BTN_EditFilm.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EditFilm.Location = new System.Drawing.Point(293, 431);
            this.BTN_EditFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_EditFilm.Name = "BTN_EditFilm";
            this.BTN_EditFilm.Size = new System.Drawing.Size(169, 47);
            this.BTN_EditFilm.TabIndex = 9;
            this.BTN_EditFilm.Text = "Edit";
            this.BTN_EditFilm.UseVisualStyleBackColor = true;
            this.BTN_EditFilm.Click += new System.EventHandler(this.BTN_EditFilm_Click);
            // 
            // BTN_TambahFilm
            // 
            this.BTN_TambahFilm.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TambahFilm.Location = new System.Drawing.Point(95, 431);
            this.BTN_TambahFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_TambahFilm.Name = "BTN_TambahFilm";
            this.BTN_TambahFilm.Size = new System.Drawing.Size(169, 47);
            this.BTN_TambahFilm.TabIndex = 8;
            this.BTN_TambahFilm.Text = "Tambah";
            this.BTN_TambahFilm.UseVisualStyleBackColor = true;
            this.BTN_TambahFilm.Click += new System.EventHandler(this.BTN_TambahFilm_Click);
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PB1.Location = new System.Drawing.Point(637, 404);
            this.PB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(307, 235);
            this.PB1.TabIndex = 7;
            this.PB1.TabStop = false;
            this.PB1.Click += new System.EventHandler(this.PB1_Click);
            // 
            // DTP_JadwalTayang
            // 
            this.DTP_JadwalTayang.CustomFormat = "yyyy-MM-dd";
            this.DTP_JadwalTayang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_JadwalTayang.Location = new System.Drawing.Point(676, 266);
            this.DTP_JadwalTayang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP_JadwalTayang.Name = "DTP_JadwalTayang";
            this.DTP_JadwalTayang.Size = new System.Drawing.Size(197, 22);
            this.DTP_JadwalTayang.TabIndex = 6;
            this.DTP_JadwalTayang.Value = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            // 
            // TXT_JamTayang
            // 
            this.TXT_JamTayang.Location = new System.Drawing.Point(676, 196);
            this.TXT_JamTayang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_JamTayang.Name = "TXT_JamTayang";
            this.TXT_JamTayang.Size = new System.Drawing.Size(199, 22);
            this.TXT_JamTayang.TabIndex = 5;
            // 
            // TXT_JudulFilm
            // 
            this.TXT_JudulFilm.Location = new System.Drawing.Point(676, 126);
            this.TXT_JudulFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_JudulFilm.Name = "TXT_JudulFilm";
            this.TXT_JudulFilm.Size = new System.Drawing.Size(203, 22);
            this.TXT_JudulFilm.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 36);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jadwal Tayang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(676, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Jam Tayang(HH:MM:SS)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Judul film";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 7);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(608, 377);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Studio";
            // 
            // CBX_Studio
            // 
            this.CBX_Studio.FormattingEnabled = true;
            this.CBX_Studio.Location = new System.Drawing.Point(676, 334);
            this.CBX_Studio.Name = "CBX_Studio";
            this.CBX_Studio.Size = new System.Drawing.Size(197, 24);
            this.CBX_Studio.TabIndex = 15;
            // 
            // FormAdminFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 674);
            this.Controls.Add(this.HLMN_Film);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdminFilm";
            this.Text = "Form1";
            this.HLMN_Film.ResumeLayout(false);
            this.HLMN_Film.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HLMN_Film;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Label Poster;
        private System.Windows.Forms.Button BTN_HapusFilm;
        private System.Windows.Forms.Button BTN_EditFilm;
        private System.Windows.Forms.Button BTN_TambahFilm;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.DateTimePicker DTP_JadwalTayang;
        private System.Windows.Forms.TextBox TXT_JamTayang;
        private System.Windows.Forms.TextBox TXT_JudulFilm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.OpenFileDialog Bukafoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBX_Studio;
    }
}