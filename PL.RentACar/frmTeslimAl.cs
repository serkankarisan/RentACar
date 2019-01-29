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
        MusteriHareket mh = new MusteriHareket();
        MusteriHareketRepository mhr = new MusteriHareketRepository();
        int SozlesmeDetayId;
        private void btnSec_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();

            dgvSozlesmeDetay.DataSource = sdr.SozlesmeDetayListeleBySozlesmeId(Genel.SozID);
            txtAracSayisi.Text = dgvSozlesmeDetay.RowCount.ToString();
            txtSozlesmeTutari.Text = sdr.SozlesmeTutarGetirBySozlesmeId(Genel.SozID).ToString();
        }

        private void frmTeslimAl_Load(object sender, EventArgs e)
        {
            rdnYes.Checked = true;
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
            SozlesmeDetayId= Convert.ToInt32(dgvSozlesmeDetay.SelectedRows[0].Cells[0].Value);

        }

        private void txtGunSayisi_TextChanged(object sender, EventArgs e)
        {
            if (txtGunSayisi.Text != "")
            {
                GunSayisi = Convert.ToInt32(txtGunSayisi.Text);
                EkstraTutar = (GunSayisi * GunlukFiyat);
                txtEkstraTutar.Text = EkstraTutar.ToString();
            }
            else if(txtGunSayisi.Text=="")
            {
                txtEkstraTutar.Text = "";
                txtGunSayisi.Text="";
            }
            
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (txtGunSayisi.Text.Trim() != "" && cbAracDurumu.Text.Trim() != "" && cbYakitDurumu.Text.Trim() != "")
            {
                mh.Tarih = DateTime.Now;
                mh.MusteriId = Genel.MusteriId;
                mh.ParaBirimi = "TL";
                mh.MusteriGetirisi = Convert.ToDecimal(txtEkstraTutar.Text);
                mh.MusteriGetiriTuru = "Ekstra Kiralama";
                mh.Silindi = false;
                if (txtAracDurumu.Text.Trim() == cbAracDurumu.Text.Trim() && txtYakitDurumu.Text.Trim() == cbYakitDurumu.Text.Trim())
                {
                    mh.MusteriPuanı = 10;
                }
                else if (txtAracDurumu.Text == "Hasar Yok" && cbAracDurumu.Text == "Hasar Yok" && txtYakitDurumu.Text == "%100" && cbYakitDurumu.Text == "75")
                {
                    mh.MusteriPuanı = 8;
                }
                else if (txtAracDurumu.Text == "Hasar Yok" && cbAracDurumu.Text == "Hasar Yok" && txtYakitDurumu.Text == "%100" && cbYakitDurumu.Text == "50")
                {
                    mh.MusteriPuanı = 7;
                }
                else if (txtAracDurumu.Text == "Hasar Yok" && cbAracDurumu.Text == "Hasar Yok" && txtYakitDurumu.Text == "%100" && cbYakitDurumu.Text == "25")
                {
                    mh.MusteriPuanı = 6;
                }
                else if (txtAracDurumu.Text == "Hasar Yok" && cbAracDurumu.Text == "Hasar Yok" && txtYakitDurumu.Text == "%75" && cbYakitDurumu.Text == "50")
                {
                    mh.MusteriPuanı = 8;
                }
                else if (txtAracDurumu.Text == "Hasar Yok" && cbAracDurumu.Text == "Hasar Yok" && txtYakitDurumu.Text == "%75" && cbYakitDurumu.Text == "25")
                {
                    mh.MusteriPuanı = 7;
                }
                else if (txtAracDurumu.Text == "Hasar Yok" && cbAracDurumu.Text == "Hasar Yok" && txtYakitDurumu.Text == "%50" && cbYakitDurumu.Text == "25")
                {
                    mh.MusteriPuanı = 8;
                }
                else if (txtAracDurumu.Text.Trim() != cbAracDurumu.Text.Trim())
                {
                    mh.MusteriPuanı = 5;
                }

                mhr.MusteriHareketEkle(mh);

                sdr.SozlesmeDetaySil(SozlesmeDetayId);
                dgvSozlesmeDetay.DataSource = sdr.SozlesmeDetayListeleBySozlesmeId(Genel.SozID);
                MessageBox.Show("Arac Teslim Alindi");
            }
            else
            {
                MessageBox.Show("Bos alanlari doldurunuz!!!");
            }

        }
    }
}
