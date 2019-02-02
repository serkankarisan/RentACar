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
        PersonelRepository per = new PersonelRepository();
        YetkiRepository yper = new YetkiRepository();
        int PersonelID;
        int YetkiID;
        int ID;
        private void tsYeni_Click(object sender, EventArgs e)
        {
            Enable();
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
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                if (!string.IsNullOrEmpty(txtSifre.Text))
                {
                    if (!string.IsNullOrEmpty(txtSifreTekrar.Text))
                    {
                        if (txtSifre.Text == txtSifreTekrar.Text)
                        {
                            Kullanici yeni = new Kullanici();
                            yeni.UserName = txtKullaniciAdi.Text;
                            yeni.PersonelId = PersonelID;
                            if (kper.KullaniciKontrol(yeni))
                            {
                                MessageBox.Show("Bu Kullanıcı kayıtlı!", "Aynı Kullanıcı zaten var!");
                            }
                            else
                            {
                                yeni.Password = txtSifre.Text;
                                yeni.RoleId = YetkiID;
                                if (kper.KullaniciEkle(yeni))
                                {
                                    MessageBox.Show("Yeni Kullanici eklendi.", "Kayıt gerçekleşti.");
                                    dgvKullanicilar.DataSource = kper.KullaniciListele();
                                    dgvColumns();
                                    Disable();
                                    tsKaydet.Enabled = false;
                                    tsDegistir.Enabled = false;
                                    tsSil.Enabled = false;
                                    Supurge();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Hatalı şifre girişi!", "Şifre Eşleşme Hatası!");
                    }
                    else
                        MessageBox.Show("Tekrar Şifre Girilmelidir!", "Hata!");
                }
                else
                    MessageBox.Show("Şifre Girilmelidir!", "Hata");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Girilmelidir!", "Hata!");
                txtKullaniciAdi.Focus();
            }
        }

        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            Disable();
            tsKaydet.Enabled = false;
            dgvKullanicilar.DataSource = kper.KullaniciListele();
            dgvColumns();
            cbPersonel.DataSource = per.PersonelListele();
            cbPersonel.SelectedIndex = 0;
            cbYetki.DataSource = yper.YetkiListele();
            cbYetki.SelectedIndex = 0;

        }

        private void dgvKullanicilar_DoubleClick(object sender, EventArgs e)
        {
            Enable();
            ID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells[0].Value);
            txtKullaniciAdi.Text = dgvKullanicilar.SelectedRows[0].Cells[3].Value.ToString();
            txtSifre.Text = dgvKullanicilar.SelectedRows[0].Cells[4].Value.ToString();
            txtSifreTekrar.Text = dgvKullanicilar.SelectedRows[0].Cells[4].Value.ToString();
            cbPersonel.Text = dgvKullanicilar.SelectedRows[0].Cells[6].Value.ToString();
            cbYetki.Text = dgvKullanicilar.SelectedRows[0].Cells[7].Value.ToString();
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;
            txtKullaniciAdi.Focus();
        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                if (!string.IsNullOrEmpty(txtSifre.Text))
                {
                    if (!string.IsNullOrEmpty(txtSifreTekrar.Text))
                    {
                        if (txtSifre.Text == txtSifreTekrar.Text)
                        {
                            Kullanici degisen = new Kullanici();
                            degisen.Id = ID;
                            degisen.UserName = txtKullaniciAdi.Text;
                            if (kper.KullaniciKontrolByDegistir(degisen))
                            {
                                MessageBox.Show("Çakışan Bilgiler Var!", "Hata!");
                            }
                            else
                            {
                                degisen.Password = txtSifre.Text;
                                degisen.PersonelId = PersonelID;
                                degisen.RoleId = YetkiID;

                                if (kper.KullaniciGuncelle(degisen))
                                {
                                    MessageBox.Show("Kullanici Değiştirildi.", "Değişiklik gerçekleşti.");
                                    dgvKullanicilar.DataSource = kper.KullaniciListele();
                                    dgvColumns();
                                    Disable();
                                    tsKaydet.Enabled = false;
                                    tsDegistir.Enabled = false;
                                    tsSil.Enabled = false;
                                    Supurge();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Hatalı şifre girişi!", "Şifre Eşleşme Hatası!");
                    }
                    else
                        MessageBox.Show("Tekrar Şifre Girilmelidir!", "Hata!");
                }
                else
                    MessageBox.Show("Şifre Girilmelidir!", "Hata");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Girilmelidir!", "Hata!");
                txtKullaniciAdi.Focus();
            }
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Kullanici silinen = kper.KullaniciGetirById(ID);
                if (kper.KullaniciSil(silinen))
                {
                    MessageBox.Show("Personel bilgileri silindi.", "Silme gerçekleşti.");
                    dgvKullanicilar.DataSource = kper.KullaniciListele();
                    dgvColumns();
                    tsDegistir.Enabled = false;
                    tsSil.Enabled = false;
                    tsKaydet.Enabled = false;
                    Disable();
                    Supurge();
                }
            }
        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel p = (Personel)cbPersonel.SelectedItem;
            PersonelID = p.Id;
        }

        private void cbYetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yetki y = (Yetki)cbYetki.SelectedItem;
            YetkiID = y.Id;
        }

        private void txtPersonelAdi_TextChanged(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = kper.KullaniciListeleByPersonel(txtPersonelAdi.Text, txtPersonelSoyadi.Text);
        }

        private void txtPersonelSoyadi_TextChanged(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = kper.KullaniciListeleByPersonel(txtPersonelAdi.Text, txtPersonelSoyadi.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Enable()
        {
            cbPersonel.Enabled = true;
            cbYetki.Enabled = true;
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
            cbPersonel.Enabled = false;
            cbYetki.Enabled = false;
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = false;
                }
            }
        }
        private void dgvColumns()
        {
            dgvKullanicilar.Columns[0].Visible = false;
            dgvKullanicilar.Columns[1].Visible = false;
            dgvKullanicilar.Columns[2].Visible = false;
            dgvKullanicilar.Columns[5].Visible = false;
        }
    }
}
