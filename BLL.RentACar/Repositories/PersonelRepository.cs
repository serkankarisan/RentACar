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
            bool Sonuc = false;
            Genel.ent.Personeller.Add(P);
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

        public List<Personel> PersonelListele()
        {
            return Genel.ent.Personeller.Where(p => p.Silindi == false).ToList();
        }

        public Personel PersonelGetirById(int ID)
        {
            Personel getirilen = (from p in Genel.ent.Personeller
                                where p.Id == ID
                                select p).FirstOrDefault();
            return getirilen;
        }

        public bool PersonelGuncelle(Personel P)
        {
            bool Sonuc = false;
            Personel degisen = PersonelGetirById(P.Id);
            degisen = P;
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

        public bool PersonelSil(int ID)
        {
            bool Sonuc = false;
            Personel supurge = (from p in Genel.ent.Personeller
                                where p.Id == ID
                                select p).FirstOrDefault();
            supurge.Silindi = true;
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

        public bool PersonelSil(Personel P)
        {
            bool Sonuc = false;
            Genel.ent.Personeller.Remove(P);
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

        public List<Personel> PersonelSorgula(string Ad, string Soyad)
        {
            List<Personel> sorgu = (from s in Genel.ent.Personeller
                                    where s.Adi.StartsWith(Ad) && s.Soyadi.StartsWith(Soyad)
                                    select s).ToList();
            return sorgu;
        }

        public bool PersonelKontrol(Personel P)
        {
            return Convert.ToBoolean(Genel.ent.Personeller.Where(k => k.Adi == P.Adi && k.Soyadi == P.Soyadi).ToList().Count);
        }
    }
}
