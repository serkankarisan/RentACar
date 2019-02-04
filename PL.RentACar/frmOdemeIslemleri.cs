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
        PersonelRepository pr = new PersonelRepository();
        KasaHareketRepository khr = new KasaHareketRepository();
        SozlesmeRepository sr = new SozlesmeRepository();
        MusteriRepository mr = new MusteriRepository();
        MusteriHareketRepository mhr = new MusteriHareketRepository();
        Personel p = new Personel();
        private void btnSec_Click(object sender, EventArgs e)
        {
            frmPersonelSorgulama frm = new frmPersonelSorgulama();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (Genel.PersonelID!=0)
            {
                p = pr.PersonelGetirById(Genel.PersonelID);
                txtAdi.Text = p.Adi;
                txtSoyadi.Text = p.Soyadi;
                txtMaas.Text = p.Maas.ToString();
            }
        }
        AracRepository arepo = new AracRepository();
        private void btnAracSec_Click(object sender, EventArgs e)
        {
            frmAracSorgulama frm = new frmAracSorgulama();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (Genel.AracID!=0)
            {
                Arac a = new Arac();
                a = arepo.AracGetirById(Genel.AracID);
                txtMarka.Text = a.Marka;
                txtModel.Text = a.Model;
                txtPlaka.Text = a.Plaka;
                txtAracDurumu.Text = a.AracDurumu;
            }
        }

        private void btnSozlesmeSec_Click(object sender, EventArgs e)
        {
            frmSozlesmeSorgulama frm = new frmSozlesmeSorgulama();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (Genel.soz != null)
            {
                Sozlesme s = new Sozlesme();
                s = Genel.soz;
                txtBorc.Text = s.Borc.ToString();
                txtSozlesmeTutar.Text = s.SozlesmeTutari.ToString();
                txtAlınan.Text = s.Alınan.ToString();
                txtSozlesmeTarihi.Text = s.SozlesmeTarihi.ToShortDateString();
                Musteri m = new Musteri();
                m = mr.MusteriGetirById(s.MusteriId);
                txtMusteriAdi.Text = m.Adi;
                txtMusteriSoyadi.Text = m.Soyadi;
            }
        }
        private void txtMaas_TextChanged(object sender, EventArgs e)
        {
            if (txtMaas.Text !="")
            {
                ToplamMaas = Convert.ToDecimal(txtMaas.Text);
                Total = ToplamMaas + ToplamPirim;
                txtToplamOdeme.Text = Total.ToString();
            }

        }

        private void txtPrim_TextChanged(object sender, EventArgs e)
        {
            if (txtPrim.Text!="")
            {
                ToplamPirim = Convert.ToDecimal(txtPrim.Text);
                Total = ToplamMaas + ToplamPirim;
                txtToplamOdeme.Text = Total.ToString();
            }
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
            GelirGider g = (GelirGider)cbIslemTurleri.SelectedItem;

            if (g.Tür == "Gelir")
            {
                if (g.Aciklama.Contains("Arac") || g.Aciklama.Contains("Araç"))
                {
                    AracGoster();
                    btnAracOdemeAl.Visible = true;
                    btnOdemeYap.Visible = false;
                    PersonelGizle();
                    SozlesmeGizle();
                }
                else
                {
                    SozlesmeGoster();
                    AracGizle();
                    PersonelGizle();
                }
            }
            else if (g.Tür == "Gider")
            {
                if (g.Aciklama.Contains("Arac") || g.Aciklama.Contains("Araç"))
                {
                    AracGoster();
                    PersonelGizle();
                    SozlesmeGizle();
                    btnOdemeYap.Visible = true;
                    btnAracOdemeAl.Visible = false;
                }
                else
                {
                    PersonelGoster();
                    AracGizle();
                    SozlesmeGizle();
                }
            }
            else
            {
                PersonelGizle();
                AracGizle();
                SozlesmeGizle();
            }
            Listele();
        }

        private void frmOdemeIslemleri_Load(object sender, EventArgs e)
        {
            
            GelirGider i = new GelirGider();
            i.Aciklama = "Tüm İşlemler";
            i.Id = 0;
            i.Tür = "Yok";
            i.Silindi = false;
            List<GelirGider> liste = ggrepo.GelirGiderLİstele();
            liste.Add(i);
            cbIslemTurleri.DataSource = liste;
            if (Genel.cbIslem== "SozlesmeOdeme")
            {
                Genel.cbIslem = "";
                cbIslemTurleri.SelectedIndex=1;
                if (Genel.soz != null)
                {
                    Sozlesme s = new Sozlesme();
                    s = sr.SozlesmeGetirById(Genel.soz.Id);
                    txtBorc.Text = s.Borc.ToString();
                    txtSozlesmeTutar.Text = s.SozlesmeTutari.ToString();
                    txtAlınan.Text = s.Alınan.ToString();
                    txtSozlesmeTarihi.Text = s.SozlesmeTarihi.ToShortDateString();
                    Musteri m = new Musteri();
                    m = mr.MusteriGetirById(s.MusteriId);
                    txtMusteriAdi.Text = m.Adi;
                    txtMusteriSoyadi.Text = m.Soyadi;
                }
            }
            else
            {
                cbIslemTurleri.SelectedItem = i;
                PersonelGizle();
                AracGizle();
                SozlesmeGizle();
                dgvOdeme.DataSource = khr.KasaHareketListele();
            }
            dgvOdeme.Columns[8].Visible = false;

        }

       
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (txtAracTutar.Text.Trim() != "")
            {
                KasaHareket kh = new KasaHareket();
                kh.AracId = Genel.AracID;
            if (kh.AracId!=0)
            {
                kh.SozlesmeId = 0;
                kh.PersonelId = 0;
                kh.Tarih = DateTime.Now;
                GelirGider g=(GelirGider)cbIslemTurleri.SelectedItem;
                kh.GelirGiderId = g.Id;
                kh.Tutar = Convert.ToDecimal(txtAracTutar.Text);
                kh.ParaBirimi = "TL";
                kh.Silindi = false;
                if (khr.KasaHareketEkle(kh))
                {
                    MessageBox.Show("Ödeme Yapıldı.", "Kayıt gerçekleşti.");
                    txtAdi.Focus();
                    Temizle();
                    Genel.PersonelID = 0;

                }
                else { MessageBox.Show("Kayit gerceklesmedi"); }
            }
            else
            {
                MessageBox.Show("Araç Seçin!");
            }
        }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz!");
            }
            Listele();
        }
        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            if (txtAlınan.Text.Trim() != "" && txtBorc.Text.Trim() != "" && txtSozlesmeTutar.Text.Trim() != "" && txtSozlesmeOdeme.Text.Trim()!="")
            {
                KasaHareket kh = new KasaHareket();
                kh.AracId = 0;
                kh.SozlesmeId = Genel.soz.Id;
                if (kh.SozlesmeId!=0)
                {
                kh.PersonelId = 0;
                kh.Tarih = DateTime.Now;
                kh.GelirGiderId = 2;
                kh.Tutar = Convert.ToDecimal(txtSozlesmeOdeme.Text);
                kh.ParaBirimi = "TL";
                kh.Silindi = false;
                    if (khr.KasaHareketEkle(kh))
                    {

                        int puan= mhr.MusteriHareketPuanGetir(Genel.gecicimusteriId);
                        MusteriHareket mh = new MusteriHareket();
                        mh.Tarih = DateTime.Now;
                        mh.MusteriId = Genel.gecicimusteriId;
                        mh.ParaBirimi = "TL";
                        mh.MusteriGetirisi = Convert.ToDecimal(txtSozlesmeOdeme.Text);
                        mh.MusteriGetiriTuru = "Kiralama Ödemesi";
                        mh.MusteriPuanı = puan;
                        mh.Silindi = false;

                        if (mhr.MusteriHareketEkle(mh))
                        {
                            Sozlesme s = new Sozlesme();
                            s = Genel.soz;
                            s.Alınan += Convert.ToDecimal(txtSozlesmeOdeme.Text);
                            s.Borc = s.SozlesmeTutari - Convert.ToDecimal(txtSozlesmeOdeme.Text);
                            sr.SozlesmeGuncelle(s);
                            MessageBox.Show("Hareket Eklendi.", "Kayıt gerçekleşti.");
                            txtBorc.Text = (Convert.ToDecimal(txtBorc.Text) - Convert.ToDecimal(txtSozlesmeOdeme.Text)).ToString();
                            txtSozlesmeOdeme.Focus();
                            Temizle();
                            Genel.soz = null;
                        }
                    }
                    else { MessageBox.Show("Kayit gerceklesmedi"); }
            }
            else
            {
                MessageBox.Show("Sözleşme Seçin!");
            }
        }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz!");
            }
            Listele();
        }


        private void btnAracOdemeAl_Click(object sender, EventArgs e)
        {
            if (txtAracTutar.Text.Trim() != "")
            {
                KasaHareket kh = new KasaHareket();
                kh.AracId = Genel.AracID;
                if (kh.AracId != 0)
                {
                    kh.SozlesmeId = 0;
                    kh.PersonelId = 0;
                    kh.Tarih = DateTime.Now;
                    kh.GelirGiderId = 3;
                    kh.Tutar = Convert.ToDecimal(txtAracTutar.Text);
                    kh.ParaBirimi = "TL";
                    kh.Silindi = false;
                    if (khr.KasaHareketEkle(kh))
                    {
                        if (arepo.AracSil(Genel.AracID))
                        {
                            MessageBox.Show("Hareket Eklendi.", "Kayıt gerçekleşti.");
                            Temizle();
                            txtAracTutar.Focus();
                            Genel.AracID = 0;
                        }

                    }
                    else { MessageBox.Show("Kayit gerceklesmedi"); }
                }
                else
                {
                    MessageBox.Show("Araç Seçin!");
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz!");
            }
            Listele();
        }
        private void btnMaasOdeme_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && (txtMaas.Text.Trim() != "" || txtPrim.Text.Trim() != ""))
            {
                KasaHareket kh = new KasaHareket();
                kh.AracId = 0;
                kh.SozlesmeId = 0;
                kh.PersonelId = Genel.PersonelID;
                if (kh.PersonelId!=0)
                {
                kh.Tarih = DateTime.Now;
                kh.GelirGiderId = 1;
                kh.Tutar = Convert.ToDecimal(txtToplamOdeme.Text);
                kh.ParaBirimi = "TL";
                kh.Silindi = false;
                if (khr.KasaHareketEkle(kh))
                {
                    MessageBox.Show("Maaş Ödendi.", "Kayıt gerçekleşti.");
                    txtAdi.Focus();
                    Temizle();
                    Genel.PersonelID = 0;
                }
                else { MessageBox.Show("Kayit gerceklesmedi"); }
                }
                else
                {
                    MessageBox.Show("Personel Seçin!");
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz!");
            }
            Listele();
        }
        private void Listele()
        {            
            GelirGider g = (GelirGider)cbIslemTurleri.SelectedItem;
            if (g.Id != 0)
            {
                dgvOdeme.DataSource = khr.KasaHareketListeleBygGelirGiderId(g.Id);
            }
            else
            {
                dgvOdeme.DataSource = khr.KasaHareketListele();
            }
            dgvOdeme.Columns[0].Visible = false;
            dgvOdeme.Columns[1].Visible = false;
            dgvOdeme.Columns[2].Visible = false;
            dgvOdeme.Columns[3].Visible = false;
            dgvOdeme.Columns[4].HeaderText = "İşlem Tarihi";
            dgvOdeme.Columns[4].Width = 125;
            dgvOdeme.Columns[5].Visible = false;
            dgvOdeme.Columns[6].Width = 125;
            dgvOdeme.Columns[6].HeaderText = "İşlem Tutarı";
            dgvOdeme.Columns[7].Width = 75;
            dgvOdeme.Columns[7].HeaderText = "Para Birimi";
            dgvOdeme.Columns[9].Width = 125;
            dgvOdeme.Columns[9].HeaderText = "İşlem Türü";
        }
        private void txtAlınan_TextChanged(object sender, EventArgs e)
        {
            if (txtAlınan.Text.Trim()!="" && txtSozlesmeTutar.Text.Trim()!="")
            {
                decimal stutar = Convert.ToDecimal(txtSozlesmeTutar.Text);
                decimal alinan = Convert.ToDecimal(txtAlınan.Text);
                txtBorc.Text = (stutar - alinan).ToString();
            }
        }
        private void Temizle()
        {
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Text = "";
                }
            }
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
            lblmarka.Visible = false;
            lblModel.Visible = false;
            lblPlaka.Visible = false;
            lblAracDurumu.Visible = false;
            txtMarka.Visible = false;
            txtModel.Visible = false;
            txtAracDurumu.Visible = false;
            txtPlaka.Visible = false;
            lblTutar.Visible = false;
            btnOdemeYap.Visible = false;
            txtAracTutar.Visible = false;
            btnAracSec.Visible = false;
            btnAracOdemeAl.Visible = false;
        }
        private void AracGoster()
        {
            lblmarka.Visible = true;
            lblModel.Visible = true;
            lblPlaka.Visible = true;
            lblAracDurumu.Visible = true;
            txtMarka.Visible = true;
            txtModel.Visible = true;
            txtAracDurumu.Visible = true;
            txtPlaka.Visible = true;
            lblTutar.Visible = true;
            txtAracTutar.Visible = true;
            btnAracSec.Visible = true;
        }
        private void SozlesmeGizle()
        {
            txtSozlesmeTarihi.Visible = false;
            lblSozlesmeTarihi.Visible = false;
            txtMusteriAdi.Visible = false;
            txtMusteriSoyadi.Visible = false;
            lblMusteriAdi.Visible = false;
            lblMusteriSoyadi.Visible = false;
            txtSozlesmeTutar.Visible = false;
            txtAlınan.Visible = false;
            txtBorc.Visible = false;
            txtSozlesmeOdeme.Visible = false;
            btnSozlesmeSec.Visible = false;
            btnOdemeAl.Visible = false;
            lblAlınan.Visible = false;
            lblborc.Visible = false;
            lblsozlesme.Visible = false;
            lblSozlesmeOdeme.Visible = false;
        }
        private void SozlesmeGoster()
        {
            txtSozlesmeTarihi.Visible = true;
            lblSozlesmeTarihi.Visible = true;
            txtMusteriAdi.Visible = true;
            txtMusteriSoyadi.Visible = true;
            lblMusteriAdi.Visible = true;
            lblMusteriSoyadi.Visible = true;
            txtSozlesmeTutar.Visible = true;
            txtAlınan.Visible = true;
            txtSozlesmeOdeme.Visible = true;
            txtBorc.Visible = true;
            btnSozlesmeSec.Visible = true;
            btnOdemeAl.Visible = true;
            lblAlınan.Visible = true;
            lblborc.Visible = true;
            lblsozlesme.Visible = true;
            lblSozlesmeOdeme.Visible = true;
        }
    }
}
