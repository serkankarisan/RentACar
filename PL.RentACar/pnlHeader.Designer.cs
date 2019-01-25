namespace PL.RentACar
{
    partial class pnlHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlHeader));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSimgeDurumu = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PL.RentACar.Properties.Resources.cooltext312921869210611;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = global::PL.RentACar.Properties.Resources.Double_J_Design_Origami_Colored_Pencil_Blue_cross;
            this.btnCikis.Location = new System.Drawing.Point(772, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 25);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSimgeDurumu
            // 
            this.btnSimgeDurumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimgeDurumu.BackColor = System.Drawing.Color.Transparent;
            this.btnSimgeDurumu.FlatAppearance.BorderSize = 0;
            this.btnSimgeDurumu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSimgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimgeDurumu.Image = ((System.Drawing.Image)(resources.GetObject("btnSimgeDurumu.Image")));
            this.btnSimgeDurumu.Location = new System.Drawing.Point(710, 3);
            this.btnSimgeDurumu.Name = "btnSimgeDurumu";
            this.btnSimgeDurumu.Size = new System.Drawing.Size(25, 25);
            this.btnSimgeDurumu.TabIndex = 11;
            this.btnSimgeDurumu.UseVisualStyleBackColor = false;
            this.btnSimgeDurumu.Click += new System.EventHandler(this.btnSimgeDurumu_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxMin.Image")));
            this.btnMaxMin.Location = new System.Drawing.Point(741, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(25, 25);
            this.btnMaxMin.TabIndex = 12;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // pnlHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnSimgeDurumu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pnlHeader";
            this.Size = new System.Drawing.Size(800, 30);
            this.Load += new System.EventHandler(this.pnlHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSimgeDurumu;
        private System.Windows.Forms.Button btnMaxMin;
    }
}
