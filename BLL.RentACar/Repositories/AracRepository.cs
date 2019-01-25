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
            bool Sonuc = false;

            Genel.ent.Araclar.Add(A);
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

        public List<Arac> AracListele()
        {
            return Genel.ent.Araclar.ToList();
        }

        public Arac AracGetirById(int ID)
        {
            Arac bulunan = (from a in Genel.ent.Araclar
                            where a.Id == ID
                            select a).FirstOrDefault();

            return bulunan;
        }

        public Arac AracGetirByPlaka(string Plaka)
        {
            Arac bulunan = (from a in Genel.ent.Araclar
                            where a.Plaka == Plaka
                            select a).FirstOrDefault();
            return bulunan;
        }

        public bool AracGuncelle(Arac A)
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

        public bool AracSil(int ID)
        {
            bool Sonuc = false;
            Arac silinen = (from a in Genel.ent.Araclar
                            where a.Id == ID
                            select a).FirstOrDefault();
            Genel.ent.Araclar.Remove(silinen);

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

        public bool AracSil(Arac A)
        {
            bool Sonuc = false;

            Genel.ent.Araclar.Remove(A);
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

        public bool AracKontrol(Arac c)
        {
            bool Sonuc = false;
            Arac aranan = (from a in Genel.ent.Araclar
                           where a.Plaka == c.Plaka
                           select a).FirstOrDefault();
            if (aranan != null)
            {
                Sonuc = true;
            }
            return Sonuc;
        }
    }
}
