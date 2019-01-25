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
        List<Sozlesme> SozlesmeListele();
        Sozlesme SozlesmeGetirById(int ID);
        List<Sozlesme> SozlesmeListeleByMusteri(string Ad, string Soyad, string TCKNo, string EhliyetNo);
        List<Sozlesme> SozlesmeListeleByTarih(DateTime baslangic, DateTime bitis);

        bool SozlesmeEkle(Sozlesme s);
        bool SozlesmeGuncelle(Sozlesme s);

        bool SozlesmeSil(int ID);
        bool SozlesmeSil(Sozlesme s);
    }
}
