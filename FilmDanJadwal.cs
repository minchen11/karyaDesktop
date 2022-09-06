using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TiketBioskop
{
    public partial class FilmDanJadwal : Form
    {
    readonly Koneksi conn = new Koneksi();

        public FilmDanJadwal()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }

        private void PB1_Click(object sender, EventArgs e)
        {
            BukaFoto.Filter = "*.jpg ; *.png ;*.*|";
            BukaFoto.ShowDialog();
            PB1.SizeMode = PictureBoxSizeMode.Zoom;
            PB1.ImageLocation = BukaFoto.FileName;
        }

        
    }
}
