using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace TiketBioskop
{
    public partial class PreviewTiket : Form
    {
        Koneksi conn =  new Koneksi();  
        FilmDanJadwal a = new FilmDanJadwal();


        public PreviewTiket()
        {
            InitializeComponent();
            CheckTiket();
        }

        public void CheckTiket()
        {
            LBL_HasilFilm.Text = FilmDanJadwal.nama_film;
            TXT_HasilWaktu.Text = FilmDanJadwal.jam_tayang;
            TXT_HasilHarga.Text = Kursi.hargatiket.ToString();
            TXT_HasilKursi.Text = string.Join(", ", Kursi.PreviewKursi);

            try
            {
                conn.koneksi.Open();
                MySqlCommand cek = new MySqlCommand("select id_studio from film where nama_film='" + LBL_HasilFilm.Text + "' group by id_studio; ",conn.koneksi);
                MySqlDataAdapter datadapter = new MySqlDataAdapter(cek);
                cek.ExecuteNonQuery();
                MySqlDataReader read = cek.ExecuteReader();
                if (read.Read())
                {
                    TXT_HasilStudio.Text = read.GetString("id_studio");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
            conn.koneksi.Close();
        }
    }
}
