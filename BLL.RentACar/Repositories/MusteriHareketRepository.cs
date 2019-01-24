using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class MusteriHareketRepository : IMusteriHareketRepository
    {
        public bool MusteriHareketEkle(MusteriHareket mh)
        {
            throw new NotImplementedException();
        }

        public List<MusteriHareket> MusteriHareketGetir()
        {
            throw new NotImplementedException();
        }

        public List<MusteriHareket> MusteriHareketGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<MusteriHareket> MusteriHareketGetirByMusteri(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
            throw new NotImplementedException();
        }

        public List<MusteriHareket> MusteriHareketGetirByTarih(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public bool MusteriHareketGuncelle(MusteriHareket mh)
        {
            throw new NotImplementedException();
        }

        public bool MusteriHareketSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool MusteriHareketSil(MusteriHareket mh)
        {
            throw new NotImplementedException();
        }
    }
}
