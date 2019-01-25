using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class KullaniciRepository : IKullaniciRepository
    {
        public bool KullaniciEkle(Kullanici k)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> KullaniciGetir()
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> KullaniciGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> KullaniciGetirByPeronel(string Ad, string Soyad)
        {
            throw new NotImplementedException();
        }

        public bool KullaniciGuncelle(Kullanici k)
        {
            throw new NotImplementedException();
        }

        public bool KullaniciSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool KullaniciSil(Kullanici k)
        {
            throw new NotImplementedException();
        }
    }
}
