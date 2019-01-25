using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class PersonelRepository : IPersonelRepository
    {
        public bool PersonelEkle(Personel P)
        {
            throw new NotImplementedException();
        }

        public Personel PersonelGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public bool PersonelGuncelle(Personel P)
        {
            throw new NotImplementedException();
        }

        public List<Personel> PersonelListele()
        {
            throw new NotImplementedException();
        }

        public bool PersonelSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool PersonelSil(Personel P)
        {
            throw new NotImplementedException();
        }

        public List<Personel> PersonelSorgula(string Ad, string Soyad)
        {
            throw new NotImplementedException();
        }
    }
}
