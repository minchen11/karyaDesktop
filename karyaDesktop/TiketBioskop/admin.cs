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
using System.Drawing.Imaging;

namespace TiketBioskop
{
    public partial class admin : Form
    {
        readonly Koneksi conn = new Koneksi();
        DataSet data = new DataSet();
        string id_film;

        public admin()
        {
            InitializeComponent();
            TampilkanData();
            tampilkandatafilm();
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

        //Menampilkan data akun
       void TampilkanData()
        {
            dataGridView1.DataSource = conn.showdata("account");
            dataGridView1.Columns[0].HeaderText = "Id anggota";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Password";
            dataGridView1.Columns[4].HeaderText = "No Hp";

        }

        //Menampilkan data film
        void tampilkandatafilm()
        {
            dataGridView2.DataSource = conn.showdatafilm();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Judul Film";
            dataGridView2.Columns[2].HeaderText = "Jadwal Tayang";
            dataGridView2.Columns[3].HeaderText = "Jam Tayang";
            dataGridView2.Columns[4].HeaderText = "Poster";
        }

        //Input pict ke PictureBox
        private void PB1_Click(object sender, EventArgs e)
        {
            BukaFoto.Filter = "*.jpg ; *.png ;*.*|";
            BukaFoto.ShowDialog();
            PB1.SizeMode = PictureBoxSizeMode.Zoom;
            PB1.ImageLocation = BukaFoto.FileName;
            Poster.Text= PB1.ImageLocation;
        }

       
        //Data Grid view yang menampilkan data Film
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.koneksi.Open();
                id_film = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                TXT_JudulFilm.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                DTP_JadwalTayang.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                TXT_JamTayang.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                //PB1.ImageLocation = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                //PB1.SizeMode = PictureBoxSizeMode.Zoom;
                string a = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                conn.koneksi.Close();
                PB1.Image = Image.FromFile(a);
                PB1.SizeMode = PictureBoxSizeMode.Zoom;
                Poster.Text = PB1.ImageLocation;
            }
            catch (Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
        }

        //insert data film
        private void BTN_TambahFilm_Click(object sender, EventArgs e)
        {
            try
            {
                
                //string create = "insert into film (nama_film,jadwal_tayang,jam_tayang,poster) values ('" + TXT_JudulFilm.Text + "','" + DTP_JadwalTayang.Text + "','" + TXT_JamTayang.Text + "','" + Poster.Text + "')";
                string create = "insert into film (nama_film,jadwal_tayang,jam_tayang,poster) values ('" + TXT_JudulFilm.Text + "','" + DTP_JadwalTayang.Text + "','" + TXT_JamTayang.Text + "', @poster)";
                conn.koneksi.Open();
                MySqlCommand query = new MySqlCommand(create, conn.koneksi);
                query.Parameters.AddWithValue("@poster", Poster.Text);
                query.Prepare();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil");
                conn.koneksi.Close();
                tampilkandatafilm();
            }
            catch(Exception error)
            {
                MessageBox.Show("error: "+error.Message);
            }
        }

        //Button Hapus
        private void BTN_HapusFilm_Click(object sender, EventArgs e)
        {
            conn.koneksi.Open();
            try
            {
                string delete = ("delete from film where id_film=@id");
                
                
                MySqlCommand query = new MySqlCommand(delete,conn.koneksi);

                query.Parameters.AddWithValue("@id",id_film);

                query.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
                conn.koneksi.Close();
                tampilkandatafilm();
                clear();

            }catch(Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
            
        }

        //Button Edit
        private void BTN_EditFilm_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update film set nama_film=@judulfilm,jadwal_tayang=@jadwaltayang,jam_tayang=@jamtayang,poster=@poster WHERE id_film=@id";
                conn.koneksi.Open();
                MySqlCommand query = new MySqlCommand(update, conn.koneksi);
                query.Parameters.AddWithValue("@poster",Poster.Text);
                query.Parameters.AddWithValue("@id", id_film);
                query.Parameters.AddWithValue("@judulfilm", TXT_JudulFilm.Text);
                query.Parameters.AddWithValue("@jadwaltayang", DTP_JadwalTayang.Text);
                query.Parameters.AddWithValue("@jamtayang", TXT_JamTayang.Text);
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil");
                conn.koneksi.Close();
                tampilkandatafilm();

            }
            catch(Exception error)
            {
                MessageBox.Show("error: ", error.Message);
            }
        }

        //Fungsi clear
        void clear()
        {
            TXT_JudulFilm.Clear();
            DTP_JadwalTayang.Text = "";
            TXT_JamTayang.Clear();
            PB1.Refresh();
            
        }

        //Button Clear
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FilmDanJadwal a = new FilmDanJadwal();
            a.Show();
        }
    }
}
