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
            this.Film = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_akun = new System.Windows.Forms.Button();
            this.BTN_Studio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HLMN_Studio = new System.Windows.Forms.Panel();
            this.HLMN_Akun = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Password = new System.Windows.Forms.Label();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_ID_Karyawan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HLMN_Film = new System.Windows.Forms.Panel();
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
            this.BukaFoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.HLMN_Studio.SuspendLayout();
            this.HLMN_Akun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.HLMN_Film.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            // Film
            // 
            this.Film.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Film.Location = new System.Drawing.Point(44, 298);
            this.Film.Name = "Film";
            this.Film.Size = new System.Drawing.Size(173, 43);
            this.Film.TabIndex = 6;
            this.Film.Text = "Admin Film";
            this.Film.UseVisualStyleBackColor = true;
            this.Film.Click += new System.EventHandler(this.Film_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(44, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Admin";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BTN_akun
            // 
            this.BTN_akun.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_akun.Location = new System.Drawing.Point(44, 227);
            this.BTN_akun.Name = "BTN_akun";
            this.BTN_akun.Size = new System.Drawing.Size(173, 43);
            this.BTN_akun.TabIndex = 4;
            this.BTN_akun.Text = "Admin Akun ";
            this.BTN_akun.UseVisualStyleBackColor = true;
            this.BTN_akun.Click += new System.EventHandler(this.BTN_akun_Click);
            // 
            // BTN_Studio
            // 
            this.BTN_Studio.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Studio.Location = new System.Drawing.Point(44, 155);
            this.BTN_Studio.Name = "BTN_Studio";
            this.BTN_Studio.Size = new System.Drawing.Size(173, 43);
            this.BTN_Studio.TabIndex = 3;
            this.BTN_Studio.Text = "Admin Studio";
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
            // HLMN_Studio
            // 
            this.HLMN_Studio.Controls.Add(this.HLMN_Akun);
            this.HLMN_Studio.Controls.Add(this.label1);
            this.HLMN_Studio.Location = new System.Drawing.Point(279, 12);
            this.HLMN_Studio.Name = "HLMN_Studio";
            this.HLMN_Studio.Size = new System.Drawing.Size(948, 675);
            this.HLMN_Studio.TabIndex = 1;
            // 
            // HLMN_Akun
            // 
            this.HLMN_Akun.Controls.Add(this.label7);
            this.HLMN_Akun.Controls.Add(this.label5);
            this.HLMN_Akun.Controls.Add(this.textBox1);
            this.HLMN_Akun.Controls.Add(this.dataGridView1);
            this.HLMN_Akun.Controls.Add(this.Password);
            this.HLMN_Akun.Controls.Add(this.TXT_Password);
            this.HLMN_Akun.Controls.Add(this.label6);
            this.HLMN_Akun.Controls.Add(this.TXT_Username);
            this.HLMN_Akun.Controls.Add(this.label4);
            this.HLMN_Akun.Controls.Add(this.TXT_Nama);
            this.HLMN_Akun.Controls.Add(this.label2);
            this.HLMN_Akun.Controls.Add(this.TXT_ID_Karyawan);
            this.HLMN_Akun.Location = new System.Drawing.Point(0, 0);
            this.HLMN_Akun.Name = "HLMN_Akun";
            this.HLMN_Akun.Size = new System.Drawing.Size(948, 675);
            this.HLMN_Akun.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "No HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 447);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 657);
            this.dataGridView1.TabIndex = 10;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(16, 365);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            // 
            // TXT_Password
            // 
            this.TXT_Password.Location = new System.Drawing.Point(16, 387);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(215, 22);
            this.TXT_Password.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Username";
            // 
            // TXT_Username
            // 
            this.TXT_Username.Location = new System.Drawing.Point(16, 319);
            this.TXT_Username.Name = "TXT_Username";
            this.TXT_Username.Size = new System.Drawing.Size(215, 22);
            this.TXT_Username.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama";
            // 
            // TXT_Nama
            // 
            this.TXT_Nama.Location = new System.Drawing.Point(16, 248);
            this.TXT_Nama.Name = "TXT_Nama";
            this.TXT_Nama.Size = new System.Drawing.Size(215, 22);
            this.TXT_Nama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Karyawan";
            // 
            // TXT_ID_Karyawan
            // 
            this.TXT_ID_Karyawan.Location = new System.Drawing.Point(16, 176);
            this.TXT_ID_Karyawan.Name = "TXT_ID_Karyawan";
            this.TXT_ID_Karyawan.Size = new System.Drawing.Size(215, 22);
            this.TXT_ID_Karyawan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDIO";
            // 
            // HLMN_Film
            // 
            this.HLMN_Film.BackColor = System.Drawing.Color.Tomato;
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
            this.HLMN_Film.Location = new System.Drawing.Point(279, 12);
            this.HLMN_Film.Name = "HLMN_Film";
            this.HLMN_Film.Size = new System.Drawing.Size(948, 675);
            this.HLMN_Film.TabIndex = 3;
            // 
            // BTN_HapusFilm
            // 
            this.BTN_HapusFilm.Location = new System.Drawing.Point(646, 590);
            this.BTN_HapusFilm.Name = "BTN_HapusFilm";
            this.BTN_HapusFilm.Size = new System.Drawing.Size(124, 47);
            this.BTN_HapusFilm.TabIndex = 10;
            this.BTN_HapusFilm.Text = "Hapus";
            this.BTN_HapusFilm.UseVisualStyleBackColor = true;
            // 
            // BTN_EditFilm
            // 
            this.BTN_EditFilm.Location = new System.Drawing.Point(770, 497);
            this.BTN_EditFilm.Name = "BTN_EditFilm";
            this.BTN_EditFilm.Size = new System.Drawing.Size(124, 47);
            this.BTN_EditFilm.TabIndex = 9;
            this.BTN_EditFilm.Text = "Edit";
            this.BTN_EditFilm.UseVisualStyleBackColor = true;
            // 
            // BTN_TambahFilm
            // 
            this.BTN_TambahFilm.Location = new System.Drawing.Point(522, 497);
            this.BTN_TambahFilm.Name = "BTN_TambahFilm";
            this.BTN_TambahFilm.Size = new System.Drawing.Size(124, 47);
            this.BTN_TambahFilm.TabIndex = 8;
            this.BTN_TambahFilm.Text = "Tambah";
            this.BTN_TambahFilm.UseVisualStyleBackColor = true;
            this.BTN_TambahFilm.Click += new System.EventHandler(this.BTN_TambahFilm_Click);
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PB1.Location = new System.Drawing.Point(43, 319);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(350, 293);
            this.PB1.TabIndex = 7;
            this.PB1.TabStop = false;
            this.PB1.Click += new System.EventHandler(this.PB1_Click);
            // 
            // DTP_JadwalTayang
            // 
            this.DTP_JadwalTayang.Location = new System.Drawing.Point(42, 277);
            this.DTP_JadwalTayang.Name = "DTP_JadwalTayang";
            this.DTP_JadwalTayang.Size = new System.Drawing.Size(200, 22);
            this.DTP_JadwalTayang.TabIndex = 6;
            // 
            // TXT_JamTayang
            // 
            this.TXT_JamTayang.Location = new System.Drawing.Point(38, 201);
            this.TXT_JamTayang.Name = "TXT_JamTayang";
            this.TXT_JamTayang.Size = new System.Drawing.Size(165, 22);
            this.TXT_JamTayang.TabIndex = 5;
            // 
            // TXT_JudulFilm
            // 
            this.TXT_JudulFilm.Location = new System.Drawing.Point(38, 125);
            this.TXT_JudulFilm.Name = "TXT_JudulFilm";
            this.TXT_JudulFilm.Size = new System.Drawing.Size(169, 22);
            this.TXT_JudulFilm.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Prototype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jadwal Tayang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Prototype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Jam Tayang(HH:MM:SS)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prototype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Judul film";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(456, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(489, 463);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
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
            this.Controls.Add(this.HLMN_Film);
            this.Controls.Add(this.HLMN_Studio);
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.panel1.ResumeLayout(false);
            this.HLMN_Studio.ResumeLayout(false);
            this.HLMN_Studio.PerformLayout();
            this.HLMN_Akun.ResumeLayout(false);
            this.HLMN_Akun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.HLMN_Film.ResumeLayout(false);
            this.HLMN_Film.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTN_akun;
        private System.Windows.Forms.Button BTN_Studio;
        private System.Windows.Forms.Button Film;
        private System.Windows.Forms.Panel HLMN_Studio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HLMN_Akun;
        private System.Windows.Forms.Panel HLMN_Film;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_ID_Karyawan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.OpenFileDialog BukaFoto;
    }
}