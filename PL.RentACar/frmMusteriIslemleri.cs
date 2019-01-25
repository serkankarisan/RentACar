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
    public partial class frmMusteriIslemleri : Form
    {
        public frmMusteriIslemleri()
        {
            InitializeComponent();
        }
        MusteriRepository musrepo = new MusteriRepository();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            txtAd.Focus();
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTCKNo.Text) && !string.IsNullOrEmpty(txtEhliyetNo.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtTelefon.Text))
            {
                Musteri yeni = new Musteri();
                yeni.Adi = txtAd.Text;
                yeni.Soyadi = txtSoyad.Text;
                yeni.Telefon = txtTelefon.Text;
                yeni.Email = txtEmail.Text;
                yeni.Adres = txtAdres.Text;
                yeni.TcKimlikNo = txtTCKNo.Text;
                yeni.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
                yeni.Cinsiyet = cbCinsiyet.Text;
                yeni.EhliyetNo = txtEhliyetNo.Text;
                yeni.EhliyetTarihi = Convert.ToDateTime(dtpEhliyetTarihi.Text);
                if (musrepo.MusteriKontrol(yeni))
                {
                    MessageBox.Show("Bu müşteri kayıtlı!", "Aynı müşteri zaten var!");
                }
                else
                {
                    if (musrepo.MusteriEkle(yeni))
                    {
                        MessageBox.Show("Yeni müşteri eklendi.", "Kayıt gerçekleşti.");
                        dgvMusteriler.DataSource = musrepo.MusteriListele();
                        tsKaydet.Enabled = false;
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtAd.Focus();
        }

        private void frmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = musrepo.MusteriListele();
        }
    }
}
