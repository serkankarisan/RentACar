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
        SozlesmeRepository srepo = new SozlesmeRepository();
        int AracID;
        int MusteriID;
        AracRepository ar = new AracRepository();
        Arac a = new Arac();
        decimal EkstraTutar = 0;
        int GunSayisi = 0;
        decimal GunlukFiyat = 0;
        MusteriHareket mh = new MusteriHareket();
        MusteriHareketRepository mhr = new MusteriHareketRepository();
        int SozlesmeDetayId;
        KasaHareket kh = new KasaHareket();
        KasaHareketRepository khr = new KasaHareketRepository();
        int YakitFarki=0;
        private void btnSec_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            dgvSozlesmeDetay.DataSource = sdr.SozlesmeDetayListeleBySozlesmeId(Genel.SozID);
            sdgridDuzenle();
            txtAracSayisi.Text = dgvSozlesmeDetay.RowCount.ToString();
            txtSozlesmeTutari.Text = sdr.SozlesmeTutarGetirBySozlesmeId(Genel.SozID).ToString();
        }
        private void sdgridDuzenle()
        {
            dgvSozlesmeDetay.Columns[0].Visible = false;
            dgvSozlesmeDetay.Columns[1].Visible = false;
            dgvSozlesmeDetay.Columns[2].Visible = false;
            dgvSozlesmeDetay.Columns[3].Width = 80;
            dgvSozlesmeDetay.Columns[3].HeaderText = "Araç Tutarı";
            dgvSozlesmeDetay.Columns[4].Width = 125;
            dgvSozlesmeDetay.Columns[4].HeaderText = "Başlangıç Tarihi";
            dgvSozlesmeDetay.Columns[5].Width = 125;
            dgvSozlesmeDetay.Columns[5].HeaderText = "Bitiş Tarihi";
            dgvSozlesmeDetay.Columns[6].Visible = false;
            dgvSozlesmeDetay.Columns[7].Visible = false;
            dgvSozlesmeDetay.Columns[8].Width = 175;
            dgvSozlesmeDetay.Columns[8].HeaderText = "Marka - Model";
        }
        private void frmTeslimAl_Load(object sender, EventArgs e)
        {
            cbAracDurumu.Enabled = false;
            cbYakitDurumu.Enabled = false;
        }

        private void dgvSozlesmeDetay_DoubleClick(object sender, EventArgs e)
        {
            Sozlesme s = srepo.SozlesmeGetirById(Genel.SozID);
            MusteriID = s.MusteriId;
            cbAracDurumu.Enabled = true;
            cbYakitDurumu.Enabled = true;
            AracID = Convert.ToInt32(dgvSozlesmeDetay.SelectedRows[0].Cells[2].Value);
            a = ar.AracGetirById(AracID);
            pbFoto.Image = Image.FromFile(Application.StartupPath + "" + a.ResimYolu);
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
            rdnYes.Checked = true;
        }

        private void txtGunSayisi_TextChanged(object sender, EventArgs e)
        {
            if (txtGunSayisi.Text != "")
            {
                if (txtGunlukFiyat.Text != "")
                {
                    GunSayisi = Convert.ToInt32(txtGunSayisi.Text);
                    EkstraTutar = (GunSayisi * GunlukFiyat);
                    txtEkstraTutar.Text = EkstraTutar.ToString();
                }
                else
                    MessageBox.Show("Sozlesme Detay Seciniz!");
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
                mh.MusteriId = MusteriID;
                mh.ParaBirimi = "TL";
                if (!txtEkstraTutar.ReadOnly)
                {
                    if (Convert.ToDecimal(txtEkstraTutar.Text.Trim()) != Convert.ToDecimal(0))
                    {
                        mh.MusteriGetirisi = Convert.ToDecimal(txtEkstraTutar.Text);
                    }
                    else
                    {
                        MessageBox.Show("Ekstra Tutar Almalısınız!"); return;
                    }
                }
                else
                {
                    mh.MusteriGetirisi = Convert.ToDecimal(txtEkstraTutar.Text);
                }

                mh.MusteriGetiriTuru = "Ekstra Kiralama";
                mh.Silindi = false;
                    if (txtAracDurumu.Text.Trim()=="Hasar yok")
                    {
                        if (mh.MusteriPuanı!=100)
                        {
                            mh.MusteriPuanı += 3;
                        }
                    }
                    else if (txtAracDurumu.Text.Trim() == "Az hasarlı")
                    {
                        mh.MusteriPuanı -= 5;
                    }
                    else if (txtAracDurumu.Text.Trim() == "Ağır hasarlı")
                    {
                        mh.MusteriPuanı -= 10;

                    }
                    else
                    {
                        MessageBox.Show("Araç Durumu Seçin!","Boş Geçilemez!");
                    }
                    if (YakitFarki>0)
                    {
                        mh.MusteriPuanı -= (YakitFarki/10);
                    }
                    else if(YakitFarki < 0)
                    {
                        if (mh.MusteriPuanı < 100)
                        {
                            mh.MusteriPuanı += (YakitFarki / 20);
                        }
                    }
                if (mhr.MusteriHareketEkle(mh))
                {
                    sdr.SozlesmeDetaySil(SozlesmeDetayId);
                    dgvSozlesmeDetay.DataSource = sdr.SozlesmeDetayListeleBySozlesmeId(Genel.SozID);
                    sdgridDuzenle();
                    Arac eski = ar.AracGetirById(AracID);
                    Arac a = new Arac();
                    a.Id = AracID;
                    a.Marka = eski.Marka;
                    a.Model = eski.Model;
                    a.Tip = eski.Tip;
                    a.AracDurumu = cbAracDurumu.Text;
                    a.YakitDurumu = cbYakitDurumu.Text;
                    a.GünlükFiyat = eski.GünlükFiyat;
                    a.Plaka = eski.Plaka;
                    a.Renk = eski.Renk;
                    a.ResimYolu = eski.ResimYolu;
                    a.Varmi = true;
                    a.Silindi = eski.Silindi;
                    if (ar.AracGuncelle(a))
                    {
                        if (txtGunSayisi.ReadOnly)
                        {
                                kh.AracId = 0;
                                kh.PersonelId = 0;
                                kh.SozlesmeId = Genel.SozID;
                                kh.GelirGiderId = 2;
                                kh.Tarih = DateTime.Now;
                                if (!txtEkstraTutar.ReadOnly)
                                {
                                    if (Convert.ToDecimal(txtEkstraTutar.Text.Trim()) != Convert.ToDecimal(0))
                                    {
                                        kh.Tutar = Convert.ToDecimal(txtEkstraTutar.Text);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ekstra Tutar Almalısınız!"); return;
                                    }
                                }
                                else
                                {
                                    kh.Tutar = Convert.ToDecimal(txtEkstraTutar.Text);
                                }
                                kh.ParaBirimi = "TL";
                                kh.Silindi = false;
                                if (khr.KasaHareketEkle(kh))
                                {
                                    txtEkstraTutar.Enabled = false;
                                    txtEkstraTutar.ReadOnly = true;
                                    cbAracDurumu.Enabled = false;
                                    cbYakitDurumu.Enabled = false;
                                    MessageBox.Show("Arac Teslim Alındı.", "İşlem Başarılı.");
                                Temizle();
                            }
                            
                        }
                        else
                        {
                            kh.AracId = 0;
                            kh.PersonelId = 0;
                            kh.SozlesmeId = Genel.SozID;
                            kh.GelirGiderId = 2;
                            kh.Tarih = DateTime.Now;
                            if (!txtEkstraTutar.ReadOnly)
                            {
                                if (Convert.ToDecimal(txtEkstraTutar.Text.Trim()) != Convert.ToDecimal(0))
                                {
                                    kh.Tutar = Convert.ToDecimal(txtEkstraTutar.Text);
                                }
                                else
                                {
                                    MessageBox.Show("Ekstra Tutar Almalısınız!"); return;
                                }
                            }
                            else
                            {
                                kh.Tutar = Convert.ToDecimal(txtEkstraTutar.Text);
                            }
                            kh.ParaBirimi = "TL";
                            kh.Silindi = false;
                            if (khr.KasaHareketEkle(kh))
                            {
                                txtEkstraTutar.Enabled = false;
                                txtEkstraTutar.ReadOnly = true;
                                cbAracDurumu.Enabled = false;
                                cbYakitDurumu.Enabled = false;
                                MessageBox.Show("Arac Teslim Alındı.", "İşlem Başarılı.");
                                Temizle();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bos alanlari doldurunuz!!!");
            }

        }

        private void rdnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYes.Checked == true)
            {
                txtGunSayisi.Text = Convert.ToInt32(0).ToString();
                txtGunSayisi.ReadOnly = true;
            }
            else if (rdnNo.Checked==true)
            {
                txtGunSayisi.ReadOnly = false;
            }
        }

        private void rdnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYes.Checked == true)
            {
                txtGunSayisi.Text = Convert.ToInt32(0).ToString();
                txtGunSayisi.ReadOnly = true;
            }
            else if (rdnNo.Checked == true)
            {
                txtGunSayisi.ReadOnly = false;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAracDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAracDurumu.Text.Trim().ToLower() != cbAracDurumu.Text.Trim().ToLower() && cbAracDurumu.Text.Trim().ToLower()!="hasar yok")
            {
                txtEkstraTutar.Enabled = true;
                txtEkstraTutar.ReadOnly = false;
            }
            else if (txtAracDurumu.Text.Trim().ToLower() == cbAracDurumu.Text.Trim().ToLower() && !txtEkstraTutar.Enabled)
            {
                txtEkstraTutar.Enabled = false;
                txtEkstraTutar.ReadOnly = true;
            }
            else if (txtYakitDurumu.Text.Trim().ToLower() == cbYakitDurumu.Text.Trim().ToLower() && txtAracDurumu.Text.Trim().ToLower() == cbAracDurumu.Text.Trim().ToLower())
            {
                txtEkstraTutar.Enabled = false;
                txtEkstraTutar.ReadOnly = true;
            }
                    }

        private void cbYakitDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(txtYakitDurumu.Text.Substring(1)) > Convert.ToInt32(cbYakitDurumu.Text.Substring(1)))
            {
                txtEkstraTutar.Enabled = true;
                txtEkstraTutar.ReadOnly = false;
                int VerildigiYakit = Convert.ToInt32(txtYakitDurumu.Text.Substring(1));
                int AlindigiYakit = Convert.ToInt32(cbYakitDurumu.Text.Substring(1));
                int YakitFarki = VerildigiYakit - AlindigiYakit;
            }
            else if ( Convert.ToInt32(txtYakitDurumu.Text.Substring(1)) < Convert.ToInt32(cbYakitDurumu.Text.Substring(1)) && txtAracDurumu.Text.Trim().ToLower() == cbAracDurumu.Text.Trim().ToLower())
            {
                txtEkstraTutar.Enabled = false;
                txtEkstraTutar.ReadOnly = true;
            }
            else if (Convert.ToInt32(txtYakitDurumu.Text.Substring(1)) > Convert.ToInt32(cbYakitDurumu.Text.Substring(1)) && !txtEkstraTutar.Enabled)
            {
                txtEkstraTutar.Enabled = false;
                txtEkstraTutar.ReadOnly = true;
            }
            else if (txtAracDurumu.Text.Trim().ToLower() == cbAracDurumu.Text.Trim().ToLower() && !txtEkstraTutar.Enabled)
            {
                txtEkstraTutar.Enabled = false;
                txtEkstraTutar.ReadOnly = true;
            }

        }
        private void Temizle()
        {
            pbFoto.Image = null;
            cbAracDurumu.SelectedIndex = 0;
            cbYakitDurumu.SelectedIndex = 3;
            rdnYes.Enabled = true;
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Text = "";
                }
            }
        }
    }
}
