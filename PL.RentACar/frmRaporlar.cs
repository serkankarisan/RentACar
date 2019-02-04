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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RentDataSetMusteri.vw_musteriler' table. You can move, or remove it, as needed.
            this.vw_musterilerTableAdapter.Fill(this.RentDataSetMusteri.vw_musteriler);
            //this.vw_musterilerTableAdapter.FillByMusteri(this.RentDataSetMusteri.vw_musteriler, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            // TODO: This line of code loads data into the 'RentACarDataSetMusteri.vw_musteriler' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'RentACarDataSet2.KasaHareketler' table. You can move, or remove it, as needed.
            this.KasaHareketlerTableAdapter.FillBykasa(this.RentACarDataSet2.KasaHareketler,basla,dtpBitis.Value);
            // TODO: This line of code loads data into the 'RentACarDataSet1.MusteriHareketler' table. You can move, or remove it, as needed.
            this.PersonellerTableAdapter.FillByPersonel(this.RentACarDataSet.Personeller,txtAd.Text.Trim(),txtSoyad.Text.Trim());
            // TODO: This line of code loads data into the 'RentACarDataSetArac.Araclar' table. You can move, or remove it, as needed.
            this.AraclarTableAdapter.Fill(this.RentACarDataSetArac.Araclar);
            this.reportViewer1.RefreshReport();
            tabControl1.SelectedIndex = 1;
            tabControl1.SelectedIndex = 0;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

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
                lblBaslangic.Visible = false;
                lblBitis.Visible = false;
                dtpBaslangic.Visible = false;
                dtpBitis.Visible = false;
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
                lblBaslangic.Visible = false;
                lblBitis.Visible = false;
                dtpBaslangic.Visible = false;
                dtpBitis.Visible = false;
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
                lblBaslangic.Visible = false;
                lblBitis.Visible = false;
                dtpBaslangic.Visible = false;
                dtpBitis.Visible = false;
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
                lblBaslangic.Visible = true;
                lblBitis.Visible = true;
                dtpBaslangic.Visible = true;
                dtpBitis.Visible = true;
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
                this.vw_musterilerTableAdapter.FillByMusteri(this.RentDataSetMusteri.vw_musteriler, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
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
                this.vw_musterilerTableAdapter.FillByMusteri(this.RentDataSetMusteri.vw_musteriler, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
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
                this.vw_musterilerTableAdapter.FillByMusteri(this.RentDataSetMusteri.vw_musteriler, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
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
                this.vw_musterilerTableAdapter.FillByMusteri(this.RentDataSetMusteri.vw_musteriler, txtAd.Text.Trim(), txtSoyad.Text.Trim(), txtTCKNo.Text.Trim(), txtEhliyetNo.Text.Trim());
                this.reportViewer3.RefreshReport();
            }
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            DateTime bit = Convert.ToDateTime(dtpBitis.Value.ToShortDateString());
            if (basla > bit)
            {
                dtpBaslangic.Value = DateTime.Now;
                dtpBitis.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");
            }
            else
            {
                this.KasaHareketlerTableAdapter.FillBykasa(this.RentACarDataSet2.KasaHareketler, basla, dtpBitis.Value);
                this.reportViewer4.RefreshReport();
            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            DateTime bit = Convert.ToDateTime(dtpBitis.Value.ToShortDateString());
            if (basla > bit)
            {
                dtpBitis.Value = DateTime.Now;
                dtpBaslangic.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");

            }
            else
            {
                this.KasaHareketlerTableAdapter.FillBykasa(this.RentACarDataSet2.KasaHareketler, basla, dtpBitis.Value);
                this.reportViewer4.RefreshReport();
            }
        }
    }
}
