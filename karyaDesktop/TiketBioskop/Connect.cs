using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace TiketBioskop
{
	public class Koneksi
	{
		public MySqlConnection koneksi = new MySqlConnection("server=localhost;database=dbbioskop;uid=root;pass=;Convert Zero Datetime=True");


		public DataTable showdata(string namatable)
		{
			DataTable Table = new DataTable();
			try
			{
				koneksi.Open();
				MySqlCommand query = new MySqlCommand("select * from account", koneksi);
				MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query);
				DataAdapter.Fill(Table);
			}
			catch (Exception error)
			{
				MessageBox.Show("error: "+error.Message);
			}

			koneksi.Close();
			return Table;
		}

		public DataTable showdatafilm()
		{
            DataTable Table = new DataTable();
            try
            {
                koneksi.Open();
                MySqlCommand query = new MySqlCommand("select distinct id_film,nama_film,jadwal_tayang,jam_tayang,poster from film", koneksi);
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query);
                DataAdapter.Fill(Table);
            }
            catch (Exception error)
            {
                MessageBox.Show("error"+error.Message);
            }

            koneksi.Close();
            return Table;
        }
	}
}