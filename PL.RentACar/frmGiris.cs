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
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (g.KullaniciKontrol(txtKullaniciAdi.Text,txtSifre.Text))
            {
                frmAnaSayfa frm = new frmAnaSayfa();
                frm.Show();
                this.Hide();
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

        private void pbSifreGizle_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != "Sifre")
            {
                if (txtSifre.PasswordChar == '*')
                {
                    txtSifre.PasswordChar = '\0';
                }
                else
                {
                    txtSifre.PasswordChar = '*';
                }
            }
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }
    }
}
