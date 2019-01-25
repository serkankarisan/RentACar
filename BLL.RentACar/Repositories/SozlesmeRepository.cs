using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class SozlesmeRepository : ISozlesmeRepository
    {
        public bool SozlesmeEkle(Sozlesme s)
        {
            throw new NotImplementedException();
        }

        public Sozlesme SozlesmeGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public bool SozlesmeGuncelle(Sozlesme s)
        {
            throw new NotImplementedException();
        }

        public List<Sozlesme> SozlesmeListele()
        {
            throw new NotImplementedException();
        }

        public List<Sozlesme> SozlesmeListeleByMusteri(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
            throw new NotImplementedException();
        }

        public List<Sozlesme> SozlesmeListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public bool SozlesmeSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool SozlesmeSil(Sozlesme s)
        {
            throw new NotImplementedException();
        }
    }
}
