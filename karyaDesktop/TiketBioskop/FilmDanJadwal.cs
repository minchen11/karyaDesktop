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
            CBX_NamaFilm.DataSource = conn.showdatafilm();
            CBX_NamaFilm.ValueMember = "nama_film";
            CBX_NamaFilm.DisplayMember = "nama_film";

        }

        //untuk pindah ke laman admin
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }

        private void CBX_NamaFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.koneksi.Open();
                CBX_JamTayang.Items.Clear();
                string jadwal = "select  jam_tayang,poster from film where nama_film = @namafilm";
                MySqlCommand query = new MySqlCommand(jadwal, conn.koneksi);
                query.Parameters.AddWithValue("@namafilm", CBX_NamaFilm.Text);
                MySqlDataReader read;
                read = query.ExecuteReader();
                //Masukkan data ke combobox

                while (read.Read())
                {
                    CBX_JamTayang.Items.Add(read.GetString("jam_tayang"));
                   //PB1.ImageLocation = CBX_NamaFilm.Text;
                    // CBX_JamTayang.Items.Add(read("jam_tayang"));
                    PB1.Image = Image.FromFile(read.GetString("poster"));
                    PB1.SizeMode = PictureBoxSizeMode.Zoom;
                }

               
                conn.koneksi.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FilmDanJadwal_Load(object sender, EventArgs e)
        {

        }

        //saat klik linklabel (next>>) bakal pindah ke form kursi
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kursi a = new Kursi();
            a.Show();
            this.Hide();
        }
    }
}
