namespace Apotek
{
    partial class Form_Penjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Penjualan));
            this.dgv_daftar_penjualan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_total_pembayaran = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_no_trans = new System.Windows.Forms.TextBox();
            this.tb_tgl_trans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nama_obat = new System.Windows.Forms.TextBox();
            this.tb_harga_obat = new System.Windows.Forms.TextBox();
            this.tb_jumlah_obat = new System.Windows.Forms.TextBox();
            this.tb_satuan_obat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_kembalian = new System.Windows.Forms.Label();
            this.btn_riwayat_penjualan = new System.Windows.Forms.Button();
            this.time_picker = new System.Windows.Forms.DateTimePicker();
            this.tb_kode_obat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_kembalian = new System.Windows.Forms.TextBox();
            this.tb_bayar = new System.Windows.Forms.TextBox();
            this.tb_total_bayar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_hapus_data = new System.Windows.Forms.Button();
            this.btn_data_baru = new System.Windows.Forms.Button();
            this.btn_pilih_obat = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daftar_penjualan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_daftar_penjualan
            // 
            this.dgv_daftar_penjualan.AllowUserToAddRows = false;
            this.dgv_daftar_penjualan.AllowUserToDeleteRows = false;
            this.dgv_daftar_penjualan.AllowUserToResizeColumns = false;
            this.dgv_daftar_penjualan.AllowUserToResizeRows = false;
            this.dgv_daftar_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_daftar_penjualan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_daftar_penjualan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_daftar_penjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_daftar_penjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_daftar_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_daftar_penjualan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_daftar_penjualan.Location = new System.Drawing.Point(-2, 375);
            this.dgv_daftar_penjualan.MultiSelect = false;
            this.dgv_daftar_penjualan.Name = "dgv_daftar_penjualan";
            this.dgv_daftar_penjualan.ReadOnly = true;
            this.dgv_daftar_penjualan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_daftar_penjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_daftar_penjualan.Size = new System.Drawing.Size(1365, 330);
            this.dgv_daftar_penjualan.TabIndex = 0;
            this.dgv_daftar_penjualan.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_daftar_penjualan_RowsAdded);
            this.dgv_daftar_penjualan.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_daftar_penjualan_RowsRemoved);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_total_pembayaran);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(944, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 136);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uang Pembayaran";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_total_pembayaran
            // 
            this.txt_total_pembayaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            this.txt_total_pembayaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_total_pembayaran.ForeColor = System.Drawing.Color.White;
            this.txt_total_pembayaran.Location = new System.Drawing.Point(3, 19);
            this.txt_total_pembayaran.Name = "txt_total_pembayaran";
            this.txt_total_pembayaran.Size = new System.Drawing.Size(306, 114);
            this.txt_total_pembayaran.TabIndex = 0;
            this.txt_total_pembayaran.Text = "Rp.0,-";
            this.txt_total_pembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(42, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Transaksi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Transaksi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(42, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kode Obat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_no_trans
            // 
            this.tb_no_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_no_trans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_no_trans.Enabled = false;
            this.tb_no_trans.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_no_trans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_no_trans.Location = new System.Drawing.Point(176, 69);
            this.tb_no_trans.Multiline = true;
            this.tb_no_trans.Name = "tb_no_trans";
            this.tb_no_trans.Size = new System.Drawing.Size(224, 21);
            this.tb_no_trans.TabIndex = 4;
            // 
            // tb_tgl_trans
            // 
            this.tb_tgl_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_tgl_trans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tgl_trans.Enabled = false;
            this.tb_tgl_trans.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tgl_trans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_tgl_trans.Location = new System.Drawing.Point(176, 108);
            this.tb_tgl_trans.Multiline = true;
            this.tb_tgl_trans.Name = "tb_tgl_trans";
            this.tb_tgl_trans.Size = new System.Drawing.Size(224, 21);
            this.tb_tgl_trans.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(42, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nama Obat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(42, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga Obat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(42, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Jumlah";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(42, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Satuan";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_nama_obat
            // 
            this.tb_nama_obat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_nama_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nama_obat.Enabled = false;
            this.tb_nama_obat.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nama_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_nama_obat.Location = new System.Drawing.Point(176, 186);
            this.tb_nama_obat.Multiline = true;
            this.tb_nama_obat.Name = "tb_nama_obat";
            this.tb_nama_obat.Size = new System.Drawing.Size(224, 21);
            this.tb_nama_obat.TabIndex = 11;
            // 
            // tb_harga_obat
            // 
            this.tb_harga_obat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_harga_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_harga_obat.Enabled = false;
            this.tb_harga_obat.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_harga_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_harga_obat.Location = new System.Drawing.Point(176, 232);
            this.tb_harga_obat.Multiline = true;
            this.tb_harga_obat.Name = "tb_harga_obat";
            this.tb_harga_obat.Size = new System.Drawing.Size(224, 21);
            this.tb_harga_obat.TabIndex = 12;
            // 
            // tb_jumlah_obat
            // 
            this.tb_jumlah_obat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_jumlah_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_jumlah_obat.Enabled = false;
            this.tb_jumlah_obat.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jumlah_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_jumlah_obat.Location = new System.Drawing.Point(176, 277);
            this.tb_jumlah_obat.Multiline = true;
            this.tb_jumlah_obat.Name = "tb_jumlah_obat";
            this.tb_jumlah_obat.Size = new System.Drawing.Size(224, 21);
            this.tb_jumlah_obat.TabIndex = 13;
            this.tb_jumlah_obat.TextChanged += new System.EventHandler(this.tb_jumlah_obat_TextChanged);
            this.tb_jumlah_obat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_jumlah_obat_KeyPress);
            // 
            // tb_satuan_obat
            // 
            this.tb_satuan_obat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_satuan_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_satuan_obat.Enabled = false;
            this.tb_satuan_obat.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_satuan_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_satuan_obat.Location = new System.Drawing.Point(176, 320);
            this.tb_satuan_obat.Multiline = true;
            this.tb_satuan_obat.Name = "tb_satuan_obat";
            this.tb_satuan_obat.Size = new System.Drawing.Size(224, 21);
            this.tb_satuan_obat.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_kembalian);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(512, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 136);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kembalian";
            // 
            // txt_kembalian
            // 
            this.txt_kembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            this.txt_kembalian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_kembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_kembalian.ForeColor = System.Drawing.Color.White;
            this.txt_kembalian.Location = new System.Drawing.Point(3, 19);
            this.txt_kembalian.Name = "txt_kembalian";
            this.txt_kembalian.Size = new System.Drawing.Size(306, 114);
            this.txt_kembalian.TabIndex = 1;
            this.txt_kembalian.Text = "Rp.0,-";
            this.txt_kembalian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_riwayat_penjualan
            // 
            this.btn_riwayat_penjualan.BackgroundImage = global::Apotek.Properties.Resources.home_button_2;
            this.btn_riwayat_penjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_riwayat_penjualan.FlatAppearance.BorderSize = 0;
            this.btn_riwayat_penjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_riwayat_penjualan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_riwayat_penjualan.ForeColor = System.Drawing.Color.White;
            this.btn_riwayat_penjualan.Location = new System.Drawing.Point(928, 312);
            this.btn_riwayat_penjualan.Name = "btn_riwayat_penjualan";
            this.btn_riwayat_penjualan.Size = new System.Drawing.Size(344, 30);
            this.btn_riwayat_penjualan.TabIndex = 23;
            this.btn_riwayat_penjualan.Text = "Riwayat Penjualan";
            this.btn_riwayat_penjualan.UseVisualStyleBackColor = true;
            this.btn_riwayat_penjualan.Click += new System.EventHandler(this.btn_riwayat_penjualan_Click);
            // 
            // time_picker
            // 
            this.time_picker.Enabled = false;
            this.time_picker.Location = new System.Drawing.Point(408, 108);
            this.time_picker.Name = "time_picker";
            this.time_picker.Size = new System.Drawing.Size(20, 20);
            this.time_picker.TabIndex = 24;
            this.time_picker.ValueChanged += new System.EventHandler(this.time_picker_ValueChanged);
            // 
            // tb_kode_obat
            // 
            this.tb_kode_obat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_kode_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kode_obat.Enabled = false;
            this.tb_kode_obat.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kode_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_kode_obat.Location = new System.Drawing.Point(176, 146);
            this.tb_kode_obat.Multiline = true;
            this.tb_kode_obat.Name = "tb_kode_obat";
            this.tb_kode_obat.Size = new System.Drawing.Size(224, 21);
            this.tb_kode_obat.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.tb_kembalian);
            this.groupBox3.Controls.Add(this.tb_bayar);
            this.groupBox3.Controls.Add(this.tb_total_bayar);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox3.Location = new System.Drawing.Point(512, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 128);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Pembayaran";
            // 
            // tb_kembalian
            // 
            this.tb_kembalian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kembalian.Enabled = false;
            this.tb_kembalian.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kembalian.Location = new System.Drawing.Point(128, 96);
            this.tb_kembalian.Name = "tb_kembalian";
            this.tb_kembalian.Size = new System.Drawing.Size(168, 14);
            this.tb_kembalian.TabIndex = 5;
            this.tb_kembalian.TextChanged += new System.EventHandler(this.tb_kembalian_TextChanged);
            // 
            // tb_bayar
            // 
            this.tb_bayar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_bayar.Enabled = false;
            this.tb_bayar.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bayar.Location = new System.Drawing.Point(128, 64);
            this.tb_bayar.Name = "tb_bayar";
            this.tb_bayar.Size = new System.Drawing.Size(168, 14);
            this.tb_bayar.TabIndex = 4;
            this.tb_bayar.TextChanged += new System.EventHandler(this.tb_bayar_TextChanged);
            this.tb_bayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_bayar_KeyPress);
            // 
            // tb_total_bayar
            // 
            this.tb_total_bayar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_total_bayar.Enabled = false;
            this.tb_total_bayar.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_bayar.Location = new System.Drawing.Point(128, 32);
            this.tb_total_bayar.Name = "tb_total_bayar";
            this.tb_total_bayar.Size = new System.Drawing.Size(168, 14);
            this.tb_total_bayar.TabIndex = 3;
            this.tb_total_bayar.TextChanged += new System.EventHandler(this.tb_total_bayar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label12.Location = new System.Drawing.Point(16, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Kembalian";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(16, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bayar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(16, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Bayar Rp.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btn_hapus_data
            // 
            this.btn_hapus_data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hapus_data.BackgroundImage")));
            this.btn_hapus_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hapus_data.FlatAppearance.BorderSize = 0;
            this.btn_hapus_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus_data.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus_data.ForeColor = System.Drawing.Color.White;
            this.btn_hapus_data.Location = new System.Drawing.Point(1168, 208);
            this.btn_hapus_data.Name = "btn_hapus_data";
            this.btn_hapus_data.Size = new System.Drawing.Size(100, 30);
            this.btn_hapus_data.TabIndex = 28;
            this.btn_hapus_data.Text = "Hapus Data";
            this.btn_hapus_data.UseVisualStyleBackColor = true;
            this.btn_hapus_data.Click += new System.EventHandler(this.btn_hapus_data_Click);
            // 
            // btn_data_baru
            // 
            this.btn_data_baru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_data_baru.BackgroundImage")));
            this.btn_data_baru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_data_baru.FlatAppearance.BorderSize = 0;
            this.btn_data_baru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data_baru.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_baru.ForeColor = System.Drawing.Color.White;
            this.btn_data_baru.Location = new System.Drawing.Point(928, 208);
            this.btn_data_baru.Name = "btn_data_baru";
            this.btn_data_baru.Size = new System.Drawing.Size(100, 30);
            this.btn_data_baru.TabIndex = 27;
            this.btn_data_baru.Text = "Data Baru";
            this.btn_data_baru.UseVisualStyleBackColor = true;
            this.btn_data_baru.Click += new System.EventHandler(this.btn_data_baru_Click);
            // 
            // btn_pilih_obat
            // 
            this.btn_pilih_obat.BackgroundImage = global::Apotek.Properties.Resources.kasir_button_sampah_copy;
            this.btn_pilih_obat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pilih_obat.Enabled = false;
            this.btn_pilih_obat.FlatAppearance.BorderSize = 0;
            this.btn_pilih_obat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pilih_obat.Location = new System.Drawing.Point(409, 144);
            this.btn_pilih_obat.Name = "btn_pilih_obat";
            this.btn_pilih_obat.Size = new System.Drawing.Size(30, 25);
            this.btn_pilih_obat.TabIndex = 26;
            this.btn_pilih_obat.UseVisualStyleBackColor = true;
            this.btn_pilih_obat.Click += new System.EventHandler(this.btn_pilih_obat_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.BackgroundImage = global::Apotek.Properties.Resources.home_button_2;
            this.btn_batal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_batal.Enabled = false;
            this.btn_batal.FlatAppearance.BorderSize = 0;
            this.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal.ForeColor = System.Drawing.Color.White;
            this.btn_batal.Location = new System.Drawing.Point(928, 264);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(344, 30);
            this.btn_batal.TabIndex = 21;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_simpan.BackgroundImage")));
            this.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_simpan.Enabled = false;
            this.btn_simpan.FlatAppearance.BorderSize = 0;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(1048, 208);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(100, 30);
            this.btn_simpan.TabIndex = 20;
            this.btn_simpan.Text = "Simpan Data";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackgroundImage = global::Apotek.Properties.Resources.kasir_button_sampah;
            this.btn_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Location = new System.Drawing.Point(80, 16);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(30, 30);
            this.btn_hapus.TabIndex = 16;
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.Transparent;
            this.btn_tambah.BackgroundImage = global::Apotek.Properties.Resources._1_kasir_button_add;
            this.btn_tambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.Location = new System.Drawing.Point(40, 16);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(30, 30);
            this.btn_tambah.TabIndex = 15;
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // Form_Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 690);
            this.Controls.Add(this.btn_hapus_data);
            this.Controls.Add(this.btn_data_baru);
            this.Controls.Add(this.btn_pilih_obat);
            this.Controls.Add(this.tb_kode_obat);
            this.Controls.Add(this.time_picker);
            this.Controls.Add(this.btn_riwayat_penjualan);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.tb_satuan_obat);
            this.Controls.Add(this.tb_jumlah_obat);
            this.Controls.Add(this.tb_harga_obat);
            this.Controls.Add(this.tb_nama_obat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tgl_trans);
            this.Controls.Add(this.tb_no_trans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_daftar_penjualan);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Penjualan";
            this.Text = "Form_Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daftar_penjualan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_daftar_penjualan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_no_trans;
        private System.Windows.Forms.TextBox tb_tgl_trans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nama_obat;
        private System.Windows.Forms.TextBox tb_harga_obat;
        private System.Windows.Forms.TextBox tb_jumlah_obat;
        private System.Windows.Forms.TextBox tb_satuan_obat;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_kembalian;
        private System.Windows.Forms.TextBox tb_bayar;
        private System.Windows.Forms.TextBox tb_total_bayar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_riwayat_penjualan;
        private System.Windows.Forms.Label txt_total_pembayaran;
        private System.Windows.Forms.DateTimePicker time_picker;
        private System.Windows.Forms.TextBox tb_kode_obat;
        private System.Windows.Forms.Button btn_pilih_obat;
        private System.Windows.Forms.Label txt_kembalian;
        private System.Windows.Forms.Button btn_data_baru;
        private System.Windows.Forms.Button btn_hapus_data;


    }
}