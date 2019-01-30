using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface ISozlesmeRepository
    {
        bool SozlesmeKontrol(Sozlesme yeni);
        List<Sozlesme> SozlesmeListele();
        Sozlesme SozlesmeGetirById(int ID);
        List<Sozlesme> SozlesmeListeleByMusteriId(int ID);
        List<Sozlesme> SozlesmeListeleByTarih(DateTime baslangic, DateTime bitis);
        List<Sozlesme> SozlesmeSorgula(int SozlesmeId, string TckNo, string EhliyetNo);

        bool SozlesmeEkle(Sozlesme s);
        bool SozlesmeGuncelle(Sozlesme s);

        bool SozlesmeSil(int ID);
        bool SozlesmeSil(Sozlesme s);
    }
}
