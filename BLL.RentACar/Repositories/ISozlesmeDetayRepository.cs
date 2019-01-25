using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface ISozlesmeDetayRepository
    {
        List<SozlesmeDetay> SozlesmeDetayGetir();
        List<SozlesmeDetay> SozlesmeDetayGetirById(int ID);
        List<SozlesmeDetay> SozlesmeDetayGetirByMusteri(string Ad, string Soyad, string TCKNo, string EhliyetNo);
        List<SozlesmeDetay> SozlesmeDetayGetirByTarih(DateTime baslangic, DateTime bitis);

        bool SozlesmeDetayEkle(SozlesmeDetay s);
        bool SozlesmeDetayGuncelle(SozlesmeDetay s);

        bool SozlesmeDetaySil(int ID);
        bool SozlesmeDetaySil(SozlesmeDetay s);
    }
}
