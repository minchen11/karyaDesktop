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
		public MySqlConnection koneksi = new MySqlConnection("server=localhost;database=Dbbioskop;uid=root;pass=;Convert Zero Datetime=True");


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
			catch (Exception)
			{
				MessageBox.Show("Gagal");
			}

			koneksi.Close();
			return Table;
		}

		public DataTable showdatafilm(string namatable)
		{
            DataTable Table = new DataTable();
            try
            {
                koneksi.Open();
                MySqlCommand query = new MySqlCommand("select * from film", koneksi);
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(query);
                DataAdapter.Fill(Table);
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal");
            }

            koneksi.Close();
            return Table;
        }
	}
}