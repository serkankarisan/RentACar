using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IAracRepository
    {
        bool AracKontrol(Arac c);
        List<Arac> AracListele();
        Arac AracGetirById(int ID);
        Arac AracGetirByPlaka(string Plaka);

        bool AracEkle(Arac A);
        bool AracGuncelle(Arac A);

        bool AracSil(int ID);
        bool AracSil(Arac A);

    }
}
