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
            if (!string.IsNullOrEmpty(txtAd.Text) && (!string.IsNullOrEmpty(txtSoyad.Text)) && (!string.IsNullOrEmpty(txtTelefon.Text)) && (!string.IsNullOrEmpty(txtEmail.Text)) && (!string.IsNullOrEmpty(txtAdres.Text)) && (!string.IsNullOrEmpty(txtMaas.Text)))
            {
                if (decimal.TryParse(txtMaas.Text, out result))
                {
                    Personel yeni = new Personel();
                    yeni.Adi = txtAd.Text;
                    yeni.Soyadi = txtSoyad.Text;
                    if (per.PersonelKontrol(yeni))
                    {
                        MessageBox.Show("Bu Personel kayıtlı!", "Aynı Personel zaten var!");
                    }
                    else
                    {
                        yeni.Telefon = txtTelefon.Text;
                        yeni.Email = txtEmail.Text;
                        yeni.Adres = txtAdres.Text;
                        yeni.Maas = Convert.ToDecimal(txtMaas.Text);
                        if (per.PersonelEkle(yeni))
                        {
                            MessageBox.Show("Yeni Personel eklendi.", "Kayıt gerçekleşti.");
                            dgvPersoneller.DataSource = per.PersonelListele();
                            tsbKaydet.Enabled = false;
                            Supurge();
                            tsbYeni.Enabled = true;
                            tsbKaydet.Enabled = false;
                            tsbDegistir.Enabled = false;
                            tsbSil.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Maas Sayı girilmelidir!", "Maas Hatası!");
                }
            }
            else
            {
                MessageBox.Show("Girelecek bilgiler boş bırakılamaz.", "Hata");
            }
            txtAd.Focus();
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {
            Supurge();
            tsbKaydet.Enabled = true;
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
            ID = Convert.ToInt32(dgvPersoneller.SelectedRows[0].Cells[0].Value);
            txtAd.Text = dgvPersoneller.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyad.Text = dgvPersoneller.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefon.Text = dgvPersoneller.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dgvPersoneller.SelectedRows[0].Cells[4].Value.ToString();
            txtAdres.Text = dgvPersoneller.SelectedRows[0].Cells[5].Value.ToString();
            txtMaas.Text = dgvPersoneller.SelectedRows[0].Cells[6].Value.ToString();
            tsbDegistir.Enabled = true;
            tsbSil.Enabled = true;
            tsbKaydet.Enabled = false;
            txtAd.Focus();
        }

        private void tsbDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text) && (!string.IsNullOrEmpty(txtSoyad.Text)) && (!string.IsNullOrEmpty(txtTelefon.Text)) && (!string.IsNullOrEmpty(txtEmail.Text)) && (!string.IsNullOrEmpty(txtAdres.Text)) && (!string.IsNullOrEmpty(txtMaas.Text)))
            {
                if (decimal.TryParse(txtMaas.Text, out result))
                {
                    Personel degisen = per.PersonelGetirById(ID);
                    degisen.Adi = txtAd.Text;
                    degisen.Soyadi = txtSoyad.Text;
                    //if (per.PersonelKontrol(degisen))
                    //{
                    //    MessageBox.Show("Bu Personel kayıtlı!", "Aynı Personel zaten var!");
                    //}
                    //else
                    //{
                    degisen.Telefon = txtTelefon.Text;
                    degisen.Email = txtEmail.Text;
                    degisen.Adres = txtAdres.Text;
                    degisen.Maas = Convert.ToDecimal(txtMaas.Text);
                    if (per.PersonelGuncelle(degisen))
                    {
                        MessageBox.Show("Personel bilgileri değiştirildi.", "Değişiklik gerçekleşti.");
                        dgvPersoneller.DataSource = per.PersonelListele();
                        tsbKaydet.Enabled = false;
                        Supurge();
                    }
                }
                //}
                else
                {
                    MessageBox.Show("Maas Sayı girilmelidir!", "Maas Hatası!");
                }
            }
            else
            {
                MessageBox.Show("Girelecek bilgiler boş bırakılamaz.", "Hata");
            }
            txtAd.Focus();
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
                    tsbDegistir.Enabled = false;
                    tsbSil.Enabled = false;
                    Supurge();
                }
            }
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            dgvPersoneller.DataSource = per.PersonelListele();
            tsbKaydet.Enabled = true;
        }
    }
}
