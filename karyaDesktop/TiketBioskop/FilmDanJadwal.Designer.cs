﻿namespace TiketBioskop
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BukaFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBX_NamaFilm
            // 
            this.CBX_NamaFilm.FormattingEnabled = true;
            this.CBX_NamaFilm.Location = new System.Drawing.Point(174, 349);
            this.CBX_NamaFilm.Margin = new System.Windows.Forms.Padding(4);
            this.CBX_NamaFilm.Name = "CBX_NamaFilm";
            this.CBX_NamaFilm.Size = new System.Drawing.Size(207, 24);
            this.CBX_NamaFilm.TabIndex = 0;
            this.CBX_NamaFilm.SelectedIndexChanged += new System.EventHandler(this.CBX_NamaFilm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "JUDUL FILM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "JAM TAYANG";
            // 
            // CBX_JamTayang
            // 
            this.CBX_JamTayang.FormattingEnabled = true;
            this.CBX_JamTayang.Location = new System.Drawing.Point(174, 419);
            this.CBX_JamTayang.Margin = new System.Windows.Forms.Padding(4);
            this.CBX_JamTayang.Name = "CBX_JamTayang";
            this.CBX_JamTayang.Size = new System.Drawing.Size(207, 24);
            this.CBX_JamTayang.TabIndex = 3;
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PB1.Location = new System.Drawing.Point(174, 112);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(207, 187);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 5;
            this.PB1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Admin Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BukaFoto
            // 
            this.BukaFoto.FileName = "BukaFoto";
            // 
            // FilmDanJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 554);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBX_JamTayang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBX_NamaFilm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FilmDanJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX_NamaFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBX_JamTayang;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.OpenFileDialog BukaFoto;
    }
}