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
    public partial class Form_Login : Form
    {
        protected Form_Home callingForm;

        SqlConnection conn = new SqlConnection(Connection.conn);
        private Form_Home form_Home;

        public Form_Login(Form_Home form_Home)
        {
            callingForm = form_Home;
            InitializeComponent();
        }

        //fungsi untuk menchipher password
        private string chipher(string value, int shift)
        {
            string[] joinChipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');

            try
            {
                for (int x = 0; x < wordArray.Length; x++)
                {
                    char[] buffer = wordArray[x].ToCharArray();
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        char letter = buffer[i];
                        letter = (char)(letter + shift);

                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        buffer[i] = letter;
                    }
                    string hasilkonversi = new string(buffer);
                    joinChipher[x] = hasilkonversi;
                }
                joinText = string.Join("", joinChipher);
                return joinText;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        //fungsi menthod login
        private void btn_login_Click(object sender, EventArgs e)
        {
            string tekschiper = null;
            tekschiper = chipher(tb_password.Text, 17);

            SqlCommand cmd = new SqlCommand("SELECT * FROM User_apotek WHERE username = '" + tb_username.Text + "' and password ='" + tekschiper + "'", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            if (dt.Rows.Count == 1)
            {
                callingForm.isLogin = true;
                MessageBox.Show("Login Berhasil");
                Close();
            }
            else
            {
                MessageBox.Show("Masukkan username dan password dengan benar");
                tb_username.Text = "";
                tb_password.Text = "";
                tb_username.Focus();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
           
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
