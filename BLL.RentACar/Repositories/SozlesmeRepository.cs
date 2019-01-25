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

        public List<Sozlesme> SozlesmeGetir()
        {
            throw new NotImplementedException();
        }

        public List<Sozlesme> SozlesmeGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Sozlesme> SozlesmeGetirByMusteri(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
            throw new NotImplementedException();
        }

        public List<Sozlesme> SozlesmeGetirByTarih(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public bool SozlesmeGuncelle(Sozlesme s)
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
