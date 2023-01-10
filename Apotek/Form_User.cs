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
    public partial class Form_User : Form
    {
        SqlConnection conn = new SqlConnection(Connection.conn);

        int id;
        string id_user_fix;

        bool modeEdit = false;
        bool modeTambah = false;

        public Form_User()
        {
            InitializeComponent();
            TampilData();
        }

        //password chiper
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

        private void Form_User_Load(object sender, EventArgs e)
        {
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (modeTambah)
            {
                if (!String.IsNullOrEmpty(tb_username.Text) && !String.IsNullOrEmpty(tb_password.Text))
                {
                    try
                    {
                        string tekschiper = null;
                        tekschiper = chipher(tb_password.Text, 17);

                        SqlCommand cmd = new SqlCommand("INSERT INTO User_Apotek VALUES (@id_user, @username, @password)", conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id_user", id_user_fix);
                        cmd.Parameters.AddWithValue("@username", tb_username.Text);
                        cmd.Parameters.AddWithValue("@password", tekschiper);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        modeTambah = false;

                        btn_batal.Enabled = false;
                        btn_simpan.Enabled = false;

                        btn_data_baru.Enabled = true;
                        btn_edit.Enabled = true;
                        btn_hapus.Enabled = true;

                        tb_username.Enabled = false;
                        tb_password.Enabled = false;

                        Reset();

                        dgv_tabel_user.Enabled = true;

                        TampilData();
                    }
                    catch (Exception eInsertUser)
                    {
                        MessageBox.Show(eInsertUser.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Harap isi kolom yang masih kosong!");
                }
            } 
            
            else if (modeEdit)
            {
                if (!String.IsNullOrEmpty(tb_username.Text) && !String.IsNullOrEmpty(tb_password.Text))
                {
                    try
                    {
                        string tekschiper = null;
                        tekschiper = chipher(tb_password.Text, 17);

                        SqlCommand cmd = new SqlCommand("UPDATE User_apotek SET username = @username, password = @password WHERE id_user = @id_user", conn);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@id_user", tb_kode_user.Text);
                        cmd.Parameters.AddWithValue("@username", tb_username.Text);
                        cmd.Parameters.AddWithValue("@password", tekschiper);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        modeEdit = false;

                        btn_batal.Enabled = false;
                        btn_simpan.Enabled = false;

                        btn_data_baru.Enabled = true;
                        btn_edit.Enabled = true;
                        btn_hapus.Enabled = true;

                        tb_username.Enabled = false;
                        tb_password.Enabled = false;

                        Reset();

                        dgv_tabel_user.Enabled = true;

                        TampilData();
                    }
                    catch (Exception eEditUser)
                    {
                        MessageBox.Show(eEditUser.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Harap isi kolom yang masih kosong!");
                }
            }

            else
            {
                MessageBox.Show("Masukkan data dengan benar!");
            }
        }

        private void TampilData()
        {
            //mengambil data dari database
            SqlCommand cmd = new SqlCommand("SELECT * FROM User_apotek order by id_user asc", conn);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader data = cmd.ExecuteReader();
            dt.Load(data);
            conn.Close();

            dgv_tabel_user.DataSource = dt;

            conn.Close();
        }

        private void Reset()
        {
            tb_kode_user.Text = "";
            tb_username.Text = "";
            tb_password.Text = "";
        }

        private void btn_data_baru_Click(object sender, EventArgs e)
        {
            modeTambah = true;

			SqlCommand KodeUser = new SqlCommand("SELECT id_user FROM User_apotek order by right(id_user, 3)", conn);

			conn.Open();
			SqlDataReader kodeUserList = KodeUser.ExecuteReader();

            //generate kode user
			while (kodeUserList.Read())
			{
				id = int.Parse(kodeUserList.GetValue(0).ToString().Replace("U-", ""));
			}

			conn.Close();

			if (id < 9)
			{
				id_user_fix = "U-00" + (id + 1).ToString();
			}

			else if (id < 99)
			{
				id_user_fix = "U-0" + (id + 1).ToString();
			}

			else if (id >= 99)
			{
				id_user_fix = "U-" + (id + 1).ToString();
			}

			dgv_tabel_user.Enabled = false;

            Reset();

            btn_batal.Enabled = true;
            btn_simpan.Enabled = true;

            btn_data_baru.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;

            tb_username.Enabled = true;
            tb_password.Enabled = true;

            tb_kode_user.Text = id_user_fix;
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_kode_user.Text))
            {
                if (id_user_fix =="U-001")
                {
                    MessageBox.Show("Akun ini tidak dapat dihapus!");
                }

                else
                {
                    if (MessageBox.Show("Yakin ingin menghapus data?", "Peringatan!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM User_apotek WHERE id_user = @id_user", conn);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@id_user", tb_kode_user.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        Reset();

                        TampilData();
                    }
                }
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            modeEdit = false;
            modeTambah = false;

            Reset();

            dgv_tabel_user.Enabled = true;

            btn_batal.Enabled = false;
            btn_simpan.Enabled = false;

            btn_data_baru.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;

            tb_username.Enabled = false;
            tb_password.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_kode_user.Text))
            {
                  
                modeEdit = true;

                btn_batal.Enabled = true;
                btn_simpan.Enabled = true;

                btn_data_baru.Enabled = false;
                btn_edit.Enabled = false;
                btn_hapus.Enabled = false;

                tb_username.Enabled = true;
                tb_password.Enabled = true;
            }
        }

        //menampilkan data
        private void dgv_tabel_user_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgv_tabel_user.SelectedRows.Count >= 1)
            {
                tb_kode_user.Text = dgv_tabel_user.SelectedRows[0].Cells[0].Value.ToString();
                tb_username.Text = dgv_tabel_user.SelectedRows[0].Cells[1].Value.ToString();
                tb_password.Text = dgv_tabel_user.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_kode_user_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
