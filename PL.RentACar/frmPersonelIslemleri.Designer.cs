namespace PL.RentACar
{
    partial class frmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslemleri));
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsYeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDegistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSil = new System.Windows.Forms.ToolStripButton();
            this.tsMusteriIslemleri = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.tsMusteriIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(784, 0);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 24);
            this.btnCikis.TabIndex = 39;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Maaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "E-Mail";
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(97, 80);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 26);
            this.txtAd.TabIndex = 16;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(97, 109);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 26);
            this.txtSoyad.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(97, 167);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(90, 26);
            this.txtEmail.TabIndex = 19;
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(97, 196);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(6);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(215, 72);
            this.txtAdres.TabIndex = 20;
            // 
            // txtMaas
            // 
            this.txtMaas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Location = new System.Drawing.Point(97, 271);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(150, 26);
            this.txtMaas.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Azure;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(27, 45);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(309, 16);
            this.textBox8.TabIndex = 28;
            this.textBox8.Text = "PERSONEL BİLGİLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Soyad";
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersoneller.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersoneller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Location = new System.Drawing.Point(321, 45);
            this.dgvPersoneller.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(473, 252);
            this.dgvPersoneller.TabIndex = 35;
            this.dgvPersoneller.DoubleClick += new System.EventHandler(this.dgvPersoneller_DoubleClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsYeni
            // 
            this.tsYeni.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsYeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsYeni.Image = global::PL.RentACar.Properties.Resources.edit_add;
            this.tsYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsYeni.Name = "tsYeni";
            this.tsYeni.Size = new System.Drawing.Size(55, 24);
            this.tsYeni.Text = "&Yeni";
            this.tsYeni.Click += new System.EventHandler(this.tsbYeni_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsKaydet
            // 
            this.tsKaydet.Enabled = false;
            this.tsKaydet.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsKaydet.Image = global::PL.RentACar.Properties.Resources.Floppy22;
            this.tsKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKaydet.Name = "tsKaydet";
            this.tsKaydet.Size = new System.Drawing.Size(71, 24);
            this.tsKaydet.Text = "&Kaydet";
            this.tsKaydet.Click += new System.EventHandler(this.tsbKaydet_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsDegistir
            // 
            this.tsDegistir.Enabled = false;
            this.tsDegistir.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsDegistir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsDegistir.Image = global::PL.RentACar.Properties.Resources.utils_222;
            this.tsDegistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDegistir.Name = "tsDegistir";
            this.tsDegistir.Size = new System.Drawing.Size(75, 24);
            this.tsDegistir.Text = "&Değiştir";
            this.tsDegistir.Click += new System.EventHandler(this.tsbDegistir_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // tsSil
            // 
            this.tsSil.Enabled = false;
            this.tsSil.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.tsSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsSil.Image = global::PL.RentACar.Properties.Resources.edit_remove;
            this.tsSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSil.Name = "tsSil";
            this.tsSil.Size = new System.Drawing.Size(45, 24);
            this.tsSil.Text = "&Sil";
            this.tsSil.Click += new System.EventHandler(this.tsbSil_Click);
            // 
            // tsMusteriIslemleri
            // 
            this.tsMusteriIslemleri.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tsMusteriIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsMusteriIslemleri.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMusteriIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsYeni,
            this.toolStripSeparator5,
            this.tsKaydet,
            this.toolStripSeparator6,
            this.tsDegistir,
            this.toolStripSeparator7,
            this.tsSil});
            this.tsMusteriIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tsMusteriIslemleri.Name = "tsMusteriIslemleri";
            this.tsMusteriIslemleri.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsMusteriIslemleri.Size = new System.Drawing.Size(809, 27);
            this.tsMusteriIslemleri.TabIndex = 85;
            this.tsMusteriIslemleri.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(146, 24);
            this.toolStripLabel1.Text = "Personel İşlemleri";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(97, 138);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 26);
            this.txtTelefon.TabIndex = 86;
            // 
            // cbEmail
            // 
            this.cbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@outlook.com"});
            this.cbEmail.Location = new System.Drawing.Point(187, 167);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(125, 26);
            this.cbEmail.TabIndex = 87;
            // 
            // frmPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(809, 327);
            this.Controls.Add(this.cbEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPersoneller);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.tsMusteriIslemleri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPersonelIslemleri";
            this.Text = "frmPersonelIslemleri";
            this.Load += new System.EventHandler(this.frmPersonelIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.tsMusteriIslemleri.ResumeLayout(false);
            this.tsMusteriIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPersoneller;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsYeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsDegistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsSil;
        private System.Windows.Forms.ToolStrip tsMusteriIslemleri;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.ComboBox cbEmail;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}