using BLL.RentACar.Repositories;
using DAL.RentACar.Context;
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
    public partial class frmTeslimAl : Form
    {
        public frmTeslimAl()
        {
            InitializeComponent();
        }

        frmSozlesmeSorgulama frm = new frmSozlesmeSorgulama();
        SozlesmeDetayRepository sdr = new SozlesmeDetayRepository();
        int AracID;
        AracRepository ar = new AracRepository();
        Arac a = new Arac();
        decimal EkstraTutar = 0;
        int GunSayisi = 0;
        decimal GunlukFiyat = 0;
        private void btnSec_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();

            dgvSozlesmeDetay.DataSource = sdr.SozlesmeDetayListeleBySozlesmeId(Genel.SozID);
            txtAracSayisi.Text = dgvSozlesmeDetay.RowCount.ToString();
            txtSozlesmeTutari.Text = sdr.SozlesmeTutarGetirBySozlesmeId(Genel.SozID).ToString();
        }

        private void frmTeslimAl_Load(object sender, EventArgs e)
        {
      
        }

        private void dgvSozlesmeDetay_DoubleClick(object sender, EventArgs e)
        {
            AracID = Convert.ToInt32(dgvSozlesmeDetay.SelectedRows[0].Cells[2].Value);
            a = ar.AracGetirById(AracID);
            txtMarka.Text = a.Marka;
            txtModel.Text = a.Model;
            txtTip.Text = a.Tip;
            txtRenk.Text = a.Renk;
            txtPlakaNo.Text = a.Plaka;
            txtGunlukFiyat.Text = a.GünlükFiyat.ToString();
            txtAracDurumu.Text = a.AracDurumu;
            txtYakitDurumu.Text = a.YakitDurumu;
            GunlukFiyat = Convert.ToDecimal(txtGunlukFiyat.Text);
            txtAracSayisi.Text = dgvSozlesmeDetay.RowCount.ToString();
            txtSozlesmeTutari.Text = sdr.SozlesmeTutarGetirBySozlesmeId(Genel.SozID).ToString();

        }

        private void txtGunSayisi_TextChanged(object sender, EventArgs e)
        {
            GunSayisi = Convert.ToInt32(txtGunSayisi.Text);
            EkstraTutar = (GunSayisi * GunlukFiyat);
            txtEkstraTutar.Text = EkstraTutar.ToString();
        }
    }
}
