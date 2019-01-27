namespace PL.RentACar
{
    partial class frmSozlesmeKayitAc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSozlesmeKayitAc));
            this.dtpSozlesmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.btnKayitAc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMusteriCinsiyet = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMusteriEhliyetNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMusteriTCKNo = new System.Windows.Forms.TextBox();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriEmail = new System.Windows.Forms.TextBox();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPersonelSec = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dgvSozlesmeler = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSozlesmeTarihi
            // 
            this.dtpSozlesmeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSozlesmeTarihi.Location = new System.Drawing.Point(473, 96);
            this.dtpSozlesmeTarihi.Name = "dtpSozlesmeTarihi";
            this.dtpSozlesmeTarihi.Size = new System.Drawing.Size(240, 26);
            this.dtpSozlesmeTarihi.TabIndex = 151;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(469, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 20);
            this.label24.TabIndex = 150;
            this.label24.Text = "Sözleşme Tarihi";
            // 
            // btnKayitAc
            // 
            this.btnKayitAc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnKayitAc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKayitAc.FlatAppearance.BorderSize = 0;
            this.btnKayitAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitAc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKayitAc.Location = new System.Drawing.Point(473, 142);
            this.btnKayitAc.Name = "btnKayitAc";
            this.btnKayitAc.Size = new System.Drawing.Size(175, 32);
            this.btnKayitAc.TabIndex = 149;
            this.btnKayitAc.Text = "Sözleşme Kayıt Aç";
            this.btnKayitAc.UseVisualStyleBackColor = false;
            this.btnKayitAc.Click += new System.EventHandler(this.btnKayitAc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(27, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 148;
            this.label12.Text = "Soyad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(27, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 20);
            this.label14.TabIndex = 147;
            this.label14.Text = "Ad";
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(133, 378);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.ReadOnly = true;
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(195, 26);
            this.txtPersonelSoyadi.TabIndex = 146;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdi.Location = new System.Drawing.Point(134, 346);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.ReadOnly = true;
            this.txtPersonelAdi.Size = new System.Drawing.Size(194, 26);
            this.txtPersonelAdi.TabIndex = 145;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(24, 316);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 20);
            this.label21.TabIndex = 144;
            this.label21.Text = "Personel Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(24, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 142;
            this.label11.Text = "Cinsiyet";
            // 
            // cbMusteriCinsiyet
            // 
            this.cbMusteriCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMusteriCinsiyet.Enabled = false;
            this.cbMusteriCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMusteriCinsiyet.FormattingEnabled = true;
            this.cbMusteriCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbMusteriCinsiyet.Location = new System.Drawing.Point(131, 241);
            this.cbMusteriCinsiyet.Name = "cbMusteriCinsiyet";
            this.cbMusteriCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cbMusteriCinsiyet.TabIndex = 141;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(24, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 140;
            this.label13.Text = "Ehliyet No";
            // 
            // txtMusteriEhliyetNo
            // 
            this.txtMusteriEhliyetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriEhliyetNo.Location = new System.Drawing.Point(131, 272);
            this.txtMusteriEhliyetNo.Name = "txtMusteriEhliyetNo";
            this.txtMusteriEhliyetNo.ReadOnly = true;
            this.txtMusteriEhliyetNo.Size = new System.Drawing.Size(121, 26);
            this.txtMusteriEhliyetNo.TabIndex = 139;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(24, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 138;
            this.label15.Text = "TC Kimlik No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(24, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 137;
            this.label16.Text = "Adres";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(24, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 20);
            this.label17.TabIndex = 136;
            this.label17.Text = "E-Mail";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(24, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 20);
            this.label18.TabIndex = 135;
            this.label18.Text = "Telefon";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(24, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 20);
            this.label19.TabIndex = 134;
            this.label19.Text = "Soyad";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(24, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 20);
            this.label20.TabIndex = 133;
            this.label20.Text = "Ad";
            // 
            // txtMusteriTCKNo
            // 
            this.txtMusteriTCKNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTCKNo.Location = new System.Drawing.Point(131, 212);
            this.txtMusteriTCKNo.Name = "txtMusteriTCKNo";
            this.txtMusteriTCKNo.ReadOnly = true;
            this.txtMusteriTCKNo.Size = new System.Drawing.Size(197, 26);
            this.txtMusteriTCKNo.TabIndex = 132;
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdres.Location = new System.Drawing.Point(131, 183);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.ReadOnly = true;
            this.txtMusteriAdres.Size = new System.Drawing.Size(197, 26);
            this.txtMusteriAdres.TabIndex = 131;
            // 
            // txtMusteriEmail
            // 
            this.txtMusteriEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriEmail.Location = new System.Drawing.Point(131, 154);
            this.txtMusteriEmail.Name = "txtMusteriEmail";
            this.txtMusteriEmail.ReadOnly = true;
            this.txtMusteriEmail.Size = new System.Drawing.Size(197, 26);
            this.txtMusteriEmail.TabIndex = 130;
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTelefon.Location = new System.Drawing.Point(131, 125);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.ReadOnly = true;
            this.txtMusteriTelefon.Size = new System.Drawing.Size(197, 26);
            this.txtMusteriTelefon.TabIndex = 129;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(131, 96);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.ReadOnly = true;
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(197, 26);
            this.txtMusteriSoyadi.TabIndex = 128;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdi.Location = new System.Drawing.Point(131, 67);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.ReadOnly = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(197, 26);
            this.txtMusteriAdi.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "Müşteri Bilgileri";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Controls.Add(this.btnCikis);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 24);
            this.panel4.TabIndex = 155;
            // 
            // btnPersonelSec
            // 
            this.btnPersonelSec.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelSec.FlatAppearance.BorderSize = 0;
            this.btnPersonelSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPersonelSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSec.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelSec.Image")));
            this.btnPersonelSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelSec.Location = new System.Drawing.Point(344, 346);
            this.btnPersonelSec.Name = "btnPersonelSec";
            this.btnPersonelSec.Size = new System.Drawing.Size(80, 32);
            this.btnPersonelSec.TabIndex = 143;
            this.btnPersonelSec.Text = "Seç";
            this.btnPersonelSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelSec.UseVisualStyleBackColor = false;
            this.btnPersonelSec.Click += new System.EventHandler(this.btnPersonelSec_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriSec.FlatAppearance.BorderSize = 0;
            this.btnMusteriSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMusteriSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSec.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSec.Image")));
            this.btnMusteriSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSec.Location = new System.Drawing.Point(344, 67);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(80, 32);
            this.btnMusteriSec.TabIndex = 125;
            this.btnMusteriSec.Text = "Seç";
            this.btnMusteriSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.UseVisualStyleBackColor = false;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(809, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(24, 22);
            this.btnCikis.TabIndex = 88;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dgvSozlesmeler
            // 
            this.dgvSozlesmeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSozlesmeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSozlesmeler.BackgroundColor = System.Drawing.Color.White;
            this.dgvSozlesmeler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSozlesmeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSozlesmeler.Location = new System.Drawing.Point(473, 183);
            this.dgvSozlesmeler.Name = "dgvSozlesmeler";
            this.dgvSozlesmeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSozlesmeler.Size = new System.Drawing.Size(349, 221);
            this.dgvSozlesmeler.TabIndex = 156;
            // 
            // frmSozlesmeKayitAc
            // 
            this.AcceptButton = this.btnKayitAc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(834, 432);
            this.Controls.Add(this.dgvSozlesmeler);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnKayitAc);
            this.Controls.Add(this.dtpSozlesmeTarihi);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnPersonelSec);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.txtPersonelSoyadi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMusteriSoyadi);
            this.Controls.Add(this.txtMusteriTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriEmail);
            this.Controls.Add(this.txtMusteriEhliyetNo);
            this.Controls.Add(this.txtMusteriAdres);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMusteriTCKNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbMusteriCinsiyet);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSozlesmeKayitAc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSozlesmeKayitAc";
            this.Load += new System.EventHandler(this.frmSozlesmeKayitAc_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSozlesmeTarihi;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnKayitAc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Button btnPersonelSec;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMusteriCinsiyet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMusteriEhliyetNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMusteriTCKNo;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.TextBox txtMusteriEmail;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSozlesmeler;
    }
}