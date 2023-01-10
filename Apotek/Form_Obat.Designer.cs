namespace Apotek
{
    partial class Form_Obat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Obat));
            this.dgv_data_obat = new System.Windows.Forms.DataGridView();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_kode_obat = new System.Windows.Forms.TextBox();
            this.tb_nama_obat = new System.Windows.Forms.TextBox();
            this.tb_harga_jual = new System.Windows.Forms.TextBox();
            this.tb_harga_modal = new System.Windows.Forms.TextBox();
            this.tb_jumlah_stok = new System.Windows.Forms.TextBox();
            this.cb_nama_supplier = new System.Windows.Forms.ComboBox();
            this.cb_satuan = new System.Windows.Forms.ComboBox();
            this.btn_data_baru = new System.Windows.Forms.Button();
            this.txt_satuan1 = new System.Windows.Forms.Label();
            this.txt_satuan2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_obat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_data_obat
            // 
            this.dgv_data_obat.AllowUserToAddRows = false;
            this.dgv_data_obat.AllowUserToDeleteRows = false;
            this.dgv_data_obat.AllowUserToResizeColumns = false;
            this.dgv_data_obat.AllowUserToResizeRows = false;
            this.dgv_data_obat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data_obat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_data_obat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_obat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data_obat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_data_obat.Location = new System.Drawing.Point(1, 336);
            this.dgv_data_obat.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_data_obat.MultiSelect = false;
            this.dgv_data_obat.Name = "dgv_data_obat";
            this.dgv_data_obat.ReadOnly = true;
            this.dgv_data_obat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data_obat.Size = new System.Drawing.Size(1200, 698);
            this.dgv_data_obat.TabIndex = 1;
            this.dgv_data_obat.SelectionChanged += new System.EventHandler(this.dgv_data_obat_SelectionChanged);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hapus.BackgroundImage")));
            this.btn_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.Location = new System.Drawing.Point(920, 205);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(133, 42);
            this.btn_hapus.TabIndex = 20;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(739, 205);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 42);
            this.btn_edit.TabIndex = 19;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_batal.BackgroundImage")));
            this.btn_batal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_batal.Enabled = false;
            this.btn_batal.FlatAppearance.BorderSize = 0;
            this.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal.ForeColor = System.Drawing.Color.White;
            this.btn_batal.Location = new System.Drawing.Point(920, 138);
            this.btn_batal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(133, 42);
            this.btn_batal.TabIndex = 18;
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
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(739, 138);
            this.btn_simpan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(133, 42);
            this.btn_simpan.TabIndex = 17;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kode Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nama Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Jumlah Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nama Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Harga Modal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Harga Jual";
            // 
            // tb_kode_obat
            // 
            this.tb_kode_obat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_kode_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kode_obat.Enabled = false;
            this.tb_kode_obat.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kode_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_kode_obat.Location = new System.Drawing.Point(150, 49);
            this.tb_kode_obat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_kode_obat.Multiline = true;
            this.tb_kode_obat.Name = "tb_kode_obat";
            this.tb_kode_obat.Size = new System.Drawing.Size(248, 21);
            this.tb_kode_obat.TabIndex = 27;
            // 
            // tb_nama_obat
            // 
            this.tb_nama_obat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_nama_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nama_obat.Enabled = false;
            this.tb_nama_obat.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nama_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_nama_obat.Location = new System.Drawing.Point(150, 91);
            this.tb_nama_obat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nama_obat.Multiline = true;
            this.tb_nama_obat.Name = "tb_nama_obat";
            this.tb_nama_obat.Size = new System.Drawing.Size(248, 21);
            this.tb_nama_obat.TabIndex = 28;
            // 
            // tb_harga_jual
            // 
            this.tb_harga_jual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_harga_jual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_harga_jual.Enabled = false;
            this.tb_harga_jual.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_harga_jual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_harga_jual.Location = new System.Drawing.Point(152, 256);
            this.tb_harga_jual.Margin = new System.Windows.Forms.Padding(4);
            this.tb_harga_jual.Multiline = true;
            this.tb_harga_jual.Name = "tb_harga_jual";
            this.tb_harga_jual.Size = new System.Drawing.Size(248, 21);
            this.tb_harga_jual.TabIndex = 30;
            // 
            // tb_harga_modal
            // 
            this.tb_harga_modal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_harga_modal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_harga_modal.Enabled = false;
            this.tb_harga_modal.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_harga_modal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_harga_modal.Location = new System.Drawing.Point(152, 216);
            this.tb_harga_modal.Margin = new System.Windows.Forms.Padding(4);
            this.tb_harga_modal.Multiline = true;
            this.tb_harga_modal.Name = "tb_harga_modal";
            this.tb_harga_modal.Size = new System.Drawing.Size(248, 21);
            this.tb_harga_modal.TabIndex = 29;
            // 
            // tb_jumlah_stok
            // 
            this.tb_jumlah_stok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_jumlah_stok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_jumlah_stok.Enabled = false;
            this.tb_jumlah_stok.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jumlah_stok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_jumlah_stok.Location = new System.Drawing.Point(152, 136);
            this.tb_jumlah_stok.Margin = new System.Windows.Forms.Padding(4);
            this.tb_jumlah_stok.Multiline = true;
            this.tb_jumlah_stok.Name = "tb_jumlah_stok";
            this.tb_jumlah_stok.Size = new System.Drawing.Size(112, 21);
            this.tb_jumlah_stok.TabIndex = 31;
            this.tb_jumlah_stok.TextChanged += new System.EventHandler(this.tb_jumlah_stok_TextChanged);
            // 
            // cb_nama_supplier
            // 
            this.cb_nama_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_nama_supplier.Enabled = false;
            this.cb_nama_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_nama_supplier.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nama_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.cb_nama_supplier.FormattingEnabled = true;
            this.cb_nama_supplier.Location = new System.Drawing.Point(152, 176);
            this.cb_nama_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.cb_nama_supplier.Name = "cb_nama_supplier";
            this.cb_nama_supplier.Size = new System.Drawing.Size(248, 22);
            this.cb_nama_supplier.TabIndex = 32;
            // 
            // cb_satuan
            // 
            this.cb_satuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_satuan.Enabled = false;
            this.cb_satuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_satuan.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_satuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.cb_satuan.FormattingEnabled = true;
            this.cb_satuan.Items.AddRange(new object[] {
            "Pcs",
            "Kapsul",
            "Botol"});
            this.cb_satuan.Location = new System.Drawing.Point(288, 136);
            this.cb_satuan.Margin = new System.Windows.Forms.Padding(4);
            this.cb_satuan.Name = "cb_satuan";
            this.cb_satuan.Size = new System.Drawing.Size(110, 22);
            this.cb_satuan.TabIndex = 33;
            this.cb_satuan.SelectedIndexChanged += new System.EventHandler(this.cb_satuan_SelectedIndexChanged);
            // 
            // btn_data_baru
            // 
            this.btn_data_baru.BackgroundImage = global::Apotek.Properties.Resources.home_button_2;
            this.btn_data_baru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_data_baru.FlatAppearance.BorderSize = 0;
            this.btn_data_baru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data_baru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_baru.ForeColor = System.Drawing.Color.White;
            this.btn_data_baru.Location = new System.Drawing.Point(728, 72);
            this.btn_data_baru.Margin = new System.Windows.Forms.Padding(4);
            this.btn_data_baru.Name = "btn_data_baru";
            this.btn_data_baru.Size = new System.Drawing.Size(331, 42);
            this.btn_data_baru.TabIndex = 34;
            this.btn_data_baru.Text = "Data Baru";
            this.btn_data_baru.UseVisualStyleBackColor = true;
            this.btn_data_baru.Click += new System.EventHandler(this.btn_data_baru_Click);
            // 
            // txt_satuan1
            // 
            this.txt_satuan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            this.txt_satuan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_satuan1.ForeColor = System.Drawing.Color.White;
            this.txt_satuan1.Location = new System.Drawing.Point(416, 216);
            this.txt_satuan1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_satuan1.Name = "txt_satuan1";
            this.txt_satuan1.Size = new System.Drawing.Size(116, 21);
            this.txt_satuan1.TabIndex = 35;
            this.txt_satuan1.Text = "Per / Botol";
            // 
            // txt_satuan2
            // 
            this.txt_satuan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            this.txt_satuan2.ForeColor = System.Drawing.Color.White;
            this.txt_satuan2.Location = new System.Drawing.Point(416, 256);
            this.txt_satuan2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_satuan2.Name = "txt_satuan2";
            this.txt_satuan2.Size = new System.Drawing.Size(116, 21);
            this.txt_satuan2.TabIndex = 36;
            this.txt_satuan2.Text = "Per / Botol";
            // 
            // Form_Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 749);
            this.Controls.Add(this.txt_satuan2);
            this.Controls.Add(this.txt_satuan1);
            this.Controls.Add(this.btn_data_baru);
            this.Controls.Add(this.cb_satuan);
            this.Controls.Add(this.cb_nama_supplier);
            this.Controls.Add(this.tb_jumlah_stok);
            this.Controls.Add(this.tb_harga_jual);
            this.Controls.Add(this.tb_harga_modal);
            this.Controls.Add(this.tb_nama_obat);
            this.Controls.Add(this.tb_kode_obat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.dgv_data_obat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Obat";
            this.Load += new System.EventHandler(this.Form_Obat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_obat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data_obat;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_kode_obat;
        private System.Windows.Forms.TextBox tb_nama_obat;
        private System.Windows.Forms.TextBox tb_harga_jual;
        private System.Windows.Forms.TextBox tb_harga_modal;
        private System.Windows.Forms.TextBox tb_jumlah_stok;
        private System.Windows.Forms.ComboBox cb_nama_supplier;
        private System.Windows.Forms.ComboBox cb_satuan;
        private System.Windows.Forms.Button btn_data_baru;
        private System.Windows.Forms.Label txt_satuan1;
        private System.Windows.Forms.Label txt_satuan2;
    }
}