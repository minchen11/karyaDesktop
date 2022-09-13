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
       
        

        public admin()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            
        }

        private void BTN_Studio_Click(object sender, EventArgs e)
        {
            FormAdminStudio form_studio = new FormAdminStudio();
            form_studio.TopLevel = false;
            form_studio.WindowState = FormWindowState.Maximized;
            PanelAdmin.Controls.Add(form_studio);
            form_studio.Show();
        }

        private void BTN_akun_Click(object sender, EventArgs e)
        {
            FormAdminAkun form_akun = new FormAdminAkun();
            form_akun.TopLevel = false;
            form_akun.WindowState = FormWindowState.Maximized;
            PanelAdmin.Controls.Add(form_akun);
            form_akun.Show();
        }

        private void Film_Click(object sender, EventArgs e)
        {
            FormAdminFilm form_film = new FormAdminFilm();
            form_film.TopLevel = false;
            form_film.WindowState = FormWindowState.Maximized;
            PanelAdmin.Controls.Add(form_film);
            form_film.Show();
        }
    }
}
