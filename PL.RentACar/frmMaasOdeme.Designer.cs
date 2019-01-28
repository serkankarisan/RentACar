namespace PL.RentACar
{
    partial class frmMaasOdeme
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
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamOdeme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 154;
            this.label12.Text = "Soyadı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(110, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 153;
            this.label14.Text = "Adı";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(154, 49);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 152;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(154, 23);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 151;
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Location = new System.Drawing.Point(260, 16);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(103, 27);
            this.btnSec.TabIndex = 149;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(45, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 150;
            this.label21.Text = "Personel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 158;
            this.label1.Text = "Prim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 157;
            this.label2.Text = "Maaş";
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(154, 174);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(100, 20);
            this.txtPrim.TabIndex = 156;
            this.txtPrim.TextChanged += new System.EventHandler(this.txtPrim_TextChanged);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(154, 148);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.ReadOnly = true;
            this.txtMaas.Size = new System.Drawing.Size(100, 20);
            this.txtMaas.TabIndex = 155;
            this.txtMaas.TextChanged += new System.EventHandler(this.txtMaas_TextChanged);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdemeYap.FlatAppearance.BorderSize = 0;
            this.btnOdemeYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeYap.Location = new System.Drawing.Point(154, 226);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(103, 27);
            this.btnOdemeYap.TabIndex = 159;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "Toplam Ödeme";
            // 
            // txtToplamOdeme
            // 
            this.txtToplamOdeme.Location = new System.Drawing.Point(154, 200);
            this.txtToplamOdeme.Name = "txtToplamOdeme";
            this.txtToplamOdeme.ReadOnly = true;
            this.txtToplamOdeme.Size = new System.Drawing.Size(100, 20);
            this.txtToplamOdeme.TabIndex = 160;
            // 
            // frmMaasOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToplamOdeme);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrim);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label21);
            this.Name = "frmMaasOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaasOdeme";
            this.Load += new System.EventHandler(this.frmMaasOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamOdeme;
    }
}