namespace PL.RentACar
{
    partial class frmTeslimAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeslimAl));
            this.label11 = new System.Windows.Forms.Label();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdnNo = new System.Windows.Forms.RadioButton();
            this.rdnYes = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.txtEkstraTutar = new System.Windows.Forms.TextBox();
            this.dgvSozlesmeDetay = new System.Windows.Forms.DataGridView();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSozlesmeTutari = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAracSayisi = new System.Windows.Forms.TextBox();
            this.txtYakitDurumu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAracDurumu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGunlukFiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAracDurumu = new System.Windows.Forms.ComboBox();
            this.cbYakitDurumu = new System.Windows.Forms.ComboBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeDetay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 391);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 161;
            this.label11.Text = "Gün Sayısı";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGunSayisi.Location = new System.Drawing.Point(124, 391);
            this.txtGunSayisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.ReadOnly = true;
            this.txtGunSayisi.Size = new System.Drawing.Size(148, 26);
            this.txtGunSayisi.TabIndex = 160;
            this.txtGunSayisi.TextChanged += new System.EventHandler(this.txtGunSayisi_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 159;
            this.label2.Text = "Zamanında Teslim";
            // 
            // rdnNo
            // 
            this.rdnNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdnNo.AutoSize = true;
            this.rdnNo.Location = new System.Drawing.Point(351, 357);
            this.rdnNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdnNo.Name = "rdnNo";
            this.rdnNo.Size = new System.Drawing.Size(63, 24);
            this.rdnNo.TabIndex = 158;
            this.rdnNo.TabStop = true;
            this.rdnNo.Text = "Hayır";
            this.rdnNo.UseVisualStyleBackColor = true;
            this.rdnNo.CheckedChanged += new System.EventHandler(this.rdnNo_CheckedChanged);
            // 
            // rdnYes
            // 
            this.rdnYes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdnYes.AutoSize = true;
            this.rdnYes.Location = new System.Drawing.Point(272, 357);
            this.rdnYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdnYes.Name = "rdnYes";
            this.rdnYes.Size = new System.Drawing.Size(59, 24);
            this.rdnYes.TabIndex = 157;
            this.rdnYes.Text = "Evet";
            this.rdnYes.UseVisualStyleBackColor = true;
            this.rdnYes.CheckedChanged += new System.EventHandler(this.rdnYes_CheckedChanged);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 421);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 20);
            this.label26.TabIndex = 155;
            this.label26.Text = "Ekstra Tutar";
            // 
            // txtEkstraTutar
            // 
            this.txtEkstraTutar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEkstraTutar.Location = new System.Drawing.Point(124, 421);
            this.txtEkstraTutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEkstraTutar.Name = "txtEkstraTutar";
            this.txtEkstraTutar.ReadOnly = true;
            this.txtEkstraTutar.Size = new System.Drawing.Size(148, 26);
            this.txtEkstraTutar.TabIndex = 154;
            // 
            // dgvSozlesmeDetay
            // 
            this.dgvSozlesmeDetay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvSozlesmeDetay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSozlesmeDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSozlesmeDetay.Location = new System.Drawing.Point(576, 65);
            this.dgvSozlesmeDetay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSozlesmeDetay.Name = "dgvSozlesmeDetay";
            this.dgvSozlesmeDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSozlesmeDetay.Size = new System.Drawing.Size(550, 301);
            this.dgvSozlesmeDetay.TabIndex = 153;
            this.dgvSozlesmeDetay.DoubleClick += new System.EventHandler(this.dgvSozlesmeDetay_DoubleClick);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTeslimAl.BackColor = System.Drawing.Color.Transparent;
            this.btnTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAl.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimAl.Image")));
            this.btnTeslimAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeslimAl.Location = new System.Drawing.Point(287, 405);
            this.btnTeslimAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(174, 42);
            this.btnTeslimAl.TabIndex = 152;
            this.btnTeslimAl.Text = "Aracı Teslim Al";
            this.btnTeslimAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslimAl.UseVisualStyleBackColor = false;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(847, 424);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 20);
            this.label23.TabIndex = 151;
            this.label23.Text = "Sözleşme Tutarı";
            // 
            // txtSozlesmeTutari
            // 
            this.txtSozlesmeTutari.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSozlesmeTutari.Location = new System.Drawing.Point(978, 421);
            this.txtSozlesmeTutari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSozlesmeTutari.Name = "txtSozlesmeTutari";
            this.txtSozlesmeTutari.ReadOnly = true;
            this.txtSozlesmeTutari.Size = new System.Drawing.Size(148, 26);
            this.txtSozlesmeTutari.TabIndex = 150;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(847, 381);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 20);
            this.label22.TabIndex = 149;
            this.label22.Text = "Araç Sayısı";
            // 
            // txtAracSayisi
            // 
            this.txtAracSayisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAracSayisi.Location = new System.Drawing.Point(978, 381);
            this.txtAracSayisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAracSayisi.Name = "txtAracSayisi";
            this.txtAracSayisi.ReadOnly = true;
            this.txtAracSayisi.Size = new System.Drawing.Size(148, 26);
            this.txtAracSayisi.TabIndex = 148;
            // 
            // txtYakitDurumu
            // 
            this.txtYakitDurumu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYakitDurumu.Location = new System.Drawing.Point(124, 306);
            this.txtYakitDurumu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYakitDurumu.Name = "txtYakitDurumu";
            this.txtYakitDurumu.ReadOnly = true;
            this.txtYakitDurumu.Size = new System.Drawing.Size(148, 26);
            this.txtYakitDurumu.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 146;
            this.label6.Text = "Yakıt Durumu";
            // 
            // txtAracDurumu
            // 
            this.txtAracDurumu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAracDurumu.Location = new System.Drawing.Point(124, 276);
            this.txtAracDurumu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAracDurumu.Name = "txtAracDurumu";
            this.txtAracDurumu.ReadOnly = true;
            this.txtAracDurumu.Size = new System.Drawing.Size(148, 26);
            this.txtAracDurumu.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 144;
            this.label7.Text = "Araç Durumu";
            // 
            // txtGunlukFiyat
            // 
            this.txtGunlukFiyat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGunlukFiyat.Location = new System.Drawing.Point(124, 215);
            this.txtGunlukFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGunlukFiyat.Name = "txtGunlukFiyat";
            this.txtGunlukFiyat.ReadOnly = true;
            this.txtGunlukFiyat.Size = new System.Drawing.Size(148, 26);
            this.txtGunlukFiyat.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 142;
            this.label9.Text = "Günlük Fiyat";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 141;
            this.label5.Text = "Plaka No";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 140;
            this.label4.Text = "Renk";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tip";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 138;
            this.label8.Text = "Model";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 137;
            this.label10.Text = "Marka";
            // 
            // txtPlakaNo
            // 
            this.txtPlakaNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlakaNo.Location = new System.Drawing.Point(124, 185);
            this.txtPlakaNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.ReadOnly = true;
            this.txtPlakaNo.Size = new System.Drawing.Size(148, 26);
            this.txtPlakaNo.TabIndex = 136;
            // 
            // txtRenk
            // 
            this.txtRenk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRenk.Location = new System.Drawing.Point(124, 155);
            this.txtRenk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.ReadOnly = true;
            this.txtRenk.Size = new System.Drawing.Size(148, 26);
            this.txtRenk.TabIndex = 135;
            // 
            // txtTip
            // 
            this.txtTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTip.Location = new System.Drawing.Point(124, 125);
            this.txtTip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(148, 26);
            this.txtTip.TabIndex = 134;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModel.Location = new System.Drawing.Point(124, 95);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(148, 26);
            this.txtModel.TabIndex = 133;
            // 
            // txtMarka
            // 
            this.txtMarka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMarka.Location = new System.Drawing.Point(124, 65);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(148, 26);
            this.txtMarka.TabIndex = 132;
            // 
            // btnSec
            // 
            this.btnSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSec.BackColor = System.Drawing.Color.Transparent;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.Image")));
            this.btnSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSec.Location = new System.Drawing.Point(339, 65);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(169, 42);
            this.btnSec.TabIndex = 130;
            this.btnSec.Text = "Sözleşme Seç";
            this.btnSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 131;
            this.label1.Text = "Araç Bilgileri";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 306);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 165;
            this.label13.Text = "Son Durum";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 276);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 163;
            this.label14.Text = "Son Durum";
            // 
            // cbAracDurumu
            // 
            this.cbAracDurumu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAracDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAracDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAracDurumu.FormattingEnabled = true;
            this.cbAracDurumu.Items.AddRange(new object[] {
            "Hasar yok",
            "Az hasarlı",
            "Ağır hasarlı"});
            this.cbAracDurumu.Location = new System.Drawing.Point(383, 273);
            this.cbAracDurumu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAracDurumu.Name = "cbAracDurumu";
            this.cbAracDurumu.Size = new System.Drawing.Size(180, 28);
            this.cbAracDurumu.TabIndex = 166;
            this.cbAracDurumu.SelectedIndexChanged += new System.EventHandler(this.cbAracDurumu_SelectedIndexChanged);
            // 
            // cbYakitDurumu
            // 
            this.cbYakitDurumu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbYakitDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYakitDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbYakitDurumu.FormattingEnabled = true;
            this.cbYakitDurumu.Items.AddRange(new object[] {
            "%25",
            "%50",
            "%75",
            "%100"});
            this.cbYakitDurumu.Location = new System.Drawing.Point(382, 306);
            this.cbYakitDurumu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbYakitDurumu.Name = "cbYakitDurumu";
            this.cbYakitDurumu.Size = new System.Drawing.Size(180, 28);
            this.cbYakitDurumu.TabIndex = 167;
            this.cbYakitDurumu.SelectedIndexChanged += new System.EventHandler(this.cbYakitDurumu_SelectedIndexChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(1126, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(24, 22);
            this.btnCikis.TabIndex = 88;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 24);
            this.panel1.TabIndex = 168;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto.Location = new System.Drawing.Point(339, 126);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(169, 128);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 169;
            this.pbFoto.TabStop = false;
            // 
            // frmTeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1151, 459);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbYakitDurumu);
            this.Controls.Add(this.cbAracDurumu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdnNo);
            this.Controls.Add(this.rdnYes);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtEkstraTutar);
            this.Controls.Add(this.dgvSozlesmeDetay);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtSozlesmeTutari);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtAracSayisi);
            this.Controls.Add(this.txtYakitDurumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAracDurumu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGunlukFiyat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPlakaNo);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTeslimAl";
            this.Text = "frmTeslimAl";
            this.Load += new System.EventHandler(this.frmTeslimAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeDetay)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdnNo;
        private System.Windows.Forms.RadioButton rdnYes;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtEkstraTutar;
        private System.Windows.Forms.DataGridView dgvSozlesmeDetay;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSozlesmeTutari;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAracSayisi;
        private System.Windows.Forms.TextBox txtYakitDurumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAracDurumu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGunlukFiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbAracDurumu;
        private System.Windows.Forms.ComboBox cbYakitDurumu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}