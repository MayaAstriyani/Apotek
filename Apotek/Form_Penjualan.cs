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
    public partial class Form_Penjualan : Form
    {
        SqlConnection conn = new SqlConnection(Connection.conn);

        Form_Home callingForm;

        DataTable DataTabelKasir;

        bool isAdding;

        public int total_harga;

        public string get_kode_obat { get; set; }

        public string get_nama_obat { get; set; }

        public string get_harga_obat { get; set; }

        public string get_satuan_obat { get; set; }

        public string get_nomor_transaksi { get; set; }

        public Form_Penjualan()
        {
            // TODO: Complete member initialization
            isAdding = false;
            InitializeComponent();

            TampilData();
        }

        //menampilkan data
        private void TampilData()
        {
            DataTabelKasir = new DataTable();
            DataTabelKasir.Columns.Add("Kode Obat", typeof(string));
            DataTabelKasir.Columns.Add("Obat", typeof(string));
            DataTabelKasir.Columns.Add("Harga", typeof(int));
            DataTabelKasir.Columns.Add("Satuan", typeof(string));
            DataTabelKasir.Columns.Add("Jumlah", typeof(int));
            DataTabelKasir.Columns.Add("Total", typeof(int));
        }

        //time picker untuk tanggal transaksi
        private void time_picker_ValueChanged(object sender, EventArgs e)
        {
            tb_tgl_trans.Text = time_picker.Text;
        }

        public void reset()
        {
            //reset sebelum menambahkan barang
            total_harga = 0;

            tb_no_trans.Clear();
            tb_tgl_trans.Clear();
            tb_kode_obat.Clear();
            tb_total_bayar.Clear();
            tb_bayar.Clear();
            tb_kembalian.Clear();
            tb_nama_obat.Clear();
            tb_harga_obat.Clear();
            tb_jumlah_obat.Clear();
            tb_satuan_obat.Clear();
        }

        public void resetTambah()
        {
            //reset sesudah menambahkan barang
            tb_kode_obat.Clear();
            tb_nama_obat.Clear();
            tb_harga_obat.Clear();
            tb_jumlah_obat.Clear();
            tb_satuan_obat.Clear();
        }

        private void Form_Penjualan_Load(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_kode_obat.Text) && !String.IsNullOrEmpty(tb_jumlah_obat.Text))
            {
                try
                {
                    total_harga = int.Parse(get_harga_obat) * int.Parse(tb_jumlah_obat.Text);

                    DataRow dataRow;
                    dataRow = DataTabelKasir.NewRow();
                    dataRow[0] = get_kode_obat;
                    dataRow[1] = get_nama_obat;
                    dataRow[2] = int.Parse(get_harga_obat);
                    dataRow[3] = get_satuan_obat;
                    dataRow[4] = int.Parse(tb_jumlah_obat.Text);
                    dataRow[5] = total_harga;
                    DataTabelKasir.Rows.Add(dataRow);

                    resetTambah();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Silahkan coba lagi");
                }
            }

            else
            {
                MessageBox.Show("Harap isi kolom yang kosong");
            }
        }


        private void btn_data_baru_Click(object sender, EventArgs e)
        {
            dgv_daftar_penjualan.DataSource = null;
            tb_bayar.Clear();
            tb_kembalian.Clear();
            tb_total_bayar.Clear();

            isAdding = true;

            dgv_daftar_penjualan.DataSource = DataTabelKasir;

            time_picker.Enabled = true;
            tb_jumlah_obat.Enabled = true;
            tb_bayar.Enabled = true;

            btn_pilih_obat.Enabled = true;
            btn_tambah.Enabled = true;
            btn_hapus.Enabled = true;
            btn_batal.Enabled = true;
            btn_simpan.Enabled = true;

            btn_data_baru.Enabled = false;
            btn_hapus_data.Enabled = false;
            btn_riwayat_penjualan.Enabled = false;

            tb_tgl_trans.Text = time_picker.Text;
            tb_no_trans.Text = DateTime.Now.ToString("ddMMyyHHmm");
        }

        private void btn_pilih_obat_Click(object sender, EventArgs e)
        {
            tb_jumlah_obat.Text = "";

            try
            {
                Form_Pilih_Obat form_Milih_Obat = new Form_Pilih_Obat(this);
                form_Milih_Obat.FormClosed += form_Pilih_ObatClosed;
                form_Milih_Obat.ShowDialog();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message, "Silahkan coba lagi");
            }
        }

        private void form_Pilih_ObatClosed(object sender, FormClosedEventArgs e)
        {
            tb_kode_obat.Text = get_kode_obat;
            tb_nama_obat.Text = get_nama_obat;
            tb_harga_obat.Text = get_harga_obat;
            tb_satuan_obat.Text = get_satuan_obat;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_no_trans.Text) && !String.IsNullOrEmpty(tb_tgl_trans.Text) && !String.IsNullOrEmpty(tb_total_bayar.Text) && !String.IsNullOrEmpty(tb_bayar.Text) && !String.IsNullOrEmpty(tb_kembalian.Text))
            {
                string no_transaksi = tb_no_trans.Text;
                DateTime tanggal_transaksi = DateTime.Parse(tb_tgl_trans.Text);
                int total_pembayaran = int.Parse(tb_total_bayar.Text);
                int kembalian = int.Parse(tb_kembalian.Text);
                int pembayaran_pelanggan = int.Parse(tb_bayar.Text);

                SqlCommand cmd = new SqlCommand("INSERT INTO Transaksi_apotek VALUES (@no_transaksi, @tanggal_transaksi, @total_pembayaran, @kembalian, @pembayaran_pelanggan)", conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@no_transaksi", no_transaksi);
                cmd.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi);
                cmd.Parameters.AddWithValue("@total_pembayaran", total_pembayaran);
                cmd.Parameters.AddWithValue("@kembalian", kembalian);
                cmd.Parameters.AddWithValue("@pembayaran_pelanggan", pembayaran_pelanggan);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                foreach (DataGridViewRow item in dgv_daftar_penjualan.Rows)
                {
                    int fix_stok = 0;

                    //select obat
                    SqlCommand cmdSelect = new SqlCommand("SELECT jumlah_stok FROM Obat_apotek WHERE kode_obat = @kode_obat", conn);
                    cmdSelect.Parameters.AddWithValue("@kode_obat", item.Cells[0].Value.ToString());

                    conn.Open();
                    SqlDataReader sdr = cmdSelect.ExecuteReader();
                    while (sdr.Read())
                    {
                        fix_stok = int.Parse(sdr.GetValue(0).ToString()) - int.Parse(item.Cells[4].Value.ToString());
                    }
                    conn.Close();

                    //insert ke itemtransaksi
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO Item_transaksi VALUES (@kode_obat, @no_transaksi, @jumlah)", conn);
                    cmdInsert.CommandType = CommandType.Text;

                    cmdInsert.Parameters.AddWithValue("@kode_obat", item.Cells[0].Value.ToString());
                    cmdInsert.Parameters.AddWithValue("@no_transaksi", no_transaksi);
                    cmdInsert.Parameters.AddWithValue("@jumlah", int.Parse(item.Cells[4].Value.ToString()));

                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    conn.Close();

                    //update stok obat
                    SqlCommand cmdUpdateStok = new SqlCommand("UPDATE Obat_apotek SET jumlah_stok = @jumlah_stok WHERE kode_obat = @kode_obat", conn);
                    cmdUpdateStok.CommandType = CommandType.Text;

                    cmdUpdateStok.Parameters.AddWithValue("@kode_obat", item.Cells[0].Value.ToString());
                    cmdUpdateStok.Parameters.AddWithValue("@jumlah_stok", fix_stok);

                    conn.Open();
                    cmdUpdateStok.ExecuteNonQuery();
                    conn.Close();

                    btn_batal.Enabled = false;
                    btn_simpan.Enabled = false;
                    btn_tambah.Enabled = false;
                    btn_hapus.Enabled = false;
                    btn_pilih_obat.Enabled = false;

                    btn_data_baru.Enabled = true;
                    btn_hapus_data.Enabled = true;
                    btn_riwayat_penjualan.Enabled = true;

                    reset();

                    dgv_daftar_penjualan.DataSource = null;

                    time_picker.Enabled = false;
                    tb_jumlah_obat.Enabled = false;
                    tb_bayar.Enabled = false;
                }

                isAdding = false;
            }

            else
            {
                MessageBox.Show("Harap isi kolom yang kosong");
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (dgv_daftar_penjualan.SelectedRows.Count > 0)
            {
                total_harga = int.Parse(dgv_daftar_penjualan.SelectedRows[0].Cells[5].Value.ToString());

                dgv_daftar_penjualan.Rows.RemoveAt(dgv_daftar_penjualan.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Tidak Ada Data Yang Dipilih");
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            isAdding = false;

            btn_batal.Enabled = false;
            btn_simpan.Enabled = false;
            btn_tambah.Enabled = false;
            btn_hapus.Enabled = false;
            btn_pilih_obat.Enabled = false;

            btn_data_baru.Enabled = true;
            btn_hapus_data.Enabled = true;
            btn_riwayat_penjualan.Enabled = true;

            reset();

            dgv_daftar_penjualan.DataSource = null;

            time_picker.Enabled = false;
            tb_jumlah_obat.Enabled = false;
            tb_bayar.Enabled = false;

            DataTabelKasir.Clear();
        }

        private void tb_total_bayar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_bayar.Text) && String.IsNullOrEmpty(tb_total_bayar.Text))
            {
                tb_kembalian.Text = "";
            }

            else if (String.IsNullOrEmpty(tb_total_bayar.Text))
            {
                if (String.IsNullOrEmpty(tb_bayar.Text))
                {
                    tb_kembalian.Text = "";
                }

                else
                {
                    tb_kembalian.Text = (int.Parse(tb_bayar.Text) - 0).ToString();
                }
            }

            else if (String.IsNullOrEmpty(tb_bayar.Text))
            {
                if (String.IsNullOrEmpty(tb_total_bayar.Text))
                {
                    tb_kembalian.Text = "";
                }

                else
                {
                    tb_kembalian.Text = (0 - int.Parse(tb_total_bayar.Text)).ToString();
                }
            }

            else
            {
                tb_kembalian.Text = (int.Parse(tb_bayar.Text) - int.Parse(tb_total_bayar.Text)).ToString();
            }
        }


        private void tb_bayar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_bayar.Text) && String.IsNullOrEmpty(tb_total_bayar.Text))
            {
                tb_kembalian.Text = "";
            }

            else if (String.IsNullOrEmpty(tb_bayar.Text))
            {
                if (String.IsNullOrEmpty(tb_total_bayar.Text))
                {
                    tb_kembalian.Text = "";
                }

                else
                {
                    tb_kembalian.Text = (0 - int.Parse(tb_total_bayar.Text)).ToString();
                }
            }

            else if (String.IsNullOrEmpty(tb_total_bayar.Text))
            {
                if (String.IsNullOrEmpty(tb_bayar.Text))
                {
                    tb_kembalian.Text = "";
                }

                else
                {
                    tb_kembalian.Text = (int.Parse(tb_bayar.Text) - 0).ToString();
                }
            }

            else
            {
                tb_kembalian.Text = (int.Parse(tb_bayar.Text) - int.Parse(tb_total_bayar.Text)).ToString();
            }

            txt_total_pembayaran.Text = "Rp. " + tb_bayar.Text;
        }

        private void tb_kembalian_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_kembalian.Text))
            {
                if (int.Parse(tb_kembalian.Text) >= 0)
                {
                    txt_kembalian.Text = "Rp. " + tb_kembalian.Text;
                }

                else
                {
                    txt_kembalian.Text = "-Rp. " + (int.Parse(tb_kembalian.Text) * -1).ToString();
                }
            }

            else
            {
                txt_kembalian.Text = "Rp. 0";
            }
        }

        private void btn_hapus_data_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_no_trans.Text))
            {
                if (MessageBox.Show("Yakin ingin menghapus data?", "Peringatan!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        SqlCommand sqlCommand = new SqlCommand("DELETE FROM Transaksi_apotek WHERE no_transaksi = @no_transaksi", conn);
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Parameters.AddWithValue("@no_transaksi", tb_no_trans.Text);
                        sqlCommand.ExecuteNonQuery();

                        conn.Close();

                        reset();

                        dgv_daftar_penjualan.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!");
                    }
                }
            }

            else
            {
                MessageBox.Show("Tidak ada data yang dipilih!");
            }
        }

        private void tb_jumlah_obat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_bayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgv_daftar_penjualan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_total_bayar.Text))
            {
                tb_total_bayar.Text = total_harga.ToString();

                total_harga = 0;
            }

            else
            {
                int current_total = int.Parse(tb_total_bayar.Text);
                tb_total_bayar.Text = (current_total + total_harga).ToString();

                total_harga = 0;
            }
        }

        private void dgv_daftar_penjualan_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_total_bayar.Text))
            {
                tb_total_bayar.Text = (0 - total_harga).ToString();
            }

            else
            {
                int current_total = int.Parse(tb_total_bayar.Text);
                tb_total_bayar.Text = (current_total - total_harga).ToString();
            }
        }

        private void btn_riwayat_penjualan_Click(object sender, EventArgs e)
        {
            get_nomor_transaksi = "";

            try
            {
                Form_Riwayat form_Riwayat = new Form_Riwayat(this);
                form_Riwayat.FormClosed += form_Riwayat_Closed;
                form_Riwayat.ShowDialog();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Silahkan coba lagi");
            }
        }

        private void form_Riwayat_Closed(object sender, FormClosedEventArgs e)
        {
            if (!get_nomor_transaksi.Equals(""))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Transaksi_apotek WHERE no_transaksi = @nomor_transaksi", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nomor_transaksi", get_nomor_transaksi);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    tb_no_trans.Text = sdr.GetValue(0).ToString();
                    tb_tgl_trans.Text = sdr.GetValue(1).ToString();
                    tb_total_bayar.Text = sdr.GetValue(2).ToString();
                    tb_kembalian.Text = sdr.GetValue(3).ToString();
                    tb_bayar.Text = sdr.GetValue(4).ToString();
                }

                conn.Close();

                //Get Item Transaksi

                DataTable data = new DataTable();
                data.Columns.Add("Kode Obat", typeof(string));
                data.Columns.Add("Obat", typeof(string));
                data.Columns.Add("Harga", typeof(int));
                data.Columns.Add("Satuan", typeof(string));
                data.Columns.Add("Jumlah", typeof(int));
                data.Columns.Add("Total", typeof(int));

                conn.Open();

                SqlCommand getItem = new SqlCommand("SELECT o.kode_obat, o.nama_obat, o.harga_obat, o.satuan_obat, i.jumlah FROM Obat_apotek o " +
                    "INNER JOIN Item_transaksi i on o.kode_obat = i.kode_obat WHERE i.no_transaksi = @nomor_transaksi", conn);
                getItem.CommandType = CommandType.Text;
                getItem.Parameters.AddWithValue("@nomor_transaksi", get_nomor_transaksi);
                SqlDataReader dataItem = getItem.ExecuteReader();

                while (dataItem.Read())
                {
                    DataRow dr;
                    dr = data.NewRow();
                    dr[0] = dataItem.GetValue(0).ToString();
                    dr[1] = dataItem.GetValue(1).ToString();
                    dr[2] = int.Parse(dataItem.GetValue(2).ToString());
                    dr[3] = dataItem.GetValue(3).ToString();
                    dr[4] = int.Parse(dataItem.GetValue(4).ToString());
                    dr[5] = int.Parse(dataItem.GetValue(4).ToString()) * int.Parse(dataItem.GetValue(2).ToString());
                    data.Rows.Add(dr);
                }

                conn.Close();

                dgv_daftar_penjualan.DataSource = data;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_jumlah_obat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
