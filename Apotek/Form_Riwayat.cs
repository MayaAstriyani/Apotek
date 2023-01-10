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
    public partial class Form_Riwayat : Form
    {
        Form_Penjualan callingform;
        DataTable dt = new DataTable();

        SqlConnection conn = new SqlConnection(Connection.conn);

        public Form_Riwayat(Form_Penjualan form_Penjualan)
        {
            InitializeComponent();
            TampilData();
            callingform = form_Penjualan;

            cb_filter.Text = "Semua";
        }

        private void TampilData()
        {
            dt = new DataTable();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Transaksi_apotek", conn);
            cmd.CommandType = CommandType.Text;

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            conn.Close();

            dgv_riwayat_penjualan.DataSource = dt;
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (cb_filter.Text.Equals("Semua"))
            {
                dt = new DataTable();

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Transaksi_apotek", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                conn.Close();

                dgv_riwayat_penjualan.DataSource = dt;
            }

            else if (cb_filter.Text.Equals("Berdasarkan Nomor Transaksi"))
            {
                dt = new DataTable();

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Transaksi_apotek WHERE no_transaksi LIKE @nomor", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nomor", "%" + tb_no_transaksi.Text + "%");
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                conn.Close();

                dgv_riwayat_penjualan.DataSource = dt;
            }

            else if (cb_filter.Text.Equals("Berdasarkan Tanggal"))
            {
                TimeSpan timeSpanStart = new TimeSpan(0, 0, 0);
                TimeSpan timeSpanEnd = new TimeSpan(23, 59, 59);

                DateTime date_from = dtpTanggal.Value;
                date_from = date_from.Date + timeSpanStart;

                DateTime date_to = dtpTanggal.Value;
                date_to = date_to.Date + timeSpanEnd;

                dt = new DataTable();

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Transaksi_apotek WHERE tanggal_transaksi between @tgl_from and @tgl_to", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tgl_from", date_from);
                cmd.Parameters.AddWithValue("@tgl_to", date_to);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                conn.Close();

                dgv_riwayat_penjualan.DataSource = dt;
            }
        }

        private void dgv_riwayat_penjualan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_riwayat_penjualan.SelectedRows.Count > 0)
            {
                callingform.get_nomor_transaksi = dgv_riwayat_penjualan.SelectedRows[0].Cells[0].Value.ToString();
                Close();
            }
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filter.Text.Equals("Semua"))
            {
                tb_no_transaksi.Enabled = false;
                dtpTanggal.Enabled = false;
            }

            else if (cb_filter.Text.Equals("Berdasarkan Nomor Transaksi"))
            {
                tb_no_transaksi.Enabled = true;
                dtpTanggal.Enabled = false;
            }

            else if (cb_filter.Text.Equals("Berdasarkan Tanggal"))
            {
                tb_no_transaksi.Enabled = false;
                dtpTanggal.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_no_transaksi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
