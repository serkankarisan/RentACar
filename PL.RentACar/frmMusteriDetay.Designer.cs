namespace PL.RentACar
{
    partial class frmMusteriDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriDetay));
            this.btnGeri = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.Location = new System.Drawing.Point(770, 19);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(25, 25);
            this.btnGeri.TabIndex = 97;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "Ehliyet No";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(659, 53);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(100, 20);
            this.txtEhliyetNo.TabIndex = 95;
            this.txtEhliyetNo.TextChanged += new System.EventHandler(this.txtEhliyetNo_TextChanged);
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusteriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(15, 85);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(744, 289);
            this.dgvMusteriler.TabIndex = 94;
            this.dgvMusteriler.DoubleClick += new System.EventHandler(this.dgvMusteriler_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Ad";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(451, 53);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(100, 20);
            this.txtTCKNo.TabIndex = 90;
            this.txtTCKNo.TextChanged += new System.EventHandler(this.txtTCKNo_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(227, 53);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 89;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(46, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 88;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Güncel Puan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(659, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Tarih aralığı seçin";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(252, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 102;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 101;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmMusteriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEhliyetNo);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTCKNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "frmMusteriDetay";
            this.Text = "frmMusteriDetay";
            this.Load += new System.EventHandler(this.frmMusteriDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}