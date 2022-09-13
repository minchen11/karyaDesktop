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

        private void CBX_NamaFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.koneksi.Open();
                CBX_JamTayang.Items.Clear();
                string jadwal = "select jam_tayang,poster from film where nama_film = @namafilm";
                MySqlCommand query = new MySqlCommand(jadwal, conn.koneksi);
                query.Parameters.AddWithValue("@namafilm", CBX_NamaFilm.Text);
                MySqlDataReader read;
                read = query.ExecuteReader();
                //Masukkan data ke combobox

                while (read.Read())
                {
                    //yang lama
                     //CBX_JamTayang.Text = read.GetString("jam_tayang");

                    //yang baru
                    CBX_JamTayang.Items.Add(read.GetString("jam_tayang"));

                    PB1.Image = Image.FromFile(read.GetString("poster"));
                    PB1.SizeMode = PictureBoxSizeMode.Zoom;

                    //CBX_JamTayang.Items.AddRange("jam_tayang");
                }
                conn.koneksi.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
        }

        public string Filmdanjadwal
        {
            set { adminLevelToolStripMenuItem.Text = value; }
            get { return adminLevelToolStripMenuItem.Text; }
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.Show();
         
        }

        private void ubahPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserAkun a = new FormUserAkun();
            a.Show();
        }
    }
}
