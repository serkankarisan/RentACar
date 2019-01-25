using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IKasaHareketRepository
    {
        List<KasaHareket> KasaHareketListele();
        KasaHareket KasaHareketGetirById(int ID);
        List<KasaHareket> KasaHareketListeleByTarih(DateTime baslangic,DateTime bitis);

        bool KasaHareketEkle(KasaHareket kh);
        bool KasaHareketGuncelle(KasaHareket kh);

        bool KasaHareketSil(int ID);
        bool KasaHareketSil(KasaHareket kh);
    }
}
