namespace PL.RentACar
{
    partial class frmOdemeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeIslemleri));
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.lblAlınan = new System.Windows.Forms.Label();
            this.txtAlınan = new System.Windows.Forms.TextBox();
            this.dgvOdeme = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.lblborc = new System.Windows.Forms.Label();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.lblsozlesme = new System.Windows.Forms.Label();
            this.txtSozlesmeTutar = new System.Windows.Forms.TextBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnSozlesmeSec = new System.Windows.Forms.Button();
            this.btnAracSec = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtAracTutar = new System.Windows.Forms.TextBox();
            this.btnMaasOdeme = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtToplamOdeme = new System.Windows.Forms.TextBox();
            this.lblPrim = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.btnAracOdemeAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdemeAl.BackColor = System.Drawing.Color.Transparent;
            this.btnOdemeAl.FlatAppearance.BorderSize = 0;
            this.btnOdemeAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOdemeAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeAl.Image")));
            this.btnOdemeAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdemeAl.Location = new System.Drawing.Point(527, 38);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(133, 40);
            this.btnOdemeAl.TabIndex = 131;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Visible = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // lblAlınan
            // 
            this.lblAlınan.AutoSize = true;
            this.lblAlınan.Location = new System.Drawing.Point(251, 153);
            this.lblAlınan.Name = "lblAlınan";
            this.lblAlınan.Size = new System.Drawing.Size(94, 20);
            this.lblAlınan.TabIndex = 129;
            this.lblAlınan.Text = "Alınan Tutar";
            this.lblAlınan.Visible = false;
            // 
            // txtAlınan
            // 
            this.txtAlınan.Location = new System.Drawing.Point(351, 153);
            this.txtAlınan.Name = "txtAlınan";
            this.txtAlınan.Size = new System.Drawing.Size(96, 26);
            this.txtAlınan.TabIndex = 128;
            this.txtAlınan.Visible = false;
            this.txtAlınan.TextChanged += new System.EventHandler(this.txtAlınan_TextChanged);
            // 
            // dgvOdeme
            // 
            this.dgvOdeme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOdeme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOdeme.BackgroundColor = System.Drawing.Color.White;
            this.dgvOdeme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdeme.Location = new System.Drawing.Point(12, 206);
            this.dgvOdeme.Name = "dgvOdeme";
            this.dgvOdeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdeme.Size = new System.Drawing.Size(493, 260);
            this.dgvOdeme.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 24);
            this.panel1.TabIndex = 130;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(676, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(24, 22);
            this.btnCikis.TabIndex = 88;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 133;
            this.label5.Text = "İşlem Türü Seçin";
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "Tahsilat",
            "Ödeme"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(16, 76);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(163, 28);
            this.cbIslemTurleri.TabIndex = 132;
            this.cbIslemTurleri.SelectedIndexChanged += new System.EventHandler(this.cbIslemTurleri_SelectedIndexChanged);
            // 
            // lblborc
            // 
            this.lblborc.AutoSize = true;
            this.lblborc.Location = new System.Drawing.Point(478, 153);
            this.lblborc.Name = "lblborc";
            this.lblborc.Size = new System.Drawing.Size(86, 20);
            this.lblborc.TabIndex = 135;
            this.lblborc.Text = "Kalan Borç";
            this.lblborc.Visible = false;
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(570, 153);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.ReadOnly = true;
            this.txtBorc.Size = new System.Drawing.Size(116, 26);
            this.txtBorc.TabIndex = 134;
            this.txtBorc.Visible = false;
            // 
            // lblsozlesme
            // 
            this.lblsozlesme.AutoSize = true;
            this.lblsozlesme.Location = new System.Drawing.Point(8, 156);
            this.lblsozlesme.Name = "lblsozlesme";
            this.lblsozlesme.Size = new System.Drawing.Size(123, 20);
            this.lblsozlesme.TabIndex = 137;
            this.lblsozlesme.Text = "Sözleşme Tutarı";
            this.lblsozlesme.Visible = false;
            // 
            // txtSozlesmeTutar
            // 
            this.txtSozlesmeTutar.Location = new System.Drawing.Point(137, 156);
            this.txtSozlesmeTutar.Name = "txtSozlesmeTutar";
            this.txtSozlesmeTutar.ReadOnly = true;
            this.txtSozlesmeTutar.Size = new System.Drawing.Size(96, 26);
            this.txtSozlesmeTutar.TabIndex = 136;
            this.txtSozlesmeTutar.Visible = false;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdemeYap.BackColor = System.Drawing.Color.Transparent;
            this.btnOdemeYap.FlatAppearance.BorderSize = 0;
            this.btnOdemeYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOdemeYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeYap.Image")));
            this.btnOdemeYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdemeYap.Location = new System.Drawing.Point(527, 38);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(149, 40);
            this.btnOdemeYap.TabIndex = 138;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Visible = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnSozlesmeSec
            // 
            this.btnSozlesmeSec.BackColor = System.Drawing.Color.Transparent;
            this.btnSozlesmeSec.FlatAppearance.BorderSize = 0;
            this.btnSozlesmeSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSozlesmeSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSozlesmeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSozlesmeSec.Image = ((System.Drawing.Image)(resources.GetObject("btnSozlesmeSec.Image")));
            this.btnSozlesmeSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSozlesmeSec.Location = new System.Drawing.Point(16, 110);
            this.btnSozlesmeSec.Name = "btnSozlesmeSec";
            this.btnSozlesmeSec.Size = new System.Drawing.Size(167, 40);
            this.btnSozlesmeSec.TabIndex = 139;
            this.btnSozlesmeSec.Text = "Sözleşme Seç";
            this.btnSozlesmeSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSozlesmeSec.UseVisualStyleBackColor = false;
            this.btnSozlesmeSec.Visible = false;
            this.btnSozlesmeSec.Click += new System.EventHandler(this.btnSozlesmeSec_Click);
            // 
            // btnAracSec
            // 
            this.btnAracSec.BackColor = System.Drawing.Color.Transparent;
            this.btnAracSec.FlatAppearance.BorderSize = 0;
            this.btnAracSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAracSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAracSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracSec.Image = ((System.Drawing.Image)(resources.GetObject("btnAracSec.Image")));
            this.btnAracSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracSec.Location = new System.Drawing.Point(16, 110);
            this.btnAracSec.Name = "btnAracSec";
            this.btnAracSec.Size = new System.Drawing.Size(134, 40);
            this.btnAracSec.TabIndex = 140;
            this.btnAracSec.Text = "Araç Seç";
            this.btnAracSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracSec.UseVisualStyleBackColor = false;
            this.btnAracSec.Visible = false;
            this.btnAracSec.Click += new System.EventHandler(this.btnAracSec_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(12, 156);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(46, 20);
            this.lblTutar.TabIndex = 142;
            this.lblTutar.Text = "Tutar";
            this.lblTutar.Visible = false;
            // 
            // txtAracTutar
            // 
            this.txtAracTutar.Location = new System.Drawing.Point(64, 156);
            this.txtAracTutar.Name = "txtAracTutar";
            this.txtAracTutar.Size = new System.Drawing.Size(96, 26);
            this.txtAracTutar.TabIndex = 141;
            this.txtAracTutar.Visible = false;
            // 
            // btnMaasOdeme
            // 
            this.btnMaasOdeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaasOdeme.BackColor = System.Drawing.Color.Transparent;
            this.btnMaasOdeme.FlatAppearance.BorderSize = 0;
            this.btnMaasOdeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMaasOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaasOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasOdeme.Image = ((System.Drawing.Image)(resources.GetObject("btnMaasOdeme.Image")));
            this.btnMaasOdeme.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaasOdeme.Location = new System.Drawing.Point(289, 39);
            this.btnMaasOdeme.Name = "btnMaasOdeme";
            this.btnMaasOdeme.Size = new System.Drawing.Size(149, 40);
            this.btnMaasOdeme.TabIndex = 177;
            this.btnMaasOdeme.Text = "Ödeme Yap";
            this.btnMaasOdeme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaasOdeme.UseVisualStyleBackColor = false;
            this.btnMaasOdeme.Visible = false;
            this.btnMaasOdeme.Click += new System.EventHandler(this.btnMaasOdeme_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Transparent;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.Image")));
            this.btnSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSec.Location = new System.Drawing.Point(16, 110);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(167, 40);
            this.btnSec.TabIndex = 176;
            this.btnSec.Text = "Personel Seç";
            this.btnSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(218, 150);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(61, 20);
            this.lblToplam.TabIndex = 175;
            this.lblToplam.Text = "Toplam";
            // 
            // txtToplamOdeme
            // 
            this.txtToplamOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamOdeme.Location = new System.Drawing.Point(289, 150);
            this.txtToplamOdeme.Name = "txtToplamOdeme";
            this.txtToplamOdeme.ReadOnly = true;
            this.txtToplamOdeme.Size = new System.Drawing.Size(158, 26);
            this.txtToplamOdeme.TabIndex = 174;
            // 
            // lblPrim
            // 
            this.lblPrim.AutoSize = true;
            this.lblPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrim.Location = new System.Drawing.Point(464, 101);
            this.lblPrim.Name = "lblPrim";
            this.lblPrim.Size = new System.Drawing.Size(40, 20);
            this.lblPrim.TabIndex = 173;
            this.lblPrim.Text = "Prim";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(464, 72);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(48, 20);
            this.lblMaas.TabIndex = 172;
            this.lblMaas.Text = "Maaş";
            // 
            // txtPrim
            // 
            this.txtPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrim.Location = new System.Drawing.Point(527, 101);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(158, 26);
            this.txtPrim.TabIndex = 171;
            this.txtPrim.TextChanged += new System.EventHandler(this.txtPrim_TextChanged);
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Location = new System.Drawing.Point(527, 72);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.ReadOnly = true;
            this.txtMaas.Size = new System.Drawing.Size(158, 26);
            this.txtMaas.TabIndex = 170;
            this.txtMaas.TextChanged += new System.EventHandler(this.txtMaas_TextChanged);
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.Location = new System.Drawing.Point(226, 101);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(57, 20);
            this.lblSoyadi.TabIndex = 169;
            this.lblSoyadi.Text = "Soyadı";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(226, 72);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(32, 20);
            this.lblAdi.TabIndex = 168;
            this.lblAdi.Text = "Adı";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(289, 101);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(158, 26);
            this.txtSoyadi.TabIndex = 167;
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(289, 72);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(158, 26);
            this.txtAdi.TabIndex = 166;
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonel.Location = new System.Drawing.Point(226, 39);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(79, 20);
            this.lblPersonel.TabIndex = 165;
            this.lblPersonel.Text = "Personel";
            // 
            // btnAracOdemeAl
            // 
            this.btnAracOdemeAl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAracOdemeAl.BackColor = System.Drawing.Color.Transparent;
            this.btnAracOdemeAl.FlatAppearance.BorderSize = 0;
            this.btnAracOdemeAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAracOdemeAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAracOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracOdemeAl.Image = ((System.Drawing.Image)(resources.GetObject("btnAracOdemeAl.Image")));
            this.btnAracOdemeAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracOdemeAl.Location = new System.Drawing.Point(527, 38);
            this.btnAracOdemeAl.Name = "btnAracOdemeAl";
            this.btnAracOdemeAl.Size = new System.Drawing.Size(133, 40);
            this.btnAracOdemeAl.TabIndex = 178;
            this.btnAracOdemeAl.Text = "Ödeme Al";
            this.btnAracOdemeAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracOdemeAl.UseVisualStyleBackColor = false;
            this.btnAracOdemeAl.Visible = false;
            this.btnAracOdemeAl.Click += new System.EventHandler(this.btnAracOdemeAl_Click);
            // 
            // frmOdemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 478);
            this.Controls.Add(this.btnMaasOdeme);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblPrim);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.txtPrim);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnAracSec);
            this.Controls.Add(this.btnSozlesmeSec);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.txtSozlesmeTutar);
            this.Controls.Add(this.lblborc);
            this.Controls.Add(this.txtBorc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbIslemTurleri);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.lblAlınan);
            this.Controls.Add(this.txtAlınan);
            this.Controls.Add(this.dgvOdeme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAracTutar);
            this.Controls.Add(this.lblsozlesme);
            this.Controls.Add(this.txtToplamOdeme);
            this.Controls.Add(this.btnAracOdemeAl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOdemeIslemleri";
            this.Text = "frmOdemeIslemleri";
            this.Load += new System.EventHandler(this.frmOdemeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Label lblAlınan;
        private System.Windows.Forms.TextBox txtAlınan;
        private System.Windows.Forms.DataGridView dgvOdeme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.Label lblborc;
        private System.Windows.Forms.TextBox txtBorc;
        private System.Windows.Forms.Label lblsozlesme;
        private System.Windows.Forms.TextBox txtSozlesmeTutar;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnSozlesmeSec;
        private System.Windows.Forms.Button btnAracSec;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtAracTutar;
        private System.Windows.Forms.Button btnMaasOdeme;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox txtToplamOdeme;
        private System.Windows.Forms.Label lblPrim;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Button btnAracOdemeAl;
    }
}