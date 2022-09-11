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
        MySqlCommand check_data;
        MySqlDataReader baca;

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
            check_data = new MySqlCommand("select * from account where username = '" + TXTName.Text + "' AND password = '" + TXTPassword.Text + "'", conn.koneksi);

            baca=check_data.ExecuteReader();

         
            if (baca.Read()) 
            { 
                FilmDanJadwal a = new FilmDanJadwal();
                a.Show();
                this.Hide();
             }
            else
            {
                MessageBox.Show("Username atau password salah");
            }
            
            conn.koneksi.Close();
            baca.Close();
      
        }

        //Kondisi untuk show password
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

        //fungsi untuk password jadi bullet
        private void TXTPassword_TextChanged(object sender, EventArgs e)
        {
            TXTPassword.UseSystemPasswordChar = true;
        }
    }
}
