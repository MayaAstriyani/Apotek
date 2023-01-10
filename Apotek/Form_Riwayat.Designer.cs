namespace Apotek
{
    partial class Form_Riwayat
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_no_transaksi = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.dgv_riwayat_penjualan = new System.Windows.Forms.DataGridView();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_riwayat_penjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            // 
            // cb_filter
            // 
            this.cb_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.cb_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filter.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Semua",
            "Berdasarkan Nomor Transaksi",
            "Berdasarkan Tanggal"});
            this.cb_filter.Location = new System.Drawing.Point(200, 16);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(184, 22);
            this.cb_filter.TabIndex = 1;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_no_transaksi
            // 
            this.tb_no_transaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.tb_no_transaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_no_transaksi.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_no_transaksi.Location = new System.Drawing.Point(200, 64);
            this.tb_no_transaksi.Multiline = true;
            this.tb_no_transaksi.Name = "tb_no_transaksi";
            this.tb_no_transaksi.Size = new System.Drawing.Size(184, 22);
            this.tb_no_transaksi.TabIndex = 3;
            this.tb_no_transaksi.TextChanged += new System.EventHandler(this.tb_no_transaksi_TextChanged);
            // 
            // btn_cari
            // 
            this.btn_cari.BackgroundImage = global::Apotek.Properties.Resources.home_button;
            this.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cari.FlatAppearance.BorderSize = 0;
            this.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.ForeColor = System.Drawing.Color.White;
            this.btn_cari.Location = new System.Drawing.Point(616, 64);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(100, 30);
            this.btn_cari.TabIndex = 4;
            this.btn_cari.Text = "CARI";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // dgv_riwayat_penjualan
            // 
            this.dgv_riwayat_penjualan.AllowUserToAddRows = false;
            this.dgv_riwayat_penjualan.AllowUserToDeleteRows = false;
            this.dgv_riwayat_penjualan.AllowUserToResizeColumns = false;
            this.dgv_riwayat_penjualan.AllowUserToResizeRows = false;
            this.dgv_riwayat_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_riwayat_penjualan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_riwayat_penjualan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_riwayat_penjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_riwayat_penjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_riwayat_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(96)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_riwayat_penjualan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_riwayat_penjualan.Location = new System.Drawing.Point(0, 104);
            this.dgv_riwayat_penjualan.Name = "dgv_riwayat_penjualan";
            this.dgv_riwayat_penjualan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_riwayat_penjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_riwayat_penjualan.Size = new System.Drawing.Size(888, 360);
            this.dgv_riwayat_penjualan.TabIndex = 5;
            this.dgv_riwayat_penjualan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_riwayat_penjualan_CellContentDoubleClick);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CalendarFont = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(616, 16);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(184, 21);
            this.dtpTanggal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Transaksi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form_Riwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.dgv_riwayat_penjualan);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.tb_no_transaksi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Riwayat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Riwayat";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_riwayat_penjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_no_transaksi;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.DataGridView dgv_riwayat_penjualan;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label3;
    }
}