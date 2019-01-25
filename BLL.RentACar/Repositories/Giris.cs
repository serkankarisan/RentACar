using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.RentACar.Repositories
{
    public class Giris : IGiris
    {
        
        public bool KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            bool Sonuc = false;
            Kullanici kullanici= Genel.ent.Kullanicilar.Where(k => k.UserName == KullaniciAdi && k.Password == Sifre).FirstOrDefault();
            if (kullanici!=null)
            {
                Genel.UserName = kullanici.Personel.Adi+"  "+kullanici.Personel.Soyadi;
                Genel.Yetki = kullanici.Yetki.RoleName;
                Sonuc = true;
            }
            return Sonuc;
        }

        public bool SifreDegistir()
        {
            throw new NotImplementedException();
        }
    }
}
