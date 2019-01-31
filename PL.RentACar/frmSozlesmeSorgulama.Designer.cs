namespace PL.RentACar
{
    partial class frmSozlesmeSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSozlesmeSorgulama));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.dgvSozlesmeler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.txtSozlesmeId = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEhliyetNo2 = new System.Windows.Forms.TextBox();
            this.dgvSozlesmeDetay = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTckNo2 = new System.Windows.Forms.TextBox();
            this.txtSozlesmeId2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeDetay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 477);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtEhliyetNo);
            this.tabPage1.Controls.Add(this.dgvSozlesmeler);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTCKNo);
            this.tabPage1.Controls.Add(this.txtSozlesmeId);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(872, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sozlesmeler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Ehliyet No";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(490, 73);
            this.txtEhliyetNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(148, 26);
            this.txtEhliyetNo.TabIndex = 102;
            this.txtEhliyetNo.TextChanged += new System.EventHandler(this.txtEhliyetNo_TextChanged);
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
            this.dgvSozlesmeler.Location = new System.Drawing.Point(22, 122);
            this.dgvSozlesmeler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSozlesmeler.Name = "dgvSozlesmeler";
            this.dgvSozlesmeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSozlesmeler.Size = new System.Drawing.Size(832, 288);
            this.dgvSozlesmeler.TabIndex = 101;
            this.dgvSozlesmeler.DoubleClick += new System.EventHandler(this.dgvSozlesmeler_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "TC Kimlik No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Sözleşme Id";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(256, 73);
            this.txtTCKNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(148, 26);
            this.txtTCKNo.TabIndex = 98;
            this.txtTCKNo.TextChanged += new System.EventHandler(this.txtTCKNo_TextChanged);
            // 
            // txtSozlesmeId
            // 
            this.txtSozlesmeId.Location = new System.Drawing.Point(22, 73);
            this.txtSozlesmeId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSozlesmeId.Name = "txtSozlesmeId";
            this.txtSozlesmeId.Size = new System.Drawing.Size(148, 26);
            this.txtSozlesmeId.TabIndex = 97;
            this.txtSozlesmeId.TextChanged += new System.EventHandler(this.txtSozlesmeId_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtpBitis);
            this.tabPage2.Controls.Add(this.dtpBaslangıc);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtEhliyetNo2);
            this.tabPage2.Controls.Add(this.dgvSozlesmeDetay);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtTckNo2);
            this.tabPage2.Controls.Add(this.txtSozlesmeId2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(872, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sozlesme Detayları";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(337, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 115;
            this.label9.Text = "Bitiş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "Başlangıç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Tarih aralığı seçin";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(341, 61);
            this.dtpBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(297, 26);
            this.dtpBitis.TabIndex = 112;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // dtpBaslangıc
            // 
            this.dtpBaslangıc.Location = new System.Drawing.Point(8, 61);
            this.dtpBaslangıc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBaslangıc.Name = "dtpBaslangıc";
            this.dtpBaslangıc.Size = new System.Drawing.Size(297, 26);
            this.dtpBaslangıc.TabIndex = 111;
            this.dtpBaslangıc.ValueChanged += new System.EventHandler(this.dtpBaslangıc_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "Ehliyet No";
            // 
            // txtEhliyetNo2
            // 
            this.txtEhliyetNo2.Location = new System.Drawing.Point(490, 143);
            this.txtEhliyetNo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtEhliyetNo2.Name = "txtEhliyetNo2";
            this.txtEhliyetNo2.Size = new System.Drawing.Size(148, 26);
            this.txtEhliyetNo2.TabIndex = 109;
            this.txtEhliyetNo2.TextChanged += new System.EventHandler(this.txtEhliyetNo2_TextChanged);
            // 
            // dgvSozlesmeDetay
            // 
            this.dgvSozlesmeDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSozlesmeDetay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSozlesmeDetay.BackgroundColor = System.Drawing.Color.White;
            this.dgvSozlesmeDetay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSozlesmeDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSozlesmeDetay.Location = new System.Drawing.Point(8, 177);
            this.dgvSozlesmeDetay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSozlesmeDetay.Name = "dgvSozlesmeDetay";
            this.dgvSozlesmeDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSozlesmeDetay.Size = new System.Drawing.Size(856, 251);
            this.dgvSozlesmeDetay.TabIndex = 108;
            this.dgvSozlesmeDetay.DoubleClick += new System.EventHandler(this.dgvSozlesmeDetay_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "TC Kimlik No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Sözleşme Id";
            // 
            // txtTckNo2
            // 
            this.txtTckNo2.Location = new System.Drawing.Point(249, 143);
            this.txtTckNo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTckNo2.Name = "txtTckNo2";
            this.txtTckNo2.Size = new System.Drawing.Size(148, 26);
            this.txtTckNo2.TabIndex = 105;
            this.txtTckNo2.TextChanged += new System.EventHandler(this.txtTckNo2_TextChanged);
            // 
            // txtSozlesmeId2
            // 
            this.txtSozlesmeId2.Location = new System.Drawing.Point(8, 143);
            this.txtSozlesmeId2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSozlesmeId2.Name = "txtSozlesmeId2";
            this.txtSozlesmeId2.Size = new System.Drawing.Size(148, 26);
            this.txtSozlesmeId2.TabIndex = 104;
            this.txtSozlesmeId2.TextChanged += new System.EventHandler(this.txtSozlesmeId2_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(864, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 25);
            this.panel1.TabIndex = 0;
            // 
            // frmSozlesmeSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(889, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSozlesmeSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSozlesmeSorgulama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSozlesmeSorgulama_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozlesmeDetay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.DataGridView dgvSozlesmeler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.TextBox txtSozlesmeId;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEhliyetNo2;
        private System.Windows.Forms.DataGridView dgvSozlesmeDetay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTckNo2;
        private System.Windows.Forms.TextBox txtSozlesmeId2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangıc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}