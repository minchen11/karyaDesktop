using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckBox = System.Windows.Forms.CheckBox;

namespace TiketBioskop
{
    public partial class Kursi : Form
    {
        Koneksi conn = new Koneksi();
        int jumlah_tiket=0;
        FilmDanJadwal a = new FilmDanJadwal();
        public int jumlah = 0;
        public static List<string> PreviewKursi= new List<string>();
        public static int hargatiket;
        
        public Kursi()
        {
            InitializeComponent();
            CekKursi();
        }


        public void CekKursi()
        {
            CheckBox[] kursi = new CheckBox[32];
            List<string> KursiTerjual = new List<string>();
            List<DateTime> tanggal = new List<DateTime>();


            kursi[0] = CCBA1;
            kursi[1] = CCBA2;
            kursi[2] = CCBA3;
            kursi[3] = CCBA4;
            kursi[4] = CCBA5;
            kursi[5] = CCBA6;
            kursi[6] = CCBA7;
            kursi[7] = CCBA8;

            kursi[8] = CCBB1;
            kursi[9] = CCBB2;
            kursi[10] = CCBB3;
            kursi[11] = CCBB4;
            kursi[12] = CCBB5;
            kursi[13] = CCBB6;
            kursi[14] = CCBB7;
            kursi[15] = CCBB8;

            kursi[16] = CCBC1;
            kursi[17] = CCBC2;
            kursi[18] = CCBC3;
            kursi[19] = CCBC4;
            kursi[20] = CCBC5;
            kursi[21] = CCBC6;
            kursi[22] = CCBC7;
            kursi[23] = CCBC8;

            kursi[24] = CCBD1;
            kursi[25] = CCBD2;
            kursi[26] = CCBD3;
            kursi[27] = CCBD4;
            kursi[28] = CCBD5;
            kursi[29] = CCBD6;
            kursi[30] = CCBD7;
            kursi[31] = CCBD8;

            try
            {
                conn.koneksi.Open();
                MySqlCommand cek = new MySqlCommand("select kursi_terjual,tanggal from tiket", conn.koneksi);
                MySqlDataAdapter datadapter = new MySqlDataAdapter(cek);
                cek.ExecuteNonQuery();
                MySqlDataReader read = cek.ExecuteReader();
             
               
                while(read.Read())
                {
                    KursiTerjual.Add(read.GetString("kursi_terjual"));
                    tanggal.Add(read.GetDateTime("tanggal"));

                    jumlah++;
                }

                for (int a = 0; a < jumlah; a++)
                {
                    for (int b = 0; b < kursi.Length; b++)
                    {
                        if ((KursiTerjual[a] == kursi[b].Text) && (tanggal[a].ToString("yyyy-MM-dd")==DateTime.Now.ToString("yyyy-MM-dd")))
                        {
                           // kursi[b].Checked = true;
                            kursi[b].Enabled = false;
                            kursi[b].BackColor = Color.Red;
                        }
                    }
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("error: " + error.Message);
            }
            conn.koneksi.Close();
        }


        private void BTN_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FilmDanJadwal a = new FilmDanJadwal();
            a.Show();
            this.Hide();
        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            CheckBox[] kursi = new CheckBox[32];

            kursi[0] = CCBA1;
            kursi[1] = CCBA2;
            kursi[2] = CCBA3;
            kursi[3] = CCBA4;
            kursi[4] = CCBA5;
            kursi[5] = CCBA6;
            kursi[6] = CCBA7;
            kursi[7] = CCBA8;

            kursi[8] = CCBB1;
            kursi[9] = CCBB2;
            kursi[10] = CCBB3;
            kursi[11] = CCBB4;
            kursi[12] = CCBB5;
            kursi[13] = CCBB6;
            kursi[14] = CCBB7;
            kursi[15] = CCBB8;

            kursi[16] = CCBC1;
            kursi[17] = CCBC2;
            kursi[18] = CCBC3;
            kursi[19] = CCBC4;
            kursi[20] = CCBC5;
            kursi[21] = CCBC6;
            kursi[22] = CCBC7;
            kursi[23] = CCBC8;

            kursi[24] = CCBD1;
            kursi[25] = CCBD2;
            kursi[26] = CCBD3;
            kursi[27] = CCBD4;
            kursi[28] = CCBD5;
            kursi[29] = CCBD6;
            kursi[30] = CCBD7;
            kursi[31] = CCBD8;

            for (int i = 0; i < kursi.Length; i++)
            {
                if (kursi[i].Checked == true)
                {
                   
                    try
                    {
                        conn.koneksi.Open();
                        MySqlCommand tambah = new MySqlCommand("insert into tiket (id_tiket,kursi_terjual,tanggal) values (null,'" + kursi[i].Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "' )", conn.koneksi);
                        MySqlDataAdapter datadapter = new MySqlDataAdapter(tambah);
                        tambah.ExecuteNonQuery();
                        jumlah_tiket++;
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show("error: "+ error.Message);
                    }
                    PreviewKursi.Add(kursi[i].Text);
                    hargatiket += 40000;

                }
                conn.koneksi.Close();
            }
            PreviewTiket a = new PreviewTiket();
            a.Show();
            this.Hide();
        }
    }
}
