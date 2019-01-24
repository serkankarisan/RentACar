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
        List<Arac> AracGetir();
        List<Arac> AracGetirById(int ID);
        List<Arac> AracGetirByPlaka(string Plaka);

        bool AracEkle(Arac A);
        bool AracGuncelle(Arac A);

        bool AracSil(int ID);
        bool AracSil(Arac A);

    }
}
