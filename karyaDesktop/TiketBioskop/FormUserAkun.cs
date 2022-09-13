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

namespace TiketBioskop
{
    public partial class FormUserAkun : Form
    {
        readonly Koneksi conn = new Koneksi();
     
        public FormUserAkun()
        {
            InitializeComponent();
        }

        private void BTN_UbahPassword_Click(object sender, EventArgs e)
        {
            conn.koneksi.Open();
            Int32 hitung = 0;
            MySqlCommand find = new MySqlCommand("select * from account where username='" + TXT_username.Text + "' and password='" + TXT_PassLama.Text+ "'",conn.koneksi);
            MySqlDataAdapter datadapter = new MySqlDataAdapter(find);
            find.ExecuteNonQuery();
            hitung = Convert.ToInt32(find.ExecuteScalar());
            if (hitung>0)
            {
                try
                {
                    MySqlCommand update = new MySqlCommand("update account set password='" + TXT_PassBaru.Text + "'",conn.koneksi);
                    MySqlDataAdapter Dataadapter = new MySqlDataAdapter(update);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Password Berhasil Diubah");
                }
                catch(Exception error)
                {
                    MessageBox.Show("error: ",error.Message);
                }
            }else
            {
                MessageBox.Show("Akun Belum Terdaftar");
            }
            conn.koneksi.Close();
            
        }

        private void kembaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
