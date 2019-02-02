namespace PL.RentACar
{
    partial class frmAracSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracSorgulama));
            this.label2 = new System.Windows.Forms.Label();
            this.lvDetaylar = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitmLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmList = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmTile = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmView.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marka";
            // 
            // lvDetaylar
            // 
            this.lvDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDetaylar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDetaylar.ContextMenuStrip = this.cmView;
            this.lvDetaylar.FullRowSelect = true;
            this.lvDetaylar.Location = new System.Drawing.Point(12, 105);
            this.lvDetaylar.Name = "lvDetaylar";
            this.lvDetaylar.Size = new System.Drawing.Size(655, 285);
            this.lvDetaylar.TabIndex = 10;
            this.lvDetaylar.UseCompatibleStateImageBehavior = false;
            this.lvDetaylar.DoubleClick += new System.EventHandler(this.lvDetaylar_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Model";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tip";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Renk";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Plaka";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Durumu";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 100;
            // 
            // cmView
            // 
            this.cmView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmLargeIcon,
            this.mitmDetails,
            this.mitmSmallIcon,
            this.mitmList,
            this.mitmTile});
            this.cmView.Name = "cmView";
            this.cmView.Size = new System.Drawing.Size(130, 114);
            // 
            // mitmLargeIcon
            // 
            this.mitmLargeIcon.Name = "mitmLargeIcon";
            this.mitmLargeIcon.Size = new System.Drawing.Size(129, 22);
            this.mitmLargeIcon.Text = "Large Icon";
            this.mitmLargeIcon.Click += new System.EventHandler(this.mitmLargeIcon_Click);
            // 
            // mitmDetails
            // 
            this.mitmDetails.Name = "mitmDetails";
            this.mitmDetails.Size = new System.Drawing.Size(129, 22);
            this.mitmDetails.Text = "Details";
            this.mitmDetails.Click += new System.EventHandler(this.mitmDetails_Click);
            // 
            // mitmSmallIcon
            // 
            this.mitmSmallIcon.Name = "mitmSmallIcon";
            this.mitmSmallIcon.Size = new System.Drawing.Size(129, 22);
            this.mitmSmallIcon.Text = "Small Icon";
            this.mitmSmallIcon.Click += new System.EventHandler(this.mitmSmallIcon_Click);
            // 
            // mitmList
            // 
            this.mitmList.Name = "mitmList";
            this.mitmList.Size = new System.Drawing.Size(129, 22);
            this.mitmList.Text = "List";
            this.mitmList.Click += new System.EventHandler(this.mitmList_Click);
            // 
            // mitmTile
            // 
            this.mitmTile.Name = "mitmTile";
            this.mitmTile.Size = new System.Drawing.Size(129, 22);
            this.mitmTile.Text = "Tile";
            this.mitmTile.Click += new System.EventHandler(this.mitmTile_Click);
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbMarkalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkalar.DropDownWidth = 110;
            this.cbMarkalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Location = new System.Drawing.Point(196, 62);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(19, 26);
            this.cbMarkalar.TabIndex = 9;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Plaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Model";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(305, 62);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(134, 26);
            this.txtPlaka.TabIndex = 90;
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(534, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 26);
            this.textBox2.TabIndex = 91;
            // 
            // txtMarka
            // 
            this.txtMarka.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(71, 62);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(124, 26);
            this.txtMarka.TabIndex = 92;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(669, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 24);
            this.btnCikis.TabIndex = 88;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnCikis);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 24);
            this.panel4.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Araç Sorgulama";
            // 
            // frmAracSorgulama
            // 
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(694, 424);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvDetaylar);
            this.Controls.Add(this.cbMarkalar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAracSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAracSorgulama_Load);
            this.cmView.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvDetaylar;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.ContextMenuStrip cmView;
        private System.Windows.Forms.ToolStripMenuItem mitmLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem mitmDetails;
        private System.Windows.Forms.ToolStripMenuItem mitmSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem mitmList;
        private System.Windows.Forms.ToolStripMenuItem mitmTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
    }
}