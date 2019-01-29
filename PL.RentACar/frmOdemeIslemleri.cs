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
    public partial class frmOdemeIslemleri : Form
    {
        public frmOdemeIslemleri()
        {
            InitializeComponent();
        }
        GelirGiderRepository ggrepo = new GelirGiderRepository();
        decimal ToplamMaas = 0;
        decimal ToplamPirim = 0;
        decimal Total = 0;
        frmPersonelSorgulama frm = new frmPersonelSorgulama();
        PersonelRepository pr = new PersonelRepository();
        KasaHareketRepository khr = new KasaHareketRepository();
        Personel p = new Personel();
        private void btnSec_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            p = pr.PersonelGetirById(Genel.PersonelID);
            txtAdi.Text = p.Adi;
            txtSoyadi.Text = p.Soyadi;
            txtMaas.Text = p.Maas.ToString();

        }



        private void txtMaas_TextChanged(object sender, EventArgs e)
        {
            ToplamMaas = Convert.ToDecimal(txtMaas.Text);
            Total = ToplamMaas + ToplamPirim;
            txtToplamOdeme.Text = Total.ToString();
        }

        private void txtPrim_TextChanged(object sender, EventArgs e)
        {
            ToplamPirim = Convert.ToDecimal(txtPrim.Text);
            Total = ToplamMaas + ToplamPirim;
            txtToplamOdeme.Text = Total.ToString();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            GelirGider g = (GelirGider)cbIslemTurleri.SelectedItem;
            if (g.Tür=="Gelir" && g.Aciklama.Contains("arac"))
            {
                AracGoster();
                btnAracOdemeAl.Visible = true;
                btnOdemeYap.Visible = false;
                PersonelGizle();
                SozlesmeGizle();
            }
            else if(g.Tür=="Gider" && g.Aciklama== "Maaş Ödeme")
            {
                PersonelGoster();
                AracGizle();
                SozlesmeGizle();
            }
            else if (g.Tür == "Gelir" && !g.Aciklama.Contains("arac"))
            {
                SozlesmeGoster();
                AracGizle();
                PersonelGizle();
            }
            else if (g.Tür == "Gider" && g.Aciklama != "Maaş Ödeme")
            {
                AracGoster();
                PersonelGizle();
                SozlesmeGizle();
                btnOdemeYap.Visible = true;
                btnAracOdemeAl.Visible = false;
            }
            Listele();
        }

        private void frmOdemeIslemleri_Load(object sender, EventArgs e)
        {
            cbIslemTurleri.DataSource = ggrepo.GelirGiderLİstele();
            Listele();
        }

        private void PersonelGizle()
        {
            lblPersonel.Visible = false;
            lblMaas.Visible = false;
            lblPrim.Visible = false;
            lblAdi.Visible = false;
            lblSoyadi.Visible = false;
            lblToplam.Visible = false;
            btnSec.Visible = false;
            btnMaasOdeme.Visible = false;
            txtAdi.Visible = false;
            txtSoyadi.Visible = false;
            txtPrim.Visible = false;
            txtMaas.Visible = false;
            txtToplamOdeme.Visible = false;
        }
        private void PersonelGoster()
        {
            lblPersonel.Visible = true;
            lblMaas.Visible = true;
            lblPrim.Visible = true;
            lblAdi.Visible = true;
            lblSoyadi.Visible = true;
            lblToplam.Visible = true;
            btnSec.Visible = true;
            btnMaasOdeme.Visible = true;
            txtAdi.Visible = true;
            txtSoyadi.Visible = true;
            txtPrim.Visible = true;
            txtMaas.Visible = true;
            txtToplamOdeme.Visible = true;
        }
        private void AracGizle()
        {
            lblTutar.Visible = false;
            btnOdemeYap.Visible = false;
            txtAracTutar.Visible = false;
            btnAracSec.Visible = false;
            btnAracOdemeAl.Visible = false;
        }
        private void AracGoster()
        {
            lblTutar.Visible = true;
            txtAracTutar.Visible = true;
            btnAracSec.Visible = true;
        }
        private void SozlesmeGizle()
        {
            txtSozlesmeTutar.Visible = false;
            txtAlınan.Visible = false;
            txtBorc.Visible = false;
            btnSozlesmeSec.Visible = false;
            btnOdemeAl.Visible = false;
            lblAlınan.Visible = false;
            lblborc.Visible = false;
            lblsozlesme.Visible = false;
        }
        private void SozlesmeGoster()
        {
            txtSozlesmeTutar.Visible = true;
            txtAlınan.Visible = true;
            txtBorc.Visible = true;
            btnSozlesmeSec.Visible = true;
            btnOdemeAl.Visible = true;
            lblAlınan.Visible = true;
            lblborc.Visible = true;
            lblsozlesme.Visible = true;
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {

        }
        private void btnOdemeAl_Click(object sender, EventArgs e)
        {

        }

        private void btnAracSec_Click(object sender, EventArgs e)
        {

        }

        private void btnSozlesmeSec_Click(object sender, EventArgs e)
        {

        }

        private void btnAracOdemeAl_Click(object sender, EventArgs e)
        {

        }
        //arac satışa dikkat hatalar var.
        private void btnMaasOdeme_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && (txtMaas.Text.Trim() != "" || txtPrim.Text.Trim() != ""))
            {
                KasaHareket kh = new KasaHareket();
                kh.AracId = 0;
                kh.SozlesmeId = 0;
                kh.PersonelId = Genel.PersonelID;
                kh.Tarih = DateTime.Now;
                kh.GelirGiderId = 1;
                kh.Tutar = txtMaas.Text;
                kh.ParaBirimi = "TL";
                kh.Silindi = false;
                if (khr.KasaHareketEkle(kh))
                {
                    MessageBox.Show("Maaş Ödendi.", "Kayıt gerçekleşti.");
                    txtAdi.Clear();
                    txtSoyadi.Clear();
                    txtPrim.Clear();
                    txtMaas.Clear();
                    txtToplamOdeme.Clear();
                    txtAdi.Focus();
                    Listele();
                    Genel.PersonelID = 0;

                }
                else { MessageBox.Show("Kayit gerceklesmedi"); }

            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz!");
            }
        }
        private void Listele()
        {
            GelirGider g = (GelirGider)cbIslemTurleri.SelectedItem;
            if (g.Tür == "Gelir" && g.Aciklama.Contains("arac"))
            {
               dgvOdeme.DataSource = khr.KasaHareketListeleByArac();
            }
            else if (g.Tür == "Gider" && g.Aciklama == "Maaş Ödeme")
            {
                dgvOdeme.DataSource = khr.KasaHareketListeleByPersonel();
            }
            else if (g.Tür == "Gider" && g.Aciklama != "Maaş Ödeme")
            {
                dgvOdeme.DataSource = khr.KasaHareketListeleByArac();
            }
            else if (g.Tür == "Gelir" && !g.Aciklama.Contains("arac"))
            {
                dgvOdeme.DataSource = khr.KasaHareketListeleBySozlesme();
            }
        }
    }
}
