using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IMusteriHareketRepository
    {
        List<MusteriHareket> MusteriHareketListele();
        List<MusteriHareket> MusteriHareketListeleByMusteri(int MusteriId);
        List<MusteriHareket> MusteriHareketListeleByTarih(DateTime baslangic, DateTime bitis);

        MusteriHareket MusteriHareketGetirById(int ID);

        bool MusteriHareketEkle(MusteriHareket mh);
        bool MusteriHareketGuncelle(MusteriHareket mh);

        bool MusteriHareketSil(int ID);
        bool MusteriHareketSil(MusteriHareket mh);
    }
}
