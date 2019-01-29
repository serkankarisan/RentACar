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
            this.label12 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 162;
            this.label12.Text = "Sözleşme";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 161;
            this.label11.Text = "Gün Sayısı";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(94, 331);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtGunSayisi.TabIndex = 160;
            this.txtGunSayisi.TextChanged += new System.EventHandler(this.txtGunSayisi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Zamanında Teslim";
            // 
            // rdnNo
            // 
            this.rdnNo.AutoSize = true;
            this.rdnNo.Location = new System.Drawing.Point(230, 282);
            this.rdnNo.Name = "rdnNo";
            this.rdnNo.Size = new System.Drawing.Size(49, 17);
            this.rdnNo.TabIndex = 158;
            this.rdnNo.TabStop = true;
            this.rdnNo.Text = "Hayır";
            this.rdnNo.UseVisualStyleBackColor = true;
            // 
            // rdnYes
            // 
            this.rdnYes.AutoSize = true;
            this.rdnYes.Location = new System.Drawing.Point(177, 282);
            this.rdnYes.Name = "rdnYes";
            this.rdnYes.Size = new System.Drawing.Size(47, 17);
            this.rdnYes.TabIndex = 157;
            this.rdnYes.Text = "Evet";
            this.rdnYes.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(23, 356);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 13);
            this.label26.TabIndex = 155;
            this.label26.Text = "Ekstra Tutar";
            // 
            // txtEkstraTutar
            // 
            this.txtEkstraTutar.Location = new System.Drawing.Point(94, 356);
            this.txtEkstraTutar.Name = "txtEkstraTutar";
            this.txtEkstraTutar.ReadOnly = true;
            this.txtEkstraTutar.Size = new System.Drawing.Size(100, 20);
            this.txtEkstraTutar.TabIndex = 154;
            // 
            // dgvSozlesmeDetay
            // 
            this.dgvSozlesmeDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSozlesmeDetay.Location = new System.Drawing.Point(393, 71);
            this.dgvSozlesmeDetay.Name = "dgvSozlesmeDetay";
            this.dgvSozlesmeDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSozlesmeDetay.Size = new System.Drawing.Size(413, 206);
            this.dgvSozlesmeDetay.TabIndex = 153;
            this.dgvSozlesmeDetay.DoubleClick += new System.EventHandler(this.dgvSozlesmeDetay_DoubleClick);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTeslimAl.FlatAppearance.BorderSize = 0;
            this.btnTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimAl.Location = new System.Drawing.Point(90, 402);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(103, 27);
            this.btnTeslimAl.TabIndex = 152;
            this.btnTeslimAl.Text = "Aracı Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = false;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(394, 313);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 13);
            this.label23.TabIndex = 151;
            this.label23.Text = "Sözleşme Tutarı";
            // 
            // txtSozlesmeTutari
            // 
            this.txtSozlesmeTutari.Location = new System.Drawing.Point(482, 309);
            this.txtSozlesmeTutari.Name = "txtSozlesmeTutari";
            this.txtSozlesmeTutari.ReadOnly = true;
            this.txtSozlesmeTutari.Size = new System.Drawing.Size(100, 20);
            this.txtSozlesmeTutari.TabIndex = 150;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(417, 286);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 149;
            this.label22.Text = "Araç Sayısı";
            // 
            // txtAracSayisi
            // 
            this.txtAracSayisi.Location = new System.Drawing.Point(482, 283);
            this.txtAracSayisi.Name = "txtAracSayisi";
            this.txtAracSayisi.ReadOnly = true;
            this.txtAracSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtAracSayisi.TabIndex = 148;
            // 
            // txtYakitDurumu
            // 
            this.txtYakitDurumu.Location = new System.Drawing.Point(94, 254);
            this.txtYakitDurumu.Name = "txtYakitDurumu";
            this.txtYakitDurumu.ReadOnly = true;
            this.txtYakitDurumu.Size = new System.Drawing.Size(100, 20);
            this.txtYakitDurumu.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 146;
            this.label6.Text = "Yakıt Durumu";
            // 
            // txtAracDurumu
            // 
            this.txtAracDurumu.Location = new System.Drawing.Point(93, 226);
            this.txtAracDurumu.Name = "txtAracDurumu";
            this.txtAracDurumu.ReadOnly = true;
            this.txtAracDurumu.Size = new System.Drawing.Size(100, 20);
            this.txtAracDurumu.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 144;
            this.label7.Text = "Araç Durumu";
            // 
            // txtGunlukFiyat
            // 
            this.txtGunlukFiyat.Location = new System.Drawing.Point(93, 200);
            this.txtGunlukFiyat.Name = "txtGunlukFiyat";
            this.txtGunlukFiyat.ReadOnly = true;
            this.txtGunlukFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtGunlukFiyat.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 142;
            this.label9.Text = "Günlük Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 141;
            this.label5.Text = "Plaka No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 138;
            this.label8.Text = "Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 137;
            this.label10.Text = "Marka";
            // 
            // txtPlakaNo
            // 
            this.txtPlakaNo.Location = new System.Drawing.Point(93, 174);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.ReadOnly = true;
            this.txtPlakaNo.Size = new System.Drawing.Size(100, 20);
            this.txtPlakaNo.TabIndex = 136;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(93, 148);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.ReadOnly = true;
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 135;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(93, 122);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(100, 20);
            this.txtTip.TabIndex = 134;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(93, 96);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 133;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(93, 70);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 132;
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Location = new System.Drawing.Point(453, 35);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(68, 27);
            this.btnSec.TabIndex = 130;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Araç";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 165;
            this.label13.Text = "Son Durum";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(201, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 163;
            this.label14.Text = "Son Durum";
            // 
            // cbAracDurumu
            // 
            this.cbAracDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAracDurumu.FormattingEnabled = true;
            this.cbAracDurumu.Items.AddRange(new object[] {
            "Agir Hasarli",
            "Hafif Hasarli",
            "Hasar Yok"});
            this.cbAracDurumu.Location = new System.Drawing.Point(268, 226);
            this.cbAracDurumu.Name = "cbAracDurumu";
            this.cbAracDurumu.Size = new System.Drawing.Size(121, 21);
            this.cbAracDurumu.TabIndex = 166;
            // 
            // cbYakitDurumu
            // 
            this.cbYakitDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbYakitDurumu.FormattingEnabled = true;
            this.cbYakitDurumu.Items.AddRange(new object[] {
            "%25",
            "%50",
            "%75",
            "%100"});
            this.cbYakitDurumu.Location = new System.Drawing.Point(268, 254);
            this.cbYakitDurumu.Name = "cbYakitDurumu";
            this.cbYakitDurumu.Size = new System.Drawing.Size(121, 21);
            this.cbYakitDurumu.TabIndex = 167;
            // 
            // frmTeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 474);
            this.Controls.Add(this.cbYakitDurumu);
            this.Controls.Add(this.cbAracDurumu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
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
            this.Name = "frmTeslimAl";
            this.Text = "frmTeslimAl";
            this.Load += new System.EventHandler(this.frmTeslimAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
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
    }
}