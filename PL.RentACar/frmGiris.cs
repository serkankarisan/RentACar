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
            RentContext context = new RentContext();
            if (context.Araclar.Count() == 0)
            {
                context.Araclar.Add(
                new Arac { Id = 1, Marka = "Fiat", Model = "Doblo", GünlükFiyat = 100, Tip = "Cargo", Renk = "Kırmızı", Plaka = "34DBL34", AracDurumu = "Hasar yok", YakitDurumu = "%50", Varmi = true, Silindi = false, ResimYolu = "\\araclar\\doblokırmızı.png" }
                );
                context.Araclar.Add(
                  new Arac { Id = 2, Marka = "Audi", Model = "A7", GünlükFiyat = 150, Tip = "Sedan", Renk = "Beyaz", Plaka = "34ASD12", AracDurumu = "Hasar yok", YakitDurumu = "%75", Varmi = true, Silindi = false, ResimYolu = "\\araclar\\a7siyah.png.png" }
                  );
            }
            if (context.GelirGider.Count() == 0)
            {
                context.GelirGider.Add(
                new GelirGider { Id = 1, Aciklama = "Maaş Ödeme", Tür = "Gider", Silindi = false }
                );
                context.GelirGider.Add(
                    new GelirGider { Id = 2, Aciklama = "Sözleşme", Tür = "Gelir", Silindi = false }
                );
                context.GelirGider.Add(
                    new GelirGider { Id = 3, Aciklama = "Araç Satış", Tür = "Gelir", Silindi = false }
                );
                context.GelirGider.Add(
                    new GelirGider { Id = 4, Aciklama = "Araç Vergi", Tür = "Gider", Silindi = false }
                );
                context.GelirGider.Add(
                    new GelirGider { Id = 5, Aciklama = "Araç Muayene", Tür = "Gider", Silindi = false }
                );
                context.GelirGider.Add(
                    new GelirGider { Id = 6, Aciklama = "Araç Diğer", Tür = "Gider", Silindi = false }
                    );
            }
            if (context.Kullanicilar.Count() == 0)
            {
                context.Kullanicilar.Add(
               new Kullanici { Id = 1, UserName = "rent", Password = "123", RoleId = 1, PersonelId = 1, Silindi = false }
               );
                context.Kullanicilar.Add(new Kullanici { Id = 2, UserName = "a", Password = "1", RoleId = 2, PersonelId = 2, Silindi = false }
                   );
            }
            if (context.Personeller.Count() == 0)
            {
                context.Personeller.Add(
            new Personel { Id = 1, Adi = "Ali", Soyadi = "Uçar", Telefon = "2123114567", Maas = 3000, Adres = "Beşiktaş -İstanbul", Email = "ali@gmail.com", Silindi = false });
                context.Personeller.Add(
                new Personel { Id = 2, Adi = "Ahmet", Soyadi = "Coşar", Telefon = "2166543445", Maas = 2000, Adres = "Kartal -İstanbul", Email = "ahmet@gmail.com", Silindi = false }
                   );
            }
            if (context.Yetkiler.Count() == 0)
            {
                context.Yetkiler.Add(
            new Yetki { Id = 1, RoleName = "Yönetici" });
                context.Yetkiler.Add(
                    new Yetki { Id = 2, RoleName = "Personel" }
                   );
            }
            context.SaveChanges();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (g.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text))
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
