namespace PL.RentACar
{
    partial class frmKullaniciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPersonel = new System.Windows.Forms.ComboBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.cbYetki = new System.Windows.Forms.ComboBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.tsMusteriIslemleri = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsYeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDegistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSil = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.tsMusteriIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbPersonel);
            this.panel1.Controls.Add(this.txtSifreTekrar);
            this.panel1.Controls.Add(this.cbYetki);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 198);
            this.panel1.TabIndex = 30;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Azure;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(19, 9);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 16);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "KAYIT BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Şifre Tekrar";
            // 
            // cbPersonel
            // 
            this.cbPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPersonel.FormattingEnabled = true;
            this.cbPersonel.Location = new System.Drawing.Point(114, 120);
            this.cbPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.cbPersonel.Name = "cbPersonel";
            this.cbPersonel.Size = new System.Drawing.Size(160, 28);
            this.cbPersonel.TabIndex = 0;
            this.cbPersonel.SelectedIndexChanged += new System.EventHandler(this.cbPersonel_SelectedIndexChanged);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.Location = new System.Drawing.Point(114, 91);
            this.txtSifreTekrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(160, 26);
            this.txtSifreTekrar.TabIndex = 14;
            // 
            // cbYetki
            // 
            this.cbYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYetki.FormattingEnabled = true;
            this.cbYetki.Location = new System.Drawing.Point(114, 149);
            this.cbYetki.Margin = new System.Windows.Forms.Padding(4);
            this.cbYetki.Name = "cbYetki";
            this.cbYetki.Size = new System.Drawing.Size(160, 28);
            this.cbYetki.TabIndex = 1;
            this.cbYetki.SelectedIndexChanged += new System.EventHandler(this.cbYetki_SelectedIndexChanged);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(114, 32);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(160, 26);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(114, 61);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(160, 26);
            this.txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yetki";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPersonelAdi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPersonelSoyadi);
            this.panel2.Location = new System.Drawing.Point(325, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 47);
            this.panel2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Personel Adı";
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdi.Location = new System.Drawing.Point(110, 13);
            this.txtPersonelAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(113, 26);
            this.txtPersonelAdi.TabIndex = 10;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(231, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Personel Soyadı";
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonelSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(362, 13);
            this.txtPersonelSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(113, 26);
            this.txtPersonelSoyadi.TabIndex = 11;
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(325, 78);
            this.dgvKullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(483, 341);
            this.dgvKullanicilar.TabIndex = 29;
            this.dgvKullanicilar.DoubleClick += new System.EventHandler(this.dgvKullanicilar_DoubleClick);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(796, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 24);
            this.btnCikis.TabIndex = 86;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // tsMusteriIslemleri
            // 
            this.tsMusteriIslemleri.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tsMusteriIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsYeni,
            this.toolStripSeparator5,
            this.tsKaydet,
            this.toolStripSeparator6,
            this.tsDegistir,
            this.toolStripSeparator7,
            this.tsSil});
            this.tsMusteriIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tsMusteriIslemleri.Name = "tsMusteriIslemleri";
            this.tsMusteriIslemleri.Size = new System.Drawing.Size(821, 25);
            this.tsMusteriIslemleri.TabIndex = 85;
            this.tsMusteriIslemleri.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            this.tsDegistir.Click += new System.EventHandler(this.tsDegistir_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
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
            this.tsSil.Click += new System.EventHandler(this.tsSil_Click);
            // 
            // frmKullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(821, 442);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.tsMusteriIslemleri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvKullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciIslemleri";
            this.Text = "frmKullaniciTanimlama";
            this.Load += new System.EventHandler(this.frmKullaniciIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.tsMusteriIslemleri.ResumeLayout(false);
            this.tsMusteriIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPersonel;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.ComboBox cbYetki;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ToolStrip tsMusteriIslemleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsYeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsDegistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsSil;
    }
}