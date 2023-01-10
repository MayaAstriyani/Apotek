namespace Apotek
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_data_user = new System.Windows.Forms.Button();
            this.btn_data_obat = new System.Windows.Forms.Button();
            this.btn_data_supplier = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kasir = new System.Windows.Forms.Button();
            this.btn_login_utama = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 336);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 337);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_data_user);
            this.groupBox1.Controls.Add(this.btn_data_obat);
            this.groupBox1.Controls.Add(this.btn_data_supplier);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_data_user
            // 
            this.btn_data_user.BackColor = System.Drawing.Color.White;
            this.btn_data_user.BackgroundImage = global::Apotek.Properties.Resources.home_icon_user;
            this.btn_data_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_data_user.Enabled = false;
            this.btn_data_user.FlatAppearance.BorderSize = 0;
            this.btn_data_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data_user.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(184)))));
            this.btn_data_user.Location = new System.Drawing.Point(560, 16);
            this.btn_data_user.Name = "btn_data_user";
            this.btn_data_user.Size = new System.Drawing.Size(200, 200);
            this.btn_data_user.TabIndex = 2;
            this.btn_data_user.Text = "Data User";
            this.btn_data_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_data_user.UseVisualStyleBackColor = false;
            this.btn_data_user.Click += new System.EventHandler(this.btn_datauser_Click);
            // 
            // btn_data_obat
            // 
            this.btn_data_obat.BackColor = System.Drawing.Color.White;
            this.btn_data_obat.BackgroundImage = global::Apotek.Properties.Resources.home_icon_obat;
            this.btn_data_obat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_data_obat.Enabled = false;
            this.btn_data_obat.FlatAppearance.BorderSize = 0;
            this.btn_data_obat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data_obat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_obat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(184)))));
            this.btn_data_obat.Location = new System.Drawing.Point(1040, 16);
            this.btn_data_obat.Name = "btn_data_obat";
            this.btn_data_obat.Size = new System.Drawing.Size(200, 200);
            this.btn_data_obat.TabIndex = 1;
            this.btn_data_obat.Text = "Data Obat";
            this.btn_data_obat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_data_obat.UseVisualStyleBackColor = false;
            this.btn_data_obat.Click += new System.EventHandler(this.btn_dataobat_Click);
            // 
            // btn_data_supplier
            // 
            this.btn_data_supplier.BackColor = System.Drawing.Color.White;
            this.btn_data_supplier.BackgroundImage = global::Apotek.Properties.Resources.home_icon_sup_final;
            this.btn_data_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_data_supplier.Enabled = false;
            this.btn_data_supplier.FlatAppearance.BorderSize = 0;
            this.btn_data_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data_supplier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(184)))));
            this.btn_data_supplier.Location = new System.Drawing.Point(80, 16);
            this.btn_data_supplier.Name = "btn_data_supplier";
            this.btn_data_supplier.Size = new System.Drawing.Size(200, 200);
            this.btn_data_supplier.TabIndex = 0;
            this.btn_data_supplier.Text = "Data Supplier";
            this.btn_data_supplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_data_supplier.UseVisualStyleBackColor = false;
            this.btn_data_supplier.Click += new System.EventHandler(this.btn_datasupplier_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::Apotek.Properties.Resources.home_bg;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_kasir);
            this.panel3.Controls.Add(this.btn_login_utama);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1365, 464);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Apotek.Properties.Resources.Apotek_White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(904, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(216, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bawang, Banjarnegara Wetan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(216, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "081112113678";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(216, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pharma Obat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "No Telp       : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat        :";
            // 
            // btn_kasir
            // 
            this.btn_kasir.BackColor = System.Drawing.Color.Transparent;
            this.btn_kasir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kasir.BackgroundImage")));
            this.btn_kasir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kasir.Enabled = false;
            this.btn_kasir.FlatAppearance.BorderSize = 0;
            this.btn_kasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kasir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kasir.ForeColor = System.Drawing.Color.White;
            this.btn_kasir.Location = new System.Drawing.Point(264, 360);
            this.btn_kasir.Name = "btn_kasir";
            this.btn_kasir.Size = new System.Drawing.Size(150, 50);
            this.btn_kasir.TabIndex = 7;
            this.btn_kasir.Text = "KASIR";
            this.btn_kasir.UseVisualStyleBackColor = false;
            this.btn_kasir.Click += new System.EventHandler(this.btn_kasir_Click);
            // 
            // btn_login_utama
            // 
            this.btn_login_utama.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_utama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login_utama.BackgroundImage")));
            this.btn_login_utama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login_utama.FlatAppearance.BorderSize = 0;
            this.btn_login_utama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_utama.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_utama.ForeColor = System.Drawing.Color.White;
            this.btn_login_utama.Location = new System.Drawing.Point(88, 360);
            this.btn_login_utama.Name = "btn_login_utama";
            this.btn_login_utama.Size = new System.Drawing.Size(150, 50);
            this.btn_login_utama.TabIndex = 0;
            this.btn_login_utama.Text = "LOGIN";
            this.btn_login_utama.UseVisualStyleBackColor = false;
            this.btn_login_utama.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama          :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(80, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memudahkan Urusan Apoteker Dengan Satu Klik";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "APPOTEK Ku";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1349, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Home";
            this.Text = "APPOTEK Ku";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fHome_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login_utama;
        private System.Windows.Forms.Button btn_kasir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_data_user;
        private System.Windows.Forms.Button btn_data_obat;
        private System.Windows.Forms.Button btn_data_supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

