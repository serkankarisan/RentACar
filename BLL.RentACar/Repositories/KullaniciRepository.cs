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
            bool Sonuc = false;
            Genel.ent.Kullanicilar.Add(k);
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public Kullanici KullaniciGetirById(int ID)
        {
            Kullanici kullanici= (from k in Genel.ent.Kullanicilar
                               where k.Id == ID
                               select k).FirstOrDefault();

            return kullanici;
        }

        public bool KullaniciGuncelle(Kullanici k)
        {
            bool Sonuc = false;
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool KullaniciKontrol(Kullanici yeni)
        {
            return Convert.ToBoolean(Genel.ent.Kullanicilar.Where(k => k.UserName == yeni.UserName).ToList().Count);
        }

        public List<Kullanici> KullaniciListele()
        {
            return Genel.ent.Kullanicilar.Where(k => k.Silindi == false).ToList();
        }

        public List<Kullanici> KullaniciListeleByPeronel(string Ad, string Soyad)
        {
            return Genel.ent.Kullanicilar.Where(k => k.Silindi == false && k.Personel.Adi.Contains(Ad) && k.Personel.Soyadi.Contains(Soyad)).ToList();
        }

        public bool KullaniciSil(int ID)
        {
            bool Sonuc = false;
            Kullanici silinen = (from k in Genel.ent.Kullanicilar
                               where k.Id == ID
                               select k).FirstOrDefault();
            silinen.Silindi = true;
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool KullaniciSil(Kullanici k)
        {
            bool Sonuc = false;
            Genel.ent.Kullanicilar.Remove(k);
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
    }
}
