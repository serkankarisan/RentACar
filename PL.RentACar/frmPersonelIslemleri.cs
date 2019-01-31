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
                    yeni.Telefon = txtTelefon.Text;
                    if (per.PersonelKontrol(yeni))
                    {
                        MessageBox.Show("Bu Personel kayıtlı!", "Aynı Personel zaten var!");
                    }
                    else
                    {
                        yeni.Email = txtEmail.Text;
                        yeni.Adres = txtAdres.Text;
                        yeni.Maas = Convert.ToDecimal(txtMaas.Text);
                        if (per.PersonelEkle(yeni))
                        {
                            MessageBox.Show("Yeni Personel eklendi.", "Kayıt gerçekleşti.");
                            dgvPersoneller.DataSource = per.PersonelListele();
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
            {
                MessageBox.Show("Girelecek bilgiler boş bırakılamaz.", "Hata");
            }
            txtAd.Focus();
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
            txtEmail.Text = dgvPersoneller.SelectedRows[0].Cells[4].Value.ToString();
            txtAdres.Text = dgvPersoneller.SelectedRows[0].Cells[5].Value.ToString();
            txtMaas.Text = dgvPersoneller.SelectedRows[0].Cells[6].Value.ToString();
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;
            txtAd.Focus();
        }

        private void tsbDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text) && (!string.IsNullOrEmpty(txtSoyad.Text)) && (!string.IsNullOrEmpty(txtTelefon.Text)) && (!string.IsNullOrEmpty(txtEmail.Text)) && (!string.IsNullOrEmpty(txtAdres.Text)) && (!string.IsNullOrEmpty(txtMaas.Text)))
            {
                if (decimal.TryParse(txtMaas.Text, out result))
                {
                    Personel p = new Personel();
                    p = per.PersonelGetirById(ID);
                    p.Adi = txtAd.Text;
                    p.Telefon = txtTelefon.Text;
                    p.Soyadi = txtSoyad.Text;
                    if (per.PersonelKontrolByDegistir(p))
                    {
                        MessageBox.Show("Bu Personel kayıtlı!", "Aynı Personel zaten var!");
                    }
                    else
                    {
                    p.Email = txtEmail.Text;
                    p.Adres = txtAdres.Text;
                    p.Maas = Convert.ToDecimal(txtMaas.Text);
                    if (per.PersonelGuncelle(p))
                    {
                        MessageBox.Show("Personel bilgileri değiştirildi.", "Değişiklik gerçekleşti.");
                        dgvPersoneller.DataSource = per.PersonelListele();
                        tsKaydet.Enabled = false;
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
                    tsDegistir.Enabled = false;
                    tsSil.Enabled = false;
                    Supurge();
                }
            }
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            Disable();
            dgvPersoneller.DataSource = per.PersonelListele();
            tsKaydet.Enabled = false;
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
    }
}
