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
                Kullanici yeni = new Kullanici();
                yeni.UserName = txtKullaniciAdi.Text;
                if (kper.KullaniciKontrol(yeni))
                {
                    MessageBox.Show("Bu Kullanıcı kayıtlı!", "Aynı Kullanıcı zaten var!");
                }
                else
                {
                    yeni.Password = txtSifre.Text;
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
    }
}
