using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IGiris
    {
        bool KullaniciKontrol(string KullaniciAdi,string Sifre);
        bool SifreDegistir();

    }
}
