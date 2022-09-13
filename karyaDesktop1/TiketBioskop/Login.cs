using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TiketBioskop
{
    public partial class Login : Form
    {
        readonly Koneksi conn = new Koneksi();
       // MySqlDataReader baca;
        //readonly string admin_level;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            conn.koneksi.Open();
            MySqlCommand check_data = new MySqlCommand("select * from account where username = '" + TXTName.Text + "' AND password = '" + TXTPassword.Text + "'", conn.koneksi);

            //check_data.Parameters.AddWithValue("@adminlevel", admin_level);

            MySqlDataReader baca=check_data.ExecuteReader();

            if (baca.Read())
            { 
                FilmDanJadwal a = new FilmDanJadwal();
                a.Show();
                this.Hide();

                string AdminLevelCheck =baca.GetString(baca.GetOrdinal ("admin_level"));
              
                if (baca.HasRows)
                {
                    if (AdminLevelCheck== "Administrator")
                    {
                        a.Filmdanjadwal = "Administrator";
                        a.adminToolStripMenuItem.Enabled=true;
                    }
                    else
                    {
                        a.Filmdanjadwal = "Operator";
                        a.adminToolStripMenuItem.Enabled = false;
                    }
                }
             }
            else
            {
                MessageBox.Show("Username atau password salah");
            }

            conn.koneksi.Close();
           
      
        }

        private void CCBPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CCBPassword.Checked == true)
            {
                TXTPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TXTPassword.UseSystemPasswordChar = true;
            }
        }

        private void TXTPassword_TextChanged(object sender, EventArgs e)
        {
            TXTPassword.UseSystemPasswordChar = true;
        }
    }
}
