using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiketBioskop
{
    public partial class FormAdminAkun : Form
    {
        readonly Koneksi conn = new Koneksi();
        
        public FormAdminAkun()
        {
            InitializeComponent();
            TXT_ID_Karyawan.ReadOnly = true;
        }

        private void BTN_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.koneksi.Open();
                Int32 hitung = 0;
                string cek = "select * from account where username='"+TXT_Username.Text+"' and password='"+TXT_Password.Text+"'";
                MySqlCommand query_check = new MySqlCommand(cek, conn.koneksi);
                hitung = Convert.ToInt32(query_check.ExecuteScalar());

                if (hitung>0) 
                {
                    MessageBox.Show("Akun sudah ada");
                }
                else
                {
                    //string create = "insert into film (nama_film,jadwal_tayang,jam_tayang,poster) values ('" + TXT_JudulFilm.Text + "','" + DTP_JadwalTayang.Text + "','" + TXT_JamTayang.Text + "','" + Poster.Text + "')";
                    string create = "insert into account (username,password,nama,no_hp) values ('" + TXT_Username.Text + "','" + Password.Text + "','" + TXT_Nama.Text + "', no_hp=@nohp)";

                    MySqlCommand query = new MySqlCommand(create, conn.koneksi);
                    query.Parameters.AddWithValue("@nohp", TXT_NoHp.Text);
                    query.Prepare();
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter(query);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Berhasil");
                 
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
              conn.koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.koneksi.Open();
            try
            {
                string update = "update film set username='" + TXT_Username + "',password='" + TXT_Password + "',nama='" + TXT_Nama + "',no_hp =@nohp where username='"+TXT_Username.Text+"' and password='"+TXT_Password.Text+"'";
                MySqlCommand query = new MySqlCommand(update,conn.koneksi);
                query.Parameters.AddWithValue("@no_hp", TXT_NoHp);
                MySqlDataAdapter datadapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                MessageBox.Show("berhasil");
                conn.koneksi.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
        }
    }
}