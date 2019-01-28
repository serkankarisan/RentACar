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
    public partial class frmKullaniciIslemleri : Form
    {
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
        }
        KullaniciRepository kper = new KullaniciRepository();
        int ID;
        private void tsYeni_Click(object sender, EventArgs e)
        {
            Supurge();
            tsKaydet.Enabled = true;
            txtKullaniciAdi.Focus();
        }
        private void Supurge()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && (!string.IsNullOrEmpty(txtSifre.Text)) && (!string.IsNullOrEmpty(txtSifreTekrar.Text)))
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    Kullanici yeni = new Kullanici();
                    yeni.UserName = txtKullaniciAdi.Text;
                    if (kper.KullaniciKontrol(yeni))
                    {
                        MessageBox.Show("Bu Kullanıcı kayıtlı!", "Aynı Kullanıcı zaten var!");
                    }
                    else
                    {
                        yeni.Password = txtSifre.Text;
                        yeni.Personel.Adi = cbPersonel.SelectedItem.ToString();
                        yeni.Yetki.RoleName = cbYetki.SelectedItem.ToString();
                        if (kper.KullaniciEkle(yeni))
                        {
                            MessageBox.Show("Yeni Kullanici eklendi.", "Kayıt gerçekleşti.");
                            dgvKullanicilar.DataSource = kper.KullaniciListele();
                            tsKaydet.Enabled = false;
                            Supurge();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı şifre girişi!", "Şifre Eşleşme Hatası!");
                }
            }
            else
            {
                MessageBox.Show("Girelecek bilgiler boş bırakılamaz.", "Hata");
            }
            txtKullaniciAdi.Focus();


            tsYeni.Enabled = true;
            tsKaydet.Enabled = false;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
        }

        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void dgvKullanicilar_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells[0].Value);
            txtKullaniciAdi.Text = dgvKullanicilar.SelectedRows[0].Cells[1].Value.ToString();
            txtSifre.Text = dgvKullanicilar.SelectedRows[0].Cells[2].Value.ToString();
            txtSifreTekrar.Text = dgvKullanicilar.SelectedRows[0].Cells[3].Value.ToString();
            cbPersonel.Text = dgvKullanicilar.SelectedRows[0].Cells[4].Value.ToString();
            cbYetki.Text = dgvKullanicilar.SelectedRows[0].Cells[5].Value.ToString();
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;
            txtKullaniciAdi.Focus();
        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && (!string.IsNullOrEmpty(txtSifre.Text)) && (!string.IsNullOrEmpty(txtSifreTekrar.Text)))
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    Kullanici degisen = new Kullanici();
                    degisen.UserName = txtKullaniciAdi.Text;
                    if (kper.KullaniciKontrol(degisen))
                    {
                        MessageBox.Show("Bu Kullanıcı kayıtlı!", "Aynı Kullanıcı zaten var!");
                    }
                    else
                    {
                        degisen.Password = txtSifre.Text;
                        degisen.Personel.Adi = cbPersonel.SelectedItem.ToString();
                        degisen.Yetki.RoleName = cbYetki.SelectedItem.ToString();
                        if (kper.KullaniciGuncelle(degisen))
                        {
                            MessageBox.Show("Yeni Kullanici eklendi.", "Kayıt gerçekleşti.");
                            dgvKullanicilar.DataSource = kper.KullaniciListele();
                            tsKaydet.Enabled = false;
                            Supurge();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı şifre girişi!", "Şifre Eşleşme Hatası!");
                }
            }
            else
            {
                MessageBox.Show("Girelecek bilgiler boş bırakılamaz.", "Hata");
            }
            txtKullaniciAdi.Focus();


            tsYeni.Enabled = true;
            tsKaydet.Enabled = false;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kper.KullaniciSil(ID))
                {
                    MessageBox.Show("Personel bilgileri silindi.", "Silme gerçekleşti.");
                    dgvKullanicilar.DataSource = kper.KullaniciListele();
                    tsDegistir.Enabled = false;
                    tsSil.Enabled = false;
                    Supurge();
                }
            }
        }
    }
}
