using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TiketBioskop
{
    public partial class admin : Form
    {
        readonly Koneksi conn = new Koneksi();
        DataSet data = new DataSet();

        public admin()
        {
            InitializeComponent();
            TampilkanData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.koneksi.Open();
            MySqlDataAdapter DataFilm = new MySqlDataAdapter("select * from film", conn.koneksi);
        }

        private void BTN_Studio_Click(object sender, EventArgs e)
        {
            HLMN_Studio.BringToFront();
           
        }

        private void BTN_akun_Click(object sender, EventArgs e)
        {
            HLMN_Akun.BringToFront();
        }

        private void Film_Click(object sender, EventArgs e)
        {
            HLMN_Film.BringToFront();
        }

       void TampilkanData()
        {
            dataGridView1.DataSource = conn.showdata("account");
            dataGridView1.Columns[0].HeaderText = "Id anggota";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Password";
            dataGridView1.Columns[4].HeaderText = "No Hp";

        }

        private void PB1_Click(object sender, EventArgs e)
        {
            BukaFoto.Filter = "*.jpg ; *.png ;*.*|";
            BukaFoto.ShowDialog();
            PB1.SizeMode = PictureBoxSizeMode.Zoom;
            PB1.ImageLocation = BukaFoto.FileName;
        }

       

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.koneksi.Open();
            TXT_JudulFilm.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXT_JamTayang.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            DTP_JadwalTayang.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            conn.koneksi.Close();
        }

        private void BTN_TambahFilm_Click(object sender, EventArgs e)
        {
            try
            {
                string create = "insert into film (nama_film,jadwal_tayang,jam_tayang,poster) values (nama_film='"+TXT_JudulFilm.Text+"',jadwal_tayang='"+ DTP_JadwalTayang.Text+ "',jam_tayang='"+TXT_JamTayang+"'";
                conn.koneksi.Open();
                MySqlCommand query = new MySqlCommand(create, conn.koneksi);

                query.Prepare();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil");
                conn.koneksi.Close();
                TampilkanData();
            }
            catch(Exception)
            {
                MessageBox.Show("gagal");
            }
        }
    }
}
