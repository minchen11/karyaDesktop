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
            CBX_AdminLevel.Items.Add("Administrator");
            CBX_AdminLevel.Items.Add("Operator");
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
                    //string AdminLevelValue = CBX_AdminLevel.SelectedItem.ToString
                    string create = "insert into account (username,password,admin_level,nama,no_hp) values ('" + TXT_Username.Text + "','"+TXT_Password.Text+"','"+CBX_AdminLevel.SelectedItem+"', '"+ TXT_Nama.Text + "', '"+TXT_NoHp.Text+"')";

                    MySqlCommand query = new MySqlCommand(create, conn.koneksi);
                    //query.Parameters.AddWithValue("@AdminLevelValue", CBX_AdminLevel.SelectedItem);
                    //query.Parameters.AddWithValue("@nohp", TXT_NoHp.Text);
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
                string update = "update film set username='" + TXT_Username + "',password='" + TXT_Password + "',nama='" + TXT_Nama + "',no_hp ='"+TXT_NoHp.Text+"' where username='"+TXT_Username.Text+"' and password='"+TXT_Password.Text+"'";
                MySqlCommand query = new MySqlCommand(update,conn.koneksi);
                //query.Parameters.AddWithValue("@no_hp", TXT_NoHp);
                MySqlDataAdapter datadapter = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                clear();
                MessageBox.Show("berhasil");
            }
            catch(Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
            conn.koneksi.Close();
        }

        private void BTN_Hapus_Click(object sender, EventArgs e)
        {
            conn.koneksi.Open();
            MySqlCommand hapus = new MySqlCommand("delete from account where username='" + TXT_Username.Text + "' and password='" + TXT_Password.Text + "'",conn.koneksi);
            MySqlDataAdapter datadapter = new MySqlDataAdapter(hapus);
            hapus.ExecuteNonQuery();
            MessageBox.Show("Berhasil");
            clear();
            conn.koneksi.Close();
        }

        private void TXT_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            TXT_Nama.Clear();
            TXT_Username.Clear();
            TXT_Password.Clear();
            TXT_NoHp.Clear();
        }
    }
}