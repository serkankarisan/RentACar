using BLL.RentACar.Repositories;
using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.RentACar
{
    
    public partial class frmAracIslemleri : Form
    {
        public frmAracIslemleri()
        {
            InitializeComponent();
        }

        AracRepository ar = new AracRepository();
        int ID;
        ImageList ListeResim = new ImageList();

        private void tsYeni_Click(object sender, EventArgs e)
        {
            Enable();
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            txtMarka.Focus();
            Temizle();
        }
        decimal gunlukfiyat,dg;
        private void tsKaydet_Click(object sender, EventArgs e)
        {
            //if sıralaması ayarlanacak.
            if (txtAracDurumu.Text.Trim() != "")
            {
                if (txtGunlukFiyat.Text.Trim() != "")
                {
                    if (txtMarka.Text.Trim() != "")
                    {
                        if (txtModel.Text.Trim() != "")
                        {
                            if (txtPlaka.Text.Trim() != "")
                            {
                                if (txtRenk.Text.Trim() != "")
                                {
                                    if (txtTip.Text.Trim() != "")
                                    {
                                        if (txtYakitDurumu.Text.Trim() != "")
                                        {
                                            if (txtResimYolu.Text.Trim() != "")
                                            {
                                                Arac a = new Arac();
                                                a.Plaka = txtPlaka.Text.ToUpper();
                                                if (ar.AracKontrol(a))
                                                {
                                                    MessageBox.Show("Girdiginiz Plaka Kayıtlı!", "Aynı Arac Zaten Var!");
                                                }
                                                else
                                                {
                                                    a.AracDurumu = txtAracDurumu.Text.Substring(0, 1).ToUpper() + txtAracDurumu.Text.Substring(1).ToLower();
                                                    if (decimal.TryParse(txtGunlukFiyat.Text, out dg))
                                                    {
                                                        a.GünlükFiyat = Convert.ToDecimal(txtGunlukFiyat.Text);
                                                    }
                                                    a.Marka = txtMarka.Text.Substring(0, 1).ToUpper() + txtMarka.Text.Substring(1).ToLower();
                                                    a.Model = txtModel.Text.Substring(0, 1).ToUpper() + txtModel.Text.Substring(1).ToLower();
                                                    a.Renk = txtRenk.Text.Substring(0, 1).ToUpper() + txtRenk.Text.Substring(1).ToLower();
                                                    a.Silindi = false;
                                                    a.Tip = txtTip.Text.Substring(0, 1).ToUpper() + txtTip.Text.Substring(1).ToLower();
                                                    if (txtYakitDurumu.Text.Substring(0,1)!="%")
                                                    {
                                                        a.YakitDurumu = "%" + txtYakitDurumu.Text.Substring(0, 1).ToUpper() + txtYakitDurumu.Text.Substring(1).ToLower();
                                                    }
                                                    else
                                                    {
                                                        a.YakitDurumu = txtYakitDurumu.Text.Substring(0, 1).ToUpper() + txtYakitDurumu.Text.Substring(1).ToLower();
                                                    }
                                                    a.Varmi = true;
                                                    a.ResimYolu = txtResimYolu.Text.Substring(0, 1).ToUpper() + txtResimYolu.Text.Substring(1).ToLower();
                                                    if (ar.AracEkle(a))
                                                    {
                                                        MessageBox.Show("Yeni arac eklendi.", "Kayıt gerçekleşti.");
                                                        Listele();
                                                        tsKaydet.Enabled = false;
                                                        Temizle();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Resim Seçiniz.", "Eksik Bilgi!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Yakıt Bilgisi Giriniz!", "Eksik Bilgi!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Tip Giriniz!", "Eksik Bilgi!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Renk Giriniz!", "Eksik Bilgi!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Plaka Giriniz!", "Eksik Bilgi!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Model Giriniz!", "Eksik Bilgi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marka Giriniz!", "Eksik Bilgi!");
                    }
                }
                else
                {
                    MessageBox.Show("Günlük Fiyat Giriniz!", "Eksik Bilgi!");
                }
            }
            else
            {
                MessageBox.Show("Araç Durumu Giriniz!", "Eksik Bilgi!");
            }
        }
        private void Listele()
        {
            dgvAraclar.DataSource = ar.AracListele();
            dgvAraclar.Columns[0].Visible = false;
            dgvAraclar.Columns[1].Width = 100;
            dgvAraclar.Columns[2].Width = 100;
            dgvAraclar.Columns[3].Width = 110;
            dgvAraclar.Columns[3].HeaderText = "Günlük Fiyat";
            dgvAraclar.Columns[4].Width = 100;
            dgvAraclar.Columns[5].Width = 100;
            dgvAraclar.Columns[6].Width = 110;
            dgvAraclar.Columns[7].Width = 100;
            dgvAraclar.Columns[7].HeaderText = "Durum";
            dgvAraclar.Columns[8].Width = 75;
            dgvAraclar.Columns[8].HeaderText = "Depo";
            dgvAraclar.Columns[9].Visible = false;
            dgvAraclar.Columns[10].Visible = false;
            dgvAraclar.Columns[11].Visible = false;
        }

        private void Temizle()
        {
            pbFoto.Image = null;
            txtResimYolu.Clear();
            txtAracDurumu.Clear();
            txtGunlukFiyat.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            txtRenk.Clear();
            txtTip.Clear();
            txtYakitDurumu.Clear();
            txtMarka.Focus();
               
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAracIslemleri_Load(object sender, EventArgs e)
        {
            Disable();
            Listele();
        }

        private void dgvAraclar_DoubleClick(object sender, EventArgs e)
        {
            Enable();
            ID = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells[0].Value);
            txtMarka.Text = dgvAraclar.SelectedRows[0].Cells[1].Value.ToString();
            txtModel.Text= dgvAraclar.SelectedRows[0].Cells[2].Value.ToString();
            txtGunlukFiyat.Text= dgvAraclar.SelectedRows[0].Cells[3].Value.ToString();
            txtTip.Text= dgvAraclar.SelectedRows[0].Cells[4].Value.ToString();
            txtRenk.Text= dgvAraclar.SelectedRows[0].Cells[5].Value.ToString();
            txtPlaka.Text= dgvAraclar.SelectedRows[0].Cells[6].Value.ToString();
            txtAracDurumu.Text= dgvAraclar.SelectedRows[0].Cells[7].Value.ToString();
            txtYakitDurumu.Text= dgvAraclar.SelectedRows[0].Cells[8].Value.ToString();
            txtResimYolu.Text = dgvAraclar.SelectedRows[0].Cells[10].Value.ToString();
            pbFoto.Image = Image.FromFile(Application.StartupPath + "" + txtResimYolu.Text);
            tsSil.Enabled = true;
            tsDegistir.Enabled = true;
        }


        private void tsDegistir_Click(object sender, EventArgs e)
        {
            if (txtAracDurumu.Text.Trim() != "")
            {
                if (txtGunlukFiyat.Text.Trim() != "")
                {
                    if (txtMarka.Text.Trim() != "")
                    {
                        if (txtModel.Text.Trim() != "")
                        {
                            if (txtPlaka.Text.Trim() != "")
                            {
                                if (txtRenk.Text.Trim() != "")
                                {
                                    if (txtTip.Text.Trim() != "")
                                    {
                                        if (txtYakitDurumu.Text.Trim() != "")
                                        {
                                            if (txtResimYolu.Text.Trim() != "")
                                            {
                                                Arac a = new Arac();
                                                a.Id = ID;
                                                a.Plaka = txtPlaka.Text.ToUpper();
                                                if (ar.AracKontrolbyGuncelleme(a))
                                                {
                                                    MessageBox.Show("Girdiginiz Plaka Kayıtlı!", "Aynı Arac Zaten Var!");
                                                }
                                                else
                                                {
                                                    a.AracDurumu = txtAracDurumu.Text.Substring(0, 1).ToUpper() + txtAracDurumu.Text.Substring(1).ToLower();
                                                    if (decimal.TryParse(txtGunlukFiyat.Text, out gunlukfiyat))
                                                    {
                                                        a.GünlükFiyat = Convert.ToDecimal(txtGunlukFiyat.Text);
                                                    }
                                                    a.Marka = txtMarka.Text.Substring(0, 1).ToUpper() + txtMarka.Text.Substring(1).ToLower();
                                                    a.Model = txtModel.Text.Substring(0, 1).ToUpper() + txtModel.Text.Substring(1).ToLower(); 
                                                    a.Renk = txtRenk.Text.Substring(0, 1).ToUpper() + txtRenk.Text.Substring(1).ToLower(); 
                                                    a.Silindi = false;
                                                    a.Tip = txtTip.Text.Substring(0, 1).ToUpper() + txtTip.Text.Substring(1).ToLower();
                                                    if (txtYakitDurumu.Text.Substring(0, 1) != "%")
                                                    {
                                                        a.YakitDurumu = "%" + txtYakitDurumu.Text.Substring(0, 1).ToUpper() + txtYakitDurumu.Text.Substring(1).ToLower();
                                                    }
                                                    else
                                                    {
                                                        a.YakitDurumu = txtYakitDurumu.Text.Substring(0, 1).ToUpper() + txtYakitDurumu.Text.Substring(1).ToLower();
                                                    }
                                                    a.Varmi = true;
                                                    a.ResimYolu = txtResimYolu.Text.Substring(0, 1).ToUpper() + txtResimYolu.Text.Substring(1).ToLower(); 
                                                    if (ar.AracGuncelle(a))
                                                    {
                                                        MessageBox.Show("Arac Bilgileri Değiştirildi.", "Guncelleme Gerçekleşti.");
                                                        Listele();
                                                        tsDegistir.Enabled = false;
                                                        tsSil.Enabled = false;
                                                        Temizle();
                                                        Disable();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Arac Bilgileri Değiştirilemedi.", "Hata!");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Resim Seçiniz.", "Eksik Bilgi!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Yakıt Bilgisi Giriniz!", "Eksik Bilgi!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Tip Giriniz!", "Eksik Bilgi!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Renk Giriniz!", "Eksik Bilgi!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Plaka Giriniz!", "Eksik Bilgi!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Model Giriniz!", "Eksik Bilgi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marka Giriniz!", "Eksik Bilgi!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Araç Durumu Giriniz!", "Eksik Bilgi!");
            }
            txtMarka.Focus();
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             
                
                if (ar.AracSil(ID))
                {
                    MessageBox.Show("Arac bilgileri silindi.", "Silme gerçekleşti.");
                    Listele();
                    tsDegistir.Enabled = false;
                    tsSil.Enabled = false;
                    Temizle();
                    Disable();
                }
            }
        }
        private void Enable()
        {
            cbAracdurumu.Enabled = true;
            btnResimEkle.Enabled = true;
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = true;
                }
            }
        }
        private void Disable()
        {
            cbAracdurumu.Enabled = false;
            btnResimEkle.Enabled = false;
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = false;
                }
            }
        }
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string kopyalanacakDosyaIsmi = open.SafeFileName.ToString();
                string kopyalanacakDosya = open.FileName.ToString();
                string projeadres = Application.StartupPath;
                string adres = projeadres + @"\\Araclar";
                Kopyala(kopyalanacakDosya, adres, kopyalanacakDosyaIsmi);
                if (kopyalanacakDosyaIsmi.Trim()!="")
                {
                    txtResimYolu.Text = @"\\Araclar" + "\\" + kopyalanacakDosyaIsmi;
                }
                // image file path  
            }
            else
            {
                MessageBox.Show("Dosya Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtResimYolu.Text.Trim()!="")
            {
                pbFoto.Image = Image.FromFile(Application.StartupPath + "" + txtResimYolu.Text);
            }
        }

        private void cbAracdurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAracDurumu.Text = cbAracdurumu.Text;
        }

        private void Kopyala(string kopyalanacakDosya,string dosyanınKopyanacagiKlasor,string kopyalanacakDosyaIsmi)
        {
            if (dosyanınKopyanacagiKlasor != "" && kopyalanacakDosya != "")
            {
                if (File.Exists(dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi))
                {
                    MessageBox.Show("Belirtilen klasörde " + kopyalanacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi);
                    MessageBox.Show("Dosya Kopyalama İşlemi Başarılı", "Dosya Kopyalandı...");
                }
            }
            else if (kopyalanacakDosya == "")
            {
                MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
