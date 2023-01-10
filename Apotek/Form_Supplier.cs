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
    public partial class Form_Supplier : Form
    {
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(Connection.conn);

        int id;
        string id_supplier_fix;

        bool modeEdit = false;
        bool modeTambah = false;

        public Form_Supplier()
        {
            InitializeComponent();
            TampilData();
        }

        // method binding data
        private void Binding()
        {
            dt.Clear();
            tb_kode_supplier.DataBindings.Clear();
            tb_nama.DataBindings.Clear();
            tb_no_hp.DataBindings.Clear();
            tb_alamat.DataBindings.Clear();

            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Supplier_apotek", conn);
            SqlCommandBuilder scb = new SqlCommandBuilder();

            cmd.Fill(dt);
            bs.DataSource = dt;
            dgv_data_supplier.DataSource = bs;

            tb_kode_supplier.DataBindings.Add("text", bs, "kode_supplier");
            tb_nama.DataBindings.Add("text", bs, "nama_supplier");
            tb_no_hp.DataBindings.Add("text", bs, "nohp_supplier");
            tb_alamat.DataBindings.Add("text", bs, "alamat_supplier");
        }

        //menampilkan data ke dalam datagridview
        private void TampilData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier_apotek order by kode_supplier asc", conn);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader data = cmd.ExecuteReader();
            dt.Load(data);
            conn.Close();

            dgv_data_supplier.DataSource = dt;

            conn.Close();
        }

        //method reset
        private void Reset()
        {
            tb_kode_supplier.Text = "";
            tb_nama.Text = "";
            tb_no_hp.Text = "";
            tb_alamat.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_data_baru_Click(object sender, EventArgs e)
        {
            modeTambah = true;

            SqlCommand KodeSupplier = new SqlCommand("SELECT kode_supplier FROM Supplier_apotek order by right(kode_supplier, 3)", conn);

            conn.Open();
            SqlDataReader kodeSupplierList = KodeSupplier.ExecuteReader();

            //generate kode apotek
            while (kodeSupplierList.Read())
            {
                id = int.Parse(kodeSupplierList.GetValue(0).ToString().Replace("SUP-", ""));
            }

            conn.Close();

            if (id < 9)
            {
                id_supplier_fix = "SUP-00" + (id + 1).ToString();
            }

            else if (id < 99)
            {
                id_supplier_fix = "SUP-0" + (id + 1).ToString();
            }

            else if (id >= 99)
            {
                id_supplier_fix = "SUP-" + (id + 1).ToString();
            }

            dgv_data_supplier.Enabled = false;

            Reset();

            btn_batal.Enabled = true;
            btn_simpan.Enabled = true;

            btn_data_baru.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;

            tb_nama.Enabled = true;
            tb_no_hp.Enabled = true;
            tb_alamat.Enabled = true;

            tb_kode_supplier.Text = id_supplier_fix;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            //simpan data pada saat menmbah
            if (modeTambah)
            {
                if (!String.IsNullOrEmpty(tb_nama.Text) && !String.IsNullOrEmpty(tb_no_hp.Text) && !String.IsNullOrEmpty(tb_alamat.Text)){
                   
                    if (tb_no_hp.Text.Any(char.IsNumber) && !tb_no_hp.Text.Any(char.IsLetter))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Supplier_apotek VALUES (@kode_supplier, @nama_supplier, @alamat_supplier, @no_hp_supplier)", conn);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@kode_supplier", id_supplier_fix);
                        cmd.Parameters.AddWithValue("@nama_supplier", tb_nama.Text);
                        cmd.Parameters.AddWithValue("@no_hp_supplier", tb_no_hp.Text);
                        cmd.Parameters.AddWithValue("@alamat_supplier", tb_alamat.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        modeTambah = false;

                        btn_batal.Enabled = false;
                        btn_simpan.Enabled = false;

                        btn_data_baru.Enabled = true;
                        btn_edit.Enabled = true;
                        btn_hapus.Enabled = true;

                        tb_nama.Enabled = false;
                        tb_no_hp.Enabled = false;
                        tb_alamat.Enabled = false;

                        Reset();

                        dgv_data_supplier.Enabled = true;

                        TampilData();
                        Binding();
                    }

                    else
                    {
                        MessageBox.Show("Harap isi nomor hp dengan angka!", "Peringatan!");
                    }
                }

                else
                {
                    MessageBox.Show("Harap isi kolom yang kosong!");
                }
            } 
            //simpan data pada saat mengedit
            else if (modeEdit)
            {
                if (!String.IsNullOrEmpty(tb_nama.Text) && !String.IsNullOrEmpty(tb_no_hp.Text) && !String.IsNullOrEmpty(tb_alamat.Text))
                {


                    SqlCommand sqlCommand = new SqlCommand("UPDATE Supplier_apotek SET nama_supplier = @nama_supplier, nohp_supplier = @no_hp_supplier, alamat_supplier = @alamat_supplier WHERE kode_supplier = @kode_supplier", conn);
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.Parameters.AddWithValue("@kode_supplier", tb_kode_supplier.Text);
                    sqlCommand.Parameters.AddWithValue("@nama_supplier", tb_nama.Text);
                    sqlCommand.Parameters.AddWithValue("@no_hp_supplier", tb_no_hp.Text);
                    sqlCommand.Parameters.AddWithValue("@alamat_supplier", tb_alamat.Text);

                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();

                    modeEdit = false;

                    btn_batal.Enabled = false;
                    btn_simpan.Enabled = false;

                    btn_data_baru.Enabled = true;
                    btn_edit.Enabled = true;
                    btn_hapus.Enabled = true;

                    tb_nama.Enabled = false;
                    tb_no_hp.Enabled = false;
                    tb_alamat.Enabled = false;

                    Reset();

                    dgv_data_supplier.Enabled = true;

                    TampilData();
                    Binding();
                }
                else
                {
                    MessageBox.Show("Harap isi kolom yang kosong!");
                }
            }

            else
            {
                MessageBox.Show("Masukkan data dengan benar!");
            }
        }

        private void Form_Supplier_Load(object sender, EventArgs e)
        {
            Binding();
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            modeEdit = false;
            modeTambah = false;

            Reset();
            Binding();

            dgv_data_supplier.Enabled = true;

            btn_batal.Enabled = false;
            btn_simpan.Enabled = false;

            btn_data_baru.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;

            tb_nama.Enabled = false;
            tb_no_hp.Enabled = false;
            tb_alamat.Enabled = false;
        }

        //method edit data
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_kode_supplier.Text))
            {
                modeEdit = true;

                btn_batal.Enabled = true;
                btn_simpan.Enabled = true;

                btn_data_baru.Enabled = false;
                btn_edit.Enabled = false;
                btn_hapus.Enabled = false;

                tb_nama.Enabled = true;
                tb_no_hp.Enabled = true;
                tb_alamat.Enabled = true;
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data?", "Peringatan!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Supplier_apotek WHERE kode_supplier = @kode_supplier", conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@kode_supplier", tb_kode_supplier.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                Reset();

                TampilData();
                Binding();
            }
        }
    }
}
