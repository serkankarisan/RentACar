namespace PL.RentACar
{
    partial class frmPersonelSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelSorgulama));
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(55, 102);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(147, 26);
            this.txtAdi.TabIndex = 10;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox8.BackColor = System.Drawing.Color.Azure;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(18, 63);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(363, 16);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "PERSONEL SORGULAMA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(236, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyad";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(302, 104);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(148, 26);
            this.txtSoyadi.TabIndex = 7;
            this.txtSoyadi.TextChanged += new System.EventHandler(this.txtSoyadi_TextChanged);
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvPersonel.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(18, 148);
            this.dgvPersonel.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonel.Size = new System.Drawing.Size(850, 225);
            this.dgvPersonel.TabIndex = 40;
            this.dgvPersonel.DoubleClick += new System.EventHandler(this.dgvPersonel_DoubleClick);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(855, 1);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 24);
            this.btnCikis.TabIndex = 88;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 25);
            this.panel2.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Personel Sorgulama";
            // 
            // frmPersonelSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(880, 390);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.txtSoyadi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPersonelSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPersonelSorgulama";
            this.Load += new System.EventHandler(this.frmPersonelSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}