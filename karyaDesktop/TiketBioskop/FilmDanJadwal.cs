using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace TiketBioskop
{
    public partial class FilmDanJadwal : Form
    {
        readonly Koneksi conn = new Koneksi();

        public FilmDanJadwal()
        {
            InitializeComponent();
            CBX_NamaFilm.DataSource = datafilm();
            CBX_NamaFilm.ValueMember = "id_film";
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

            }
            catch (Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
            conn.koneksi.Close();
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

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            PreviewTiket b = new PreviewTiket();
            Kursi a = new Kursi();
            b.LBL_Studio.Text = CBX_NamaFilm.SelectedValue.ToString();
            a.Show();
            this.Hide();
            
        }

        public DataTable datafilm()
        {
            DataTable Table = new DataTable();
            try
            {
                conn.koneksi.Close();
                MySqlCommand query = new MySqlCommand("select id_studio,id_film,nama_film,jadwal_tayang,jam_tayang,poster from film group by nama_film", conn.koneksi);
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query);
                DataAdapter.Fill(Table);
            }
            catch (Exception error)
            {
                MessageBox.Show("error" + error.Message);
            }

            conn.koneksi.Close();
            return Table;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a =  new Login();
            a.Show();
            this.Close();
        }
    }
}
