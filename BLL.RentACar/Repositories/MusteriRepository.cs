using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class MusteriRepository : IMusteriRepository
    {
        public bool MusteriEkle(Musteri M)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> MusteriGetir()
        {
            throw new NotImplementedException();
        }

        public List<Musteri> MusteriGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public bool MusteriGuncelle(Musteri M)
        {
            throw new NotImplementedException();
        }

        public bool MusteriSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool MusteriSil(Musteri M)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> MusteriSorgula(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
            throw new NotImplementedException();
        }
    }
}
