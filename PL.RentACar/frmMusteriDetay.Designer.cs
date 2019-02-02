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
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.Location = new System.Drawing.Point(777, 88);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(81, 32);
            this.btnGeri.TabIndex = 97;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 96;
            this.label8.Text = "Ehliyet No";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(121, 219);
            this.txtEhliyetNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(148, 26);
            this.txtEhliyetNo.TabIndex = 95;
            this.txtEhliyetNo.TextChanged += new System.EventHandler(this.txtEhliyetNo_TextChanged);
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusteriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(277, 130);
            this.dgvMusteriler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(581, 287);
            this.dgvMusteriler.TabIndex = 94;
            this.dgvMusteriler.DoubleClick += new System.EventHandler(this.dgvMusteriler_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Ad";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(121, 190);
            this.txtTCKNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(148, 26);
            this.txtTCKNo.TabIndex = 90;
            this.txtTCKNo.TextChanged += new System.EventHandler(this.txtTCKNo_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(121, 160);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(148, 26);
            this.txtSoyad.TabIndex = 89;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 130);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(148, 26);
            this.txtAd.TabIndex = 88;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Güncel Puan";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(121, 303);
            this.txtPuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.ReadOnly = true;
            this.txtPuan.Size = new System.Drawing.Size(148, 26);
            this.txtPuan.TabIndex = 98;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(461, 94);
            this.dtpBitis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(298, 26);
            this.dtpBitis.TabIndex = 102;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(121, 94);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(298, 26);
            this.dtpBaslangic.TabIndex = 101;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 165;
            this.label4.Text = "Bitiş Tarihi Seçin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 164;
            this.label5.Text = "Başlangıç Tarihi Seçin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 163;
            this.label7.Text = "Tarih Aralığı Seçin";
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(857, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(24, 22);
            this.btnCikis.TabIndex = 88;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 24);
            this.panel1.TabIndex = 166;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Müşteri Detayları";
            // 
            // frmMusteriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(882, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuan);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMusteriDetay";
            this.Text = "frmMusteriDetay";
            this.Load += new System.EventHandler(this.frmMusteriDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}