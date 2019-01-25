namespace PL.RentACar
{
    partial class frmMusteriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriIslemleri));
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.tsDegistir = new System.Windows.Forms.ToolStripButton();
            this.dtpEhliyetTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tsYeni = new System.Windows.Forms.ToolStripButton();
            this.tsKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsSil = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tsMusteriIslemleri = new System.Windows.Forms.ToolStrip();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.tsMusteriIslemleri.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Ehliyet No";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(112, 178);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(240, 26);
            this.dtpDogumTarihi.TabIndex = 81;
            // 
            // tsDegistir
            // 
            this.tsDegistir.Enabled = false;
            this.tsDegistir.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsDegistir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsDegistir.Image = global::PL.RentACar.Properties.Resources.utils_222;
            this.tsDegistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDegistir.Name = "tsDegistir";
            this.tsDegistir.Size = new System.Drawing.Size(71, 22);
            this.tsDegistir.Text = "&Değiştir";
            // 
            // dtpEhliyetTarihi
            // 
            this.dtpEhliyetTarihi.Location = new System.Drawing.Point(112, 267);
            this.dtpEhliyetTarihi.Name = "dtpEhliyetTarihi";
            this.dtpEhliyetTarihi.Size = new System.Drawing.Size(240, 26);
            this.dtpEhliyetTarihi.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 80;
            this.label10.Text = "Cinsiyet";
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Location = new System.Drawing.Point(112, 207);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cbCinsiyet.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "Doğum Tarihi";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(112, 238);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(100, 26);
            this.txtEhliyetNo.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Ehliyet Tarihi";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusteriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(380, 55);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(448, 289);
            this.dgvMusteriler.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "TC Kimlik No";
            // 
            // tsYeni
            // 
            this.tsYeni.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsYeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsYeni.Image = global::PL.RentACar.Properties.Resources.edit_add;
            this.tsYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsYeni.Name = "tsYeni";
            this.tsYeni.Size = new System.Drawing.Size(51, 22);
            this.tsYeni.Text = "&Yeni";
            this.tsYeni.Click += new System.EventHandler(this.tsYeni_Click);
            // 
            // tsKaydet
            // 
            this.tsKaydet.Enabled = false;
            this.tsKaydet.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsKaydet.Image = global::PL.RentACar.Properties.Resources.Floppy22;
            this.tsKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKaydet.Name = "tsKaydet";
            this.tsKaydet.Size = new System.Drawing.Size(67, 22);
            this.tsKaydet.Text = "&Kaydet";
            this.tsKaydet.Click += new System.EventHandler(this.tsKaydet_Click);
            // 
            // tsSil
            // 
            this.tsSil.Enabled = false;
            this.tsSil.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsSil.Image = global::PL.RentACar.Properties.Resources.edit_remove;
            this.tsSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSil.Name = "tsSil";
            this.tsSil.Size = new System.Drawing.Size(41, 22);
            this.tsSil.Text = "&Sil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Adres";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ad";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(112, 149);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(100, 26);
            this.txtTCKNo.TabIndex = 67;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(112, 120);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 26);
            this.txtAdres.TabIndex = 66;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(112, 62);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 26);
            this.txtTelefon.TabIndex = 64;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 33);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtSoyad.TabIndex = 63;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 62;
            // 
            // tsMusteriIslemleri
            // 
            this.tsMusteriIslemleri.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tsMusteriIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.tsYeni,
            this.toolStripSeparator5,
            this.tsKaydet,
            this.toolStripSeparator6,
            this.tsDegistir,
            this.toolStripSeparator7,
            this.tsSil});
            this.tsMusteriIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tsMusteriIslemleri.Name = "tsMusteriIslemleri";
            this.tsMusteriIslemleri.Size = new System.Drawing.Size(840, 25);
            this.tsMusteriIslemleri.TabIndex = 61;
            this.tsMusteriIslemleri.Text = "toolStrip1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.dtpDogumTarihi);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.dtpEhliyetTarihi);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.cbCinsiyet);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTCKNo);
            this.panel1.Controls.Add(this.txtEhliyetNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 306);
            this.panel1.TabIndex = 83;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(815, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 24);
            this.btnCikis.TabIndex = 84;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmMusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(840, 400);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.tsMusteriIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMusteriIslemleri";
            this.Text = "frmMusteriIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.tsMusteriIslemleri.ResumeLayout(false);
            this.tsMusteriIslemleri.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ToolStripButton tsDegistir;
        private System.Windows.Forms.DateTimePicker dtpEhliyetTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton tsYeni;
        private System.Windows.Forms.ToolStripButton tsKaydet;
        private System.Windows.Forms.ToolStripButton tsSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ToolStrip tsMusteriIslemleri;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
    }
}