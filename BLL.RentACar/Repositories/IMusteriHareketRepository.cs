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
        List<MusteriHareket> MusteriHareketGetir();
        List<MusteriHareket> MusteriHareketGetirById(int ID);
        List<MusteriHareket> MusteriHareketGetirByMusteri(string Ad,string Soyad,string TCKNo,string EhliyetNo);
        List<MusteriHareket> MusteriHareketGetirByTarih(DateTime baslangic, DateTime bitis);

        bool MusteriHareketEkle(MusteriHareket mh);
        bool MusteriHareketGuncelle(MusteriHareket mh);

        bool MusteriHareketSil(int ID);
        bool MusteriHareketSil(MusteriHareket mh);
    }
}
