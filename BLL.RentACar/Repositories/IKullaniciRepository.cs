using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IKullaniciRepository
    {
        bool KullaniciKontrol(Kullanici yeni);
        List<Kullanici> KullaniciListele();
        Kullanici KullaniciGetirById(int ID);
        List<Kullanici> KullaniciListeleByPeronel(string Ad,string Soyad);

        bool KullaniciEkle(Kullanici k);
        bool KullaniciGuncelle(Kullanici k);

        bool KullaniciSil(int ID);
        bool KullaniciSil(Kullanici k);
    }
}
