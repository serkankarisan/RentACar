using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public class Giris : IGiris
    {
        
        public bool KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            return Convert.ToBoolean(Genel.ent.Kullanicilar.Where(k => k.UserName == KullaniciAdi && k.Password==Sifre).ToList().Count);
        }

        public bool SifreDegistir()
        {
            throw new NotImplementedException();
        }
    }
}
