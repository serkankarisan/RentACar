using BLL.RentACar.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.RentACar
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }
        KasaHareketRepository khr = new KasaHareketRepository();

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            txtAd.Visible = false;
            txtSoyad.Visible = false;
            txtTCKNo.Visible = false;
            txtEhliyetNo.Visible = false;
            lblAd.Visible = false;
            lblSoyad.Visible = false;
            lblTC.Visible = false;
            lblEhNo.Visible = false;
            // TODO: This line of code loads data into the 'RentACarDataSetM.view_musteri' table. You can move, or remove it, as needed.
            this.view_musteriTableAdapter.Fill(this.RentACarDataSetM.view_musteri);
            // TODO: This line of code loads data into the 'RentACarDataSet2.KasaHareketler' table. You can move, or remove it, as needed.
            this.KasaHareketlerTableAdapter.Fill(this.RentACarDataSet2.KasaHareketler);
            // TODO: This line of code loads data into the 'RentACarDataSet1.MusteriHareketler' table. You can move, or remove it, as needed.
            this.PersonellerTableAdapter.FillByPersonel(this.RentACarDataSet.Personeller,txtAd.Text.Trim(),txtSoyad.Text.Trim());
            // TODO: This line of code loads data into the 'RentACarDataSetArac.Araclar' table. You can move, or remove it, as needed.
            this.AraclarTableAdapter.Fill(this.RentACarDataSetArac.Araclar);
            this.reportViewer1.RefreshReport();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                this.reportViewer1.RefreshReport();
                txtAd.Visible = false;
                txtSoyad.Visible = false;
                txtTCKNo.Visible = false;
                txtEhliyetNo.Visible = false;
                lblAd.Visible = false;
                lblSoyad.Visible = false;
                lblTC.Visible = false;
                lblEhNo.Visible = false;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtAd.Visible = true;
                txtSoyad.Visible = true;
                lblAd.Visible = true;
                lblSoyad.Visible = true;
                lblTC.Visible = false;
                lblEhNo.Visible = false;
                txtTCKNo.Visible = false;
                txtEhliyetNo.Visible = false;
                this.reportViewer2.RefreshReport();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                txtAd.Visible = true;
                txtSoyad.Visible = true;
                txtTCKNo.Visible = true;
                txtEhliyetNo.Visible = true;
                lblAd.Visible = true;
                lblSoyad.Visible = true;
                lblTC.Visible = true;
                lblEhNo.Visible = true;
                this.reportViewer3.RefreshReport();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                txtAd.Visible = false;
                txtSoyad.Visible = false;
                lblAd.Visible = false;
                lblSoyad.Visible = false;
                lblTC.Visible = false;
                lblEhNo.Visible = false;
                txtTCKNo.Visible = false;
                txtEhliyetNo.Visible = false;
                this.reportViewer4.RefreshReport();
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                this.PersonellerTableAdapter.FillByPersonel(this.RentACarDataSet.Personeller, txtAd.Text.Trim(), txtSoyad.Text.Trim());
                this.reportViewer2.RefreshReport();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.view_musteriTableAdapter.FillByMustri(this.RentACarDataSetM.view_musteri,txtAd.Text.Trim(),txtSoyad.Text.Trim(),txtTCKNo.Text.Trim(),txtEhliyetNo.Text.Trim());
                this.reportViewer3.RefreshReport();
            }
           
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                this.PersonellerTableAdapter.FillByPersonel(this.RentACarDataSet.Personeller, txtAd.Text.Trim(), txtSoyad.Text.Trim());
                this.reportViewer2.RefreshReport();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.view_musteriTableAdapter.FillByMustri(this.RentACarDataSetM.view_musteri, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
                this.reportViewer3.RefreshReport();
            }
        }

        private void txtTCKNo_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                this.PersonellerTableAdapter.FillByPersonel(this.RentACarDataSet.Personeller, txtAd.Text.Trim(), txtSoyad.Text.Trim());
                this.reportViewer2.RefreshReport();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.view_musteriTableAdapter.FillByMustri(this.RentACarDataSetM.view_musteri, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
                this.reportViewer3.RefreshReport();
            }
        }
        private void txtEhliyetNo_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                this.PersonellerTableAdapter.FillByPersonel(this.RentACarDataSet.Personeller, txtAd.Text.Trim(), txtSoyad.Text.Trim());
                this.reportViewer2.RefreshReport();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.view_musteriTableAdapter.FillByMustri(this.RentACarDataSetM.view_musteri, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
                this.reportViewer3.RefreshReport();
            }
        }

    }
}
