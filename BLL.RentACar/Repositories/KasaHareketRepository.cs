using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class KasaHareketRepository : IKasaHareketRepository
    {
        public bool KasaHareketEkle(KasaHareket kh)
        {
            throw new NotImplementedException();
        }

        public KasaHareket KasaHareketGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public bool KasaHareketGuncelle(KasaHareket kh)
        {
            throw new NotImplementedException();
        }

        public List<KasaHareket> KasaHareketListele()
        {
            throw new NotImplementedException();
        }

        public List<KasaHareket> KasaHareketListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public bool KasaHareketSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool KasaHareketSil(KasaHareket kh)
        {
            throw new NotImplementedException();
        }
    }
}
