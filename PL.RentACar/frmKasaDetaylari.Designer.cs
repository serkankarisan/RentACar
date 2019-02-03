namespace PL.RentACar
{
    partial class frmKasaDetaylari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaDetaylari));
            this.dgvKasaDetay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplamBakiye = new System.Windows.Forms.TextBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaDetay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKasaDetay
            // 
            this.dgvKasaDetay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvKasaDetay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKasaDetay.BackgroundColor = System.Drawing.Color.White;
            this.dgvKasaDetay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKasaDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaDetay.Location = new System.Drawing.Point(16, 162);
            this.dgvKasaDetay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKasaDetay.Name = "dgvKasaDetay";
            this.dgvKasaDetay.Size = new System.Drawing.Size(510, 254);
            this.dgvKasaDetay.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Toplam Bakiye";
            // 
            // txtToplamBakiye
            // 
            this.txtToplamBakiye.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtToplamBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToplamBakiye.Location = new System.Drawing.Point(370, 434);
            this.txtToplamBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtToplamBakiye.Name = "txtToplamBakiye";
            this.txtToplamBakiye.Size = new System.Drawing.Size(148, 26);
            this.txtToplamBakiye.TabIndex = 96;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBaslangic.Location = new System.Drawing.Point(14, 119);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(240, 26);
            this.dtpBaslangic.TabIndex = 98;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBitis.Location = new System.Drawing.Point(290, 119);
            this.dtpBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(237, 26);
            this.dtpBitis.TabIndex = 99;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Tarih Aralığı Seçin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 25);
            this.panel1.TabIndex = 160;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 89;
            this.label5.Text = "Kasa Detayları";
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(526, 0);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 24);
            this.btnCikis.TabIndex = 88;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 161;
            this.label3.Text = "Başlangıç Tarihi Seçin";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 162;
            this.label4.Text = "Bitiş Tarihi Seçin";
            // 
            // frmKasaDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(551, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamBakiye);
            this.Controls.Add(this.dgvKasaDetay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKasaDetaylari";
            this.Text = "frmKasaDetaylari";
            this.Load += new System.EventHandler(this.frmKasaDetaylari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaDetay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKasaDetay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamBakiye;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}