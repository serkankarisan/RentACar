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
    public partial class frmKirala : Form
    {
        public frmKirala()
        {
            InitializeComponent();
        }
        SozlesmeDetayRepository sdrepo = new SozlesmeDetayRepository();
        SozlesmeRepository sozrepo = new SozlesmeRepository();
        AracRepository arepo = new AracRepository();
        private void btnAracSec_Click(object sender, EventArgs e)
        {
            frmAracSorgulama frm = new frmAracSorgulama();
            frm.ShowDialog();
            if (Genel.AracID!=0)
            {
                Arac a = arepo.AracGetirById(Genel.AracID);
                txtMarka.Text = a.Marka;
                txtModel.Text = a.Model;
                txtTip.Text = a.Tip;
                txtRenk.Text = a.Renk;
                txtPlaka.Text = a.Plaka;
                txtYakıtDurumu.Text = a.YakitDurumu;
                txtAracDurumu.Text = a.AracDurumu;
                txtGunlukFiyat.Text = a.GünlükFiyat.ToString();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKirala_Load(object sender, EventArgs e)
        {
            dgvSozlesmeDetaylar.DataSource = sdrepo.SozlesmeDetayListeleBySozlesmeId(Genel.soz.Id);
            t = (dtpBitis.Value - dtpBaslangic.Value).TotalDays;
            txtGunSayisi.Text = Convert.ToInt32(t).ToString();
            txtTutar.Text = Convert.ToDecimal(0).ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTutar.Text.Trim()) != Convert.ToDecimal(0))
            {
                btnTamamla.Enabled = true;
                SozlesmeDetay sd = new SozlesmeDetay();
                if (Genel.AracID != 0)
                {
                    sd.AracId = Genel.AracID;
                    sd.Silindi = false;
                    sd.BaslangicTarihi = dtpBaslangic.Value;
                    sd.BitisTarihi = dtpBitis.Value;
                    sd.SozlesmeId = Genel.soz.Id;
                    sd.Tutar = Convert.ToDecimal(txtTutar.Text);

                    Arac eski=arepo.AracGetirById(Genel.AracID);
                    Arac a = new Arac();
                    a.Id = Genel.AracID;
                    a.Plaka = eski.Plaka;
                    a.AracDurumu = eski.AracDurumu;
                    a.Marka = eski.Marka;
                    a.Model = eski.Model;
                    a.Renk = eski.Renk;
                    a.Silindi = eski.Silindi;
                    a.Tip = eski.Tip;
                    a.YakitDurumu = eski.YakitDurumu;
                    a.Varmi = false;
                    a.ResimYolu = eski.ResimYolu;
                    a.GünlükFiyat = eski.GünlükFiyat;
                    arepo.AracGuncelle(a);
                    if (!sdrepo.SozlesmeDetayEkle(sd))
                    {
                        MessageBox.Show("Bu Detay Eklenemedi!", "Hatalı Bilgi Girişi!");
                    }
                    else
                    {
                        MessageBox.Show("Araç Listeye Eklendi.", "Kayıt Gerçekleşti.");
                        Temizle();
                        Genel.AracID = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Bir Araç Seçmelisiniz!", "Eksik Bilgi Girişi!");
                }
            }
            else
            {
                MessageBox.Show("Başlangıç ve Bitiş Tarihlerini Kontroledin!", "Tarih Hatalı!");
            }
            ListeGoster();
        }
        decimal tutar;
        double t;
        DateTime baslangic = new DateTime();
        DateTime bugun = new DateTime();

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            baslangic= Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            if (baslangic>=bugun)
            {
                dtpBitis.Enabled = true;
                t = Convert.ToInt32((dtpBitis.Value - dtpBaslangic.Value).TotalDays);
                if (t>=0)
                {
                    txtGunSayisi.Text = t.ToString();
                    tutar = Convert.ToDecimal(txtGunSayisi.Text) * Convert.ToDecimal(txtGunlukFiyat.Text);
                    txtTutar.Text = tutar.ToString();
                }
                else
                {
                    MessageBox.Show("Bitiş Tarihi Seçin!", "Tarih Hatalı!");
                    dtpBitis.Focus();
                }
            }
            else
            {
                MessageBox.Show("İleri Bir Tarih Seçin!", "Tarih Hatalı!");
                dtpBitis.Enabled = false;
                dtpBaslangic.Value = DateTime.Now;
                return;
            }
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            t = Convert.ToInt32((dtpBitis.Value - dtpBaslangic.Value).TotalDays);
            if (Genel.AracID!=0)
            {
                if (t >= 0)
                {
                    txtGunSayisi.Text = t.ToString();
                    tutar = Convert.ToDecimal(txtGunSayisi.Text) * Convert.ToDecimal(txtGunlukFiyat.Text);
                    txtTutar.Text = tutar.ToString();
                }
                else
                {
                    MessageBox.Show("İleri Bir Tarih Seçin!", "Tarih Hatalı!");
                    dtpBitis.Value = dtpBaslangic.Value;
                    return;
                }
            }
            else
            {
                if (dtpBitis.Value != dtpBaslangic.Value)
                {
                    MessageBox.Show("Araç Seçin!", "Eksik Bilgi!");
                    dtpBitis.Value = dtpBaslangic.Value;
                    return;
                }
            }
        }
        private void Temizle()
        {
            Genel.MusteriID = 0;
            txtMarka.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            txtRenk.Clear();
            txtTip.Clear();
            txtTutar.Clear();
            txtYakıtDurumu.Clear();
            txtGunSayisi.Clear();
            txtGunlukFiyat.Text = Convert.ToDecimal(0).ToString();
            txtAracDurumu.Clear();
            txtYakıtDurumu.Clear();
            txtGunSayisi.Text = Convert.ToDecimal(0).ToString();
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;

        }
        private void ListeGoster()
        {
            dgvSozlesmeDetaylar.DataSource = sdrepo.SozlesmeDetayListeleBySozlesmeId(Genel.soz.Id);
            dgvSozlesmeDetaylar.Columns[0].Visible = false;
            dgvSozlesmeDetaylar.Columns[1].Visible = false;
            dgvSozlesmeDetaylar.Columns[2].Visible = false;
            dgvSozlesmeDetaylar.Columns[3].Width = 80;
            dgvSozlesmeDetaylar.Columns[4].Width = 125;
            dgvSozlesmeDetaylar.Columns[5].Width = 125;
            dgvSozlesmeDetaylar.Columns[6].Width = 125;
            dgvSozlesmeDetaylar.Columns[7].Width = 125;
            dgvSozlesmeDetaylar.Columns[8].Visible = false;
            dgvSozlesmeDetaylar.Columns[9].Visible = false;
            dgvSozlesmeDetaylar.Columns[10].Visible = false;
            txtAracSayisi.Text = dgvSozlesmeDetaylar.RowCount.ToString();
            txtSozlesmeTutari.Text = sdrepo.SozlesmeTutarGetirBySozlesmeId(Genel.soz.Id).ToString();

        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            Sozlesme s = new Sozlesme();
            s = sozrepo.SozlesmeGetirById(Genel.soz.Id);
            s.AracSayisi = Convert.ToInt32(txtAracSayisi.Text);
            s.SozlesmeTutari = Convert.ToDecimal(txtSozlesmeTutari.Text);
            s.Borc = Convert.ToDecimal(txtSozlesmeTutari.Text);
            sozrepo.SozlesmeGuncelle(s);
            btnTamamla.Enabled = false;
            Genel.cbIslem = "SozlesmeOdeme";
            frmOdemeIslemleri frm = new frmOdemeIslemleri();
            this.Hide();
            FormAc(frm);
            Genel.cbIslem = "";
        }
        private void FormAc(Form AF)
        {
            AF.TopLevel = false;
            this.Parent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

       
    }
}
