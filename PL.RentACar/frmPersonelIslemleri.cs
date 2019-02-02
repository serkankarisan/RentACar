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
    public partial class frmPersonelIslemleri : Form
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
        }
        PersonelRepository per = new PersonelRepository();
        int ID;
        decimal result;
        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text))
            {
                if (!string.IsNullOrEmpty(txtSoyad.Text))
                {
                    if (!string.IsNullOrEmpty(txtTelefon.Text))
                    {
                        if (!string.IsNullOrEmpty(txtEmail.Text))
                        {
                            if (!string.IsNullOrEmpty(txtAdres.Text))
                            {
                                if (!string.IsNullOrEmpty(txtMaas.Text))
                                {
                                    if (decimal.TryParse(txtMaas.Text, out result))
                                    {
                                        Personel yeni = new Personel();
                                        yeni.Adi = txtAd.Text.Substring(0, 1).ToUpper() + txtAd.Text.Substring(1).ToLower();
                                        yeni.Soyadi = txtAd.Text.Substring(0, 1).ToUpper() + txtAd.Text.Substring(1).ToLower();
                                        yeni.Telefon = txtTelefon.Text;
                                        yeni.Email = txtEmail.Text + cbEmail.Text;
                                        if (per.PersonelKontrol(yeni))
                                        {
                                            MessageBox.Show("Önceden Kayıt Edilmiş Telefon veya E-Mail Girişi!", "Hata!");
                                        }
                                        else
                                        {
                                            yeni.Adres = txtAdres.Text;
                                            yeni.Maas = Convert.ToDecimal(txtMaas.Text);
                                            if (per.PersonelEkle(yeni))
                                            {
                                                MessageBox.Show("Yeni Personel eklendi.", "Kayıt gerçekleşti.");
                                                dgvPersoneller.DataSource = per.PersonelListele();
                                                dgvColumns();
                                                Disable();
                                                tsKaydet.Enabled = false;
                                                Supurge();
                                                tsYeni.Enabled = true;
                                                tsKaydet.Enabled = false;
                                                tsDegistir.Enabled = false;
                                                tsSil.Enabled = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Maas Sayı girilmelidir!", "Maas Hatası!");
                                    }
                                }
                                else
                                    MessageBox.Show("Maas Girmelisiniz.", "Bu Alan Boş Geçilemez");
                            }
                            else
                                MessageBox.Show("Adres Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                        }
                        else
                            MessageBox.Show("Email Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                    }
                    else
                        MessageBox.Show("Telefon Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                }
                else
                    MessageBox.Show("Soyad Girmelisiniz.", "Bu Alan Boş Geçilemez.");
            }
            else
            {
                MessageBox.Show("Ad Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                txtAd.Focus();
            }
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {
            Enable();
            Supurge();
            tsKaydet.Enabled = true;
            txtAd.Focus();
        }
        private void Supurge()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            txtMaas.Clear();
        }

        private void dgvPersoneller_DoubleClick(object sender, EventArgs e)
        {
            Enable();
            ID = Convert.ToInt32(dgvPersoneller.SelectedRows[0].Cells[0].Value);
            txtAd.Text = dgvPersoneller.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyad.Text = dgvPersoneller.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefon.Text = dgvPersoneller.SelectedRows[0].Cells[3].Value.ToString();
            string[] email = dgvPersoneller.SelectedRows[0].Cells[4].Value.ToString().Split('@');
            txtEmail.Text = email[0];
            foreach (string item in cbEmail.Items)
            {
                if (item == "@" + email[1])
                {
                    cbEmail.SelectedItem = item;
                }
            }
            txtAdres.Text = dgvPersoneller.SelectedRows[0].Cells[5].Value.ToString();
            txtMaas.Text = dgvPersoneller.SelectedRows[0].Cells[6].Value.ToString();
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;
            txtAd.Focus();
        }

        private void tsbDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text))
            {
                if (!string.IsNullOrEmpty(txtSoyad.Text))
                {
                    if (!string.IsNullOrEmpty(txtTelefon.Text))
                    {
                        if (!string.IsNullOrEmpty(txtEmail.Text))
                        {
                            if (!string.IsNullOrEmpty(txtAdres.Text))
                            {
                                if (!string.IsNullOrEmpty(txtMaas.Text))
                                {
                                    if (decimal.TryParse(txtMaas.Text, out result))
                                    {
                                        Personel degisen = new Personel();
                                        degisen.Id = ID;
                                        degisen.Adi = txtAd.Text.Substring(0, 1).ToUpper() + txtAd.Text.Substring(1).ToLower();
                                        degisen.Soyadi = txtSoyad.Text.Substring(0, 1).ToUpper() + txtSoyad.Text.Substring(1).ToLower();
                                        degisen.Telefon = txtTelefon.Text;
                                        degisen.Email = txtEmail.Text + cbEmail.Text;
                                        if (per.PersonelKontrolByDegistir(degisen))
                                        {
                                            MessageBox.Show("Önceden Kayıt Edilmiş Telefon veya E-Mail Girişi!", "Değişim Hatası.");
                                        }
                                        else
                                        {
                                            degisen.Adres = txtAdres.Text;
                                            degisen.Maas = Convert.ToDecimal(txtMaas.Text);
                                            if (per.PersonelGuncelle(degisen))
                                            {
                                                MessageBox.Show("Personel bilgileri değiştirildi.", "Değişiklik gerçekleşti.");
                                                dgvPersoneller.DataSource = per.PersonelListele();
                                                dgvColumns();
                                                Disable();
                                                tsKaydet.Enabled = false;
                                                tsSil.Enabled = false;
                                                tsDegistir.Enabled = false;
                                                Supurge();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Maas Sayı girilmelidir!", "Maas Hatası!");
                                    }
                                }
                                else
                                    MessageBox.Show("Maas Girmelisiniz.", "Bu Alan Boş Geçilemez");
                            }
                            else
                                MessageBox.Show("Adres Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                        }
                        else
                            MessageBox.Show("Email Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                    }
                    else
                        MessageBox.Show("Telefon Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                }
                else
                    MessageBox.Show("Soyad Girmelisiniz.", "Bu Alan Boş Geçilemez.");
            }
            else
            {
                MessageBox.Show("Ad Girmelisiniz.", "Bu Alan Boş Geçilemez.");
                txtAd.Focus();
            }
        }

        private void tsbSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Personel silinen = per.PersonelGetirById(ID);
                if (per.PersonelSil(silinen))
                {
                    MessageBox.Show("Personel bilgileri silindi.", "Silme gerçekleşti.");
                    dgvPersoneller.DataSource = per.PersonelListele();
                    dgvColumns();
                    tsDegistir.Enabled = false;
                    tsSil.Enabled = false;
                    Supurge();
                    Disable();
                }
            }
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            Disable();
            dgvPersoneller.DataSource = per.PersonelListele();
            dgvColumns();
            tsKaydet.Enabled = false;
            cbEmail.SelectedIndex = 0;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enable()
        {
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
            dgvPersoneller.Columns[0].Visible = false;
            dgvPersoneller.Columns[1].Width = 100;
            dgvPersoneller.Columns[2].Width = 100;
            dgvPersoneller.Columns[3].Width = 125;
            dgvPersoneller.Columns[4].Width = 175;
            dgvPersoneller.Columns[5].Width = 175;
            dgvPersoneller.Columns[6].Width = 125;
            dgvPersoneller.Columns[7].Visible = false;
        }
    }
}

