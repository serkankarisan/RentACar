﻿namespace PL.RentACar
{
    partial class frmRaporlar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            this.AraclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentACarDataSetArac = new PL.RentACar.RentACarDataSetArac();
            this.PersonellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentACarDataSet = new PL.RentACar.RentACarDataSet();
            this.KasaHareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentACarDataSet2 = new PL.RentACar.RentACarDataSet2();
            this.view_musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentACarDataSetM = new PL.RentACar.RentACarDataSetM();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblEhNo = new System.Windows.Forms.Label();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.AraclarTableAdapter = new PL.RentACar.RentACarDataSetAracTableAdapters.AraclarTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.PersonellerTableAdapter = new PL.RentACar.RentACarDataSetTableAdapters.PersonellerTableAdapter();
            this.view_musteriTableAdapter = new PL.RentACar.RentACarDataSetMTableAdapters.view_musteriTableAdapter();
            this.KasaHareketlerTableAdapter = new PL.RentACar.RentACarDataSet2TableAdapters.KasaHareketlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AraclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSetArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaHareketlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSetM)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AraclarBindingSource
            // 
            this.AraclarBindingSource.DataMember = "Araclar";
            this.AraclarBindingSource.DataSource = this.RentACarDataSetArac;
            // 
            // RentACarDataSetArac
            // 
            this.RentACarDataSetArac.DataSetName = "RentACarDataSetArac";
            this.RentACarDataSetArac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonellerBindingSource
            // 
            this.PersonellerBindingSource.DataMember = "Personeller";
            this.PersonellerBindingSource.DataSource = this.RentACarDataSet;
            // 
            // RentACarDataSet
            // 
            this.RentACarDataSet.DataSetName = "RentACarDataSet";
            this.RentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KasaHareketlerBindingSource
            // 
            this.KasaHareketlerBindingSource.DataMember = "KasaHareketler";
            this.KasaHareketlerBindingSource.DataSource = this.RentACarDataSet2;
            // 
            // RentACarDataSet2
            // 
            this.RentACarDataSet2.DataSetName = "RentACarDataSet2";
            this.RentACarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_musteriBindingSource
            // 
            this.view_musteriBindingSource.DataMember = "view_musteri";
            this.view_musteriBindingSource.DataSource = this.RentACarDataSetM;
            // 
            // RentACarDataSetM
            // 
            this.RentACarDataSetM.DataSetName = "RentACarDataSetM";
            this.RentACarDataSetM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 372);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(763, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Araç Rapor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AraclarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PL.RentACar.Reports.AracRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(755, 329);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(763, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Rapor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PersonellerBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "PL.RentACar.Reports.PersonelRapor.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 5);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(755, 329);
            this.reportViewer2.TabIndex = 90;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(763, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Müşteri Rapor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.view_musteriBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "PL.RentACar.Reports.Report1.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(4, 5);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(755, 329);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(763, 339);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kasa Rapor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.KasaHareketlerBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "PL.RentACar.Reports.KasaRapor.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(763, 339);
            this.reportViewer4.TabIndex = 90;
            // 
            // lblEhNo
            // 
            this.lblEhNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEhNo.AutoSize = true;
            this.lblEhNo.Location = new System.Drawing.Point(555, 35);
            this.lblEhNo.Name = "lblEhNo";
            this.lblEhNo.Size = new System.Drawing.Size(80, 20);
            this.lblEhNo.TabIndex = 104;
            this.lblEhNo.Text = "Ehliyet No";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEhliyetNo.Location = new System.Drawing.Point(641, 35);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(96, 26);
            this.txtEhliyetNo.TabIndex = 103;
            this.txtEhliyetNo.TextChanged += new System.EventHandler(this.txtEhliyetNo_TextChanged);
            // 
            // lblTC
            // 
            this.lblTC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(330, 35);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(97, 20);
            this.lblTC.TabIndex = 102;
            this.lblTC.Text = "TC Kimlik No";
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(149, 35);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(54, 20);
            this.lblSoyad.TabIndex = 101;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(8, 35);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 20);
            this.lblAd.TabIndex = 100;
            this.lblAd.Text = "Ad";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTCKNo.Location = new System.Drawing.Point(433, 35);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(100, 26);
            this.txtTCKNo.TabIndex = 99;
            this.txtTCKNo.TextChanged += new System.EventHandler(this.txtTCKNo_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoyad.Location = new System.Drawing.Point(209, 35);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtSoyad.TabIndex = 98;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAd.Location = new System.Drawing.Point(43, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 97;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // AraclarTableAdapter
            // 
            this.AraclarTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Raporlama";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.lblEhNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEhliyetNo);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblTC);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.txtTCKNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 68);
            this.panel1.TabIndex = 89;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(743, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 22);
            this.button4.TabIndex = 88;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // PersonellerTableAdapter
            // 
            this.PersonellerTableAdapter.ClearBeforeFill = true;
            // 
            // view_musteriTableAdapter
            // 
            this.view_musteriTableAdapter.ClearBeforeFill = true;
            // 
            // KasaHareketlerTableAdapter
            // 
            this.KasaHareketlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(768, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AraclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSetArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaHareketlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSetM)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AraclarBindingSource;
        private RentACarDataSetArac RentACarDataSetArac;
        private RentACarDataSetAracTableAdapters.AraclarTableAdapter AraclarTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource PersonellerBindingSource;
        private RentACarDataSet RentACarDataSet;
        private RentACarDataSetTableAdapters.PersonellerTableAdapter PersonellerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource KasaHareketlerBindingSource;
        private RentACarDataSet2 RentACarDataSet2;
        private RentACarDataSet2TableAdapters.KasaHareketlerTableAdapter KasaHareketlerTableAdapter;
        private System.Windows.Forms.Label lblEhNo;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource view_musteriBindingSource;
        private RentACarDataSetM RentACarDataSetM;
        private RentACarDataSetMTableAdapters.view_musteriTableAdapter view_musteriTableAdapter;
    }
}