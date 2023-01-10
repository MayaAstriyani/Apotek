using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek
{
    public partial class Form_Home : Form
    {

        public bool isLogin { get; set; }

        public Form_Home()
        {
            InitializeComponent();
        }

        private void fHome_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login(this);
            form_Login.FormClosed += Form_LoginClosed;
            form_Login.ShowDialog();
        }

        private void Form_LoginClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogin)
            {
                btn_kasir.Enabled = true;
                btn_data_obat.Enabled = true;
                btn_data_user.Enabled = true;
                btn_data_supplier.Enabled = true;

                btn_login_utama.Enabled = false;
            }
        }

        private void btn_kasir_Click(object sender, EventArgs e)
        {
            Form_Penjualan penjualan = new Form_Penjualan();
            penjualan.ShowDialog();
        }

        private void btn_datasupplier_Click(object sender, EventArgs e)
        {
            Form_Supplier supplier = new Form_Supplier();
            supplier.ShowDialog();
        }

        private void btn_dataobat_Click(object sender, EventArgs e)
        {
            Form_Obat obat = new Form_Obat();
            obat.ShowDialog();
        }

        private void btn_datauser_Click(object sender, EventArgs e)
        {
            Form_User user = new Form_User();
            user.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
