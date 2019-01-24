using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class AracRepository : IAracRepository
    {
        public bool AracEkle(Arac A)
        {
            throw new NotImplementedException();
        }

        public List<Arac> AracGetir()
        {
            throw new NotImplementedException();
        }

        public List<Arac> AracGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Arac> AracGetirByPlaka(string Plaka)
        {
            throw new NotImplementedException();
        }

        public bool AracGuncelle(Arac A)
        {
            throw new NotImplementedException();
        }

        public bool AracSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool AracSil(Arac A)
        {
            throw new NotImplementedException();
        }
    }
}
