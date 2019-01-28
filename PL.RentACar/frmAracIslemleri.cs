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
    
    public partial class frmAracIslemleri : Form
    {
        public frmAracIslemleri()
        {
            InitializeComponent();
        }

        AracRepository ar = new AracRepository();
        int ID;

        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            txtMarka.Focus();
            Temizle();
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (txtAracDurumu.Text.Trim()!="" && txtGunlukFiyat.Text.Trim()!="" && txtMarka.Text.Trim()!="" && txtModel.Text.Trim()!="" && txtPlaka.Text.Trim()!="" &&txtRenk.Text.Trim()!="" && txtTip.Text.Trim()!="" && txtYakitDurumu.Text.Trim()!="")
            {
                
                Arac a = new Arac();

                a.Plaka = txtPlaka.Text;
                if (ar.AracKontrol(a))
                {
                    MessageBox.Show("Girdiginiz plaka no'lu arac sistemde kayitli!", "Aynı arac zaten var!");
                }
                else
                {
                    a.AracDurumu = txtAracDurumu.Text;
                    a.GünlükFiyat = Convert.ToInt32(txtGunlukFiyat.Text);
                    a.Marka = txtMarka.Text;
                    a.Model = txtModel.Text;
                    a.Renk = txtRenk.Text;
                    a.Silindi = false;
                    a.Tip = txtTip.Text;
                    a.YakitDurumu = txtYakitDurumu.Text;
                    a.Varmi = true;
                   

                    if (ar.AracEkle(a))
                    {
                        MessageBox.Show("Yeni arac eklendi.", "Kayıt gerçekleşti.");
                        dgvAraclar.DataSource = ar.AracListele();
                        tsKaydet.Enabled = false;
                        Temizle();
                    }
                }
            }
            else { MessageBox.Show("Gerekli alanlari doldurunuz!"); }
        }

        private void Temizle()
        {
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
            dgvAraclar.DataSource = ar.AracListele();
        }

        private void dgvAraclar_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells[0].Value);
            txtMarka.Text = dgvAraclar.SelectedRows[0].Cells[1].Value.ToString();
            txtModel.Text= dgvAraclar.SelectedRows[0].Cells[2].Value.ToString();
           txtGunlukFiyat.Text= dgvAraclar.SelectedRows[0].Cells[3].Value.ToString();
            txtTip.Text= dgvAraclar.SelectedRows[0].Cells[4].Value.ToString();
            txtRenk.Text= dgvAraclar.SelectedRows[0].Cells[5].Value.ToString();
            txtPlaka.Text= dgvAraclar.SelectedRows[0].Cells[6].Value.ToString();
            txtAracDurumu.Text= dgvAraclar.SelectedRows[0].Cells[7].Value.ToString();
            txtYakitDurumu.Text= dgvAraclar.SelectedRows[0].Cells[8].Value.ToString();
            tsSil.Enabled = true;
            tsDegistir.Enabled = true;
        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            if (txtAracDurumu.Text.Trim() != "" && txtGunlukFiyat.Text.Trim() != "" && txtMarka.Text.Trim() != "" && txtModel.Text.Trim() != "" && txtPlaka.Text.Trim() != "" && txtRenk.Text.Trim() != "" && txtTip.Text.Trim() != "" && txtYakitDurumu.Text.Trim() != "")
            {
                
                Arac a = new Arac();
                a = ar.AracGetirById(ID);
                a.Plaka = txtPlaka.Text;
                a.AracDurumu = txtAracDurumu.Text;
                a.GünlükFiyat = Convert.ToInt32(txtGunlukFiyat.Text);
                a.Marka = txtMarka.Text;
                a.Model = txtModel.Text;
                a.Renk = txtRenk.Text;
                a.Silindi = false;
                a.Tip = txtTip.Text;
                a.YakitDurumu = txtYakitDurumu.Text;
                a.Varmi = true;
                if (ar.AracKontrolbyGuncelleme(a))
                {
                    MessageBox.Show("Bu arac plakasi sistemde kayıtlı!", "Aynı arac zaten var!");
                }
                else
                {
                    if (ar.AracGuncelle(a))
                    {
                        MessageBox.Show("Arac bilgileri değiştirildi.", "Guncelleme gerçekleşti.");
                        dgvAraclar.DataSource = ar.AracListele();
                        tsDegistir.Enabled = false;
                        tsSil.Enabled=false;
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz!");
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
                    dgvAraclar.DataSource = ar.AracListele();
                    tsDegistir.Enabled = false;
                    tsSil.Enabled = false;
                    Temizle();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "www.yazilimkodlama.com";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            //pbArac.ImageLocation = DosyaYolu;
            
        }
    }
}
