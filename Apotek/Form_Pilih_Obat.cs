using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apotek
{
    public partial class Form_Pilih_Obat : Form
    {

        Form_Penjualan callingForm;

        //string kode_obat, nama_obat, satuan;
        //int harga_obat;

        DataTable dt = new DataTable();

        SqlConnection conn = new SqlConnection(Connection.conn);

        public Form_Pilih_Obat(Form_Penjualan form1)
        {
            callingForm = form1;

            InitializeComponent();
            TampilData();
        }

        private void TampilData()
        {
            //mengambil data dari database
            SqlCommand cmd = new SqlCommand("SELECT * FROM Obat_apotek", conn);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader data = cmd.ExecuteReader();
            dt.Load(data);
            conn.Close();

            dgv_daftar_obat.DataSource = dt;

            conn.Close();
        }

        private void tb_nama_obat_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Obat_Apotek WHERE nama_obat LIKE @nama OR kode_obat LIKE @kode OR nama_supplier LIKE @supplier", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nama", "%" + tb_nama_obat.Text.Trim() + "%");
            cmd.Parameters.AddWithValue("@kode", "%" + tb_nama_obat.Text.Trim() + "%");
            cmd.Parameters.AddWithValue("@supplier", "%" + tb_nama_obat.Text.Trim() + "%");

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            dt.Load(sqlDataReader);

            conn.Close();

            dgv_daftar_obat.DataSource = dt;
        }

        private void dgv_daftar_obat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            callingForm.get_kode_obat = dgv_daftar_obat.SelectedRows[0].Cells[0].Value.ToString();
            callingForm.get_nama_obat = dgv_daftar_obat.SelectedRows[0].Cells[1].Value.ToString();
            callingForm.get_harga_obat = dgv_daftar_obat.SelectedRows[0].Cells[4].Value.ToString();
            callingForm.get_satuan_obat = dgv_daftar_obat.SelectedRows[0].Cells[3].Value.ToString();

            Close();
        }

        private void dgv_daftar_obat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
