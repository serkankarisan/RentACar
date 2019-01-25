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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        Giris g = new Giris();
        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (g.KullaniciKontrol(txtKullaniciAdi.Text,txtSifre.Text))
            {
                frmAnaSayfa frm = new frmAnaSayfa();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Kullanıcı Adı!!!", "Giriş Yapılamadı!!!");
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Sifre")
            {
                txtSifre.Clear();
            }
            txtSifre.PasswordChar = '*';

        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanici Adi")
            {
                txtKullaniciAdi.Clear();
            }
        }



        //public void FormAcikmi(Form AcilacakForm)
        //{
        //    bool Varmi = false;
        //    for (int i = 0; i < this.MdiChildren.Length; i++)
        //    {
        //        if (AcilacakForm.Name == MdiChildren[i].Name)
        //        {
        //            MdiChildren[i].Focus();
        //            Varmi = true;
        //        }
        //    }
        //    if (Varmi == false)
        //    {
        //        AcilacakForm.MdiParent = this;
        //        AcilacakForm.Show();
        //    }
        //    else
        //    {
        //        AcilacakForm.Dispose(); //Nesne hafızadan atılır.
        //    }
        //}
    }
}
