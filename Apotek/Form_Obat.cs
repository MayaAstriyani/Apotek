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
    public partial class Form_Obat : Form
    {
        SqlConnection conn = new SqlConnection(Connection.conn);

        int id;
        string id_obat_fix;

        bool modeEdit = false;
        bool modeTambah = false;

        public Form_Obat()
        {
            InitializeComponent();
            TampilData();

            //mengambil nama supplier dari tabel Supplier_apotek untuk ditampilkan di cb_nama_supplier
            SqlCommand getSupplierList = new SqlCommand("Select nama_supplier from Supplier_apotek", conn);

            conn.Open();
            SqlDataReader supplierList = getSupplierList.ExecuteReader();

            while (supplierList.Read())
            {
                var namasupplier = supplierList.GetValue(0).ToString();

                cb_nama_supplier.Items.Add(namasupplier);
            }

            conn.Close();
        }

        private void dgv_data_obat_SelectionChanged(object sender, EventArgs e)
        {
            // menampilkan data pada textbox
            if (dgv_data_obat.SelectedRows.Count >= 1)
            {
                tb_kode_obat.Text = dgv_data_obat.SelectedRows[0].Cells[0].Value.ToString();
                tb_nama_obat.Text = dgv_data_obat.SelectedRows[0].Cells[1].Value.ToString();
                tb_jumlah_stok.Text = dgv_data_obat.SelectedRows[0].Cells[5].Value.ToString();
                cb_satuan.Text = dgv_data_obat.SelectedRows[0].Cells[3].Value.ToString();
                cb_nama_supplier.Text = dgv_data_obat.SelectedRows[0].Cells[2].Value.ToString();
                tb_harga_modal.Text = dgv_data_obat.SelectedRows[0].Cells[6].Value.ToString();
                tb_harga_jual.Text = dgv_data_obat.SelectedRows[0].Cells[4].Value.ToString();

                txt_satuan1.Text = "Per / " + dgv_data_obat.SelectedRows[0].Cells[3].Value.ToString();
                txt_satuan2.Text = "Per / " + dgv_data_obat.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void TampilData()
        {
            // mengambil data dari database
            SqlCommand cmd = new SqlCommand("SELECT * FROM Obat_apotek order by right(kode_obat, 3) asc", conn);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader data = cmd.ExecuteReader();
            dt.Load(data);
            conn.Close();

            dgv_data_obat.DataSource = dt;

            conn.Close();
        }

        private void Reset()
        {
            tb_kode_obat.Text = "";
            tb_nama_obat.Text = "";
            tb_jumlah_stok.Text = "";
            cb_nama_supplier.Text = "";
            cb_nama_supplier.Text = "";
            tb_harga_modal.Text = "";
            tb_harga_jual.Text = "";
            txt_satuan1.Text = "";
            txt_satuan2.Text = "";
        }

        private void btn_data_baru_Click(object sender, EventArgs e)
        {
            modeTambah = true;

            // generate kode obat
            SqlCommand KodeObat = new SqlCommand("SELECT kode_obat FROM Obat_apotek order by right(kode_obat, 3)", conn);

            conn.Open();
            SqlDataReader kodeObatList = KodeObat.ExecuteReader();

            while (kodeObatList.Read())
            {
                id = int.Parse(kodeObatList.GetValue(0).ToString().Replace("OBT-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_obat_fix = "OBT-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_obat_fix = "OBT-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_obat_fix = "OBT-" + (id + 1).ToString();
            }

            dgv_data_obat.Enabled = false;

            Reset();

            btn_batal.Enabled = true;
            btn_simpan.Enabled = true;

            btn_data_baru.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;

            tb_nama_obat.Enabled = true;
            tb_jumlah_stok.Enabled = true;
            cb_satuan.Enabled = true;
            cb_nama_supplier.Enabled = true;
            tb_harga_modal.Enabled = true;
            tb_harga_jual.Enabled = true;

            tb_kode_obat.Text = id_obat_fix;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (modeTambah)
            {
                if (!String.IsNullOrEmpty(tb_nama_obat.Text) && !String.IsNullOrEmpty(tb_jumlah_stok.Text) && !String.IsNullOrEmpty(cb_satuan.Text) && !String.IsNullOrEmpty(cb_nama_supplier.Text) && !String.IsNullOrEmpty(tb_harga_modal.Text) && !String.IsNullOrEmpty(tb_harga_jual.Text))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Obat_apotek VALUES (@kode_obat, @nama_obat, @nama_supplier, @satuan_obat, @harga_obat, @jumlah_stok, @harga_modal)", conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@kode_obat", id_obat_fix);
                    cmd.Parameters.AddWithValue("@nama_obat", tb_nama_obat.Text);
                    cmd.Parameters.AddWithValue("@nama_supplier", cb_nama_supplier.Text);
                    cmd.Parameters.AddWithValue("@satuan_obat", cb_satuan.Text);
                    cmd.Parameters.AddWithValue("@harga_obat", int.Parse(tb_harga_jual.Text));
                    cmd.Parameters.AddWithValue("@jumlah_stok", int.Parse(tb_jumlah_stok.Text));
                    cmd.Parameters.AddWithValue("@harga_modal", int.Parse(tb_harga_modal.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    modeTambah = false;

                    btn_batal.Enabled = false;
                    btn_simpan.Enabled = false;

                    btn_data_baru.Enabled = true;
                    btn_edit.Enabled = true;
                    btn_hapus.Enabled = true;

                    tb_nama_obat.Enabled = false;
                    tb_jumlah_stok.Enabled = false;
                    cb_satuan.Enabled = false;
                    cb_nama_supplier.Enabled = false;
                    tb_harga_modal.Enabled = false;
                    tb_harga_jual.Enabled = false;

                    Reset();

                    dgv_data_obat.Enabled = true;

                    TampilData();
                }
                else
                {
                    MessageBox.Show("Harap isi kolom yang kosong!");
                }
            } 
            else if (modeEdit) 
            {
                if (!String.IsNullOrEmpty(tb_nama_obat.Text) && !String.IsNullOrEmpty(tb_jumlah_stok.Text) && !String.IsNullOrEmpty(cb_satuan.Text) && !String.IsNullOrEmpty(cb_nama_supplier.Text) && !String.IsNullOrEmpty(tb_harga_modal.Text) && !String.IsNullOrEmpty(tb_harga_jual.Text))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Obat_apotek SET nama_obat = @nama_obat, nama_supplier = @nama_supplier, satuan_obat = @satuan_obat, harga_obat = @harga_obat, jumlah_stok = @jumlah_stok, harga_modal = @harga_modal WHERE kode_obat = @kode_obat", conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@kode_obat", tb_kode_obat.Text);
                    cmd.Parameters.AddWithValue("@nama_obat", tb_nama_obat.Text);
                    cmd.Parameters.AddWithValue("@nama_supplier", cb_nama_supplier.Text);
                    cmd.Parameters.AddWithValue("@satuan_obat", cb_satuan.Text);
                    cmd.Parameters.AddWithValue("@harga_obat", int.Parse(tb_harga_jual.Text));
                    cmd.Parameters.AddWithValue("@jumlah_stok", int.Parse(tb_jumlah_stok.Text));
                    cmd.Parameters.AddWithValue("@harga_modal", int.Parse(tb_harga_modal.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    modeEdit = false;

                    btn_batal.Enabled = false;
                    btn_simpan.Enabled = false;

                    btn_data_baru.Enabled = true;
                    btn_edit.Enabled = true;
                    btn_hapus.Enabled = true;

                    tb_nama_obat.Enabled = false;
                    tb_jumlah_stok.Enabled = false;
                    cb_satuan.Enabled = false;
                    cb_nama_supplier.Enabled = false;
                    tb_harga_modal.Enabled = false;
                    tb_harga_jual.Enabled = false;

                    Reset();

                    dgv_data_obat.Enabled = true;

                    TampilData();
                }
                else
                {
                    MessageBox.Show("Harap isi kolom yang kosong!");
                }
            }
        }

        private void Form_Obat_Load(object sender, EventArgs e)
        {

        }

        private void cb_satuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(cb_satuan.Text))
            {
                txt_satuan1.Text = "Per / " + cb_satuan.Text;
                txt_satuan2.Text = "Per / " + cb_satuan.Text;
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            modeEdit = false;
            modeTambah = false;

            Reset();

            dgv_data_obat.Enabled = true;

            btn_batal.Enabled = false;
            btn_simpan.Enabled = false;

            btn_data_baru.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;

            tb_nama_obat.Enabled = false;
            tb_jumlah_stok.Enabled = false;
            cb_satuan.Enabled = false;
            cb_nama_supplier.Enabled = false;
            tb_harga_modal.Enabled = false;
            tb_harga_jual.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tb_kode_obat.Text))
            {
                modeEdit = true;

                btn_batal.Enabled = true;
                btn_simpan.Enabled = true;

                btn_data_baru.Enabled = false;
                btn_edit.Enabled = false;
                btn_hapus.Enabled = false;

                tb_nama_obat.Enabled = true;
                tb_jumlah_stok.Enabled = true;
                cb_satuan.Enabled = true;
                cb_nama_supplier.Enabled = true;
                tb_harga_modal.Enabled = true;
                tb_harga_jual.Enabled = true;

            }

        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_kode_obat.Text))
            {
                if (MessageBox.Show("Yakin ingin menghapus data?", "Peringatan!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Obat_apotek WHERE kode_obat = @kode_obat", conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@kode_obat", tb_kode_obat.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Reset();

                    TampilData();
                }
            }
        }

        private void tb_jumlah_stok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
