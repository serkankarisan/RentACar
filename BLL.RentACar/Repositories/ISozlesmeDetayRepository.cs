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
        List<SozlesmeDetay> SozlesmeDetayListele();
        List<SozlesmeDetay> SozlesmeDetayGetirBySozlesmeId(int ID);
        List<SozlesmeDetay> SozlesmeDetayListeleByAranan(string Ad, string Soyad, string TCKNo, string EhliyetNo);
        List<SozlesmeDetay> SozlesmeDetayListeleByTarih(DateTime baslangic, DateTime bitis);
        List<SozlesmeDetay> SozlesmeDetaySorgula(int SozlesmeId, string TckNo, string EhliyetNo, DateTime Baslangic, DateTime Bitis);
        List<SozlesmeDetay> SozlesmeDetaySorgula(string TckNo, string EhliyetNo, DateTime Baslangic, DateTime Bitis);
        List<SozlesmeDetay> SozlesmeDetaySorgula(DateTime Baslangic, DateTime Bitis);
        bool SozlesmeDetayEkle(SozlesmeDetay s);
        bool SozlesmeDetayGuncelle(SozlesmeDetay s);

        bool SozlesmeDetaySil(int ID);
        bool SozlesmeDetaySil(SozlesmeDetay s);
    }
}
