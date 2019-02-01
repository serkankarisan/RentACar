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
            return Genel.ent.Araclar.Where(a => a.Silindi == false).ToList();
        }
        public List<Arac> AracSorgulaByPlaka(string Plaka)
        {
            //return Genel.ent.Araclar.Where(a => a.Silindi == false && a.Plaka.Substring(0, Plaka.Length) == Plaka.Substring(0, Plaka.Length)).ToList();
            return Genel.ent.Araclar.Where(a => a.Silindi == false && a.Plaka.StartsWith(Plaka.ToUpper())).ToList();
        }
        public string[] AracListeleByMarka()
        {
            string[] araclar = Genel.ent.Araclar.Select(a=>a.Marka).Distinct().ToArray();
            return araclar;
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
            Arac bulunan = AracGetirById(A.Id);
            bulunan.Marka = A.Marka;
            bulunan.Model = A.Model;
            bulunan.Plaka = A.Plaka;
            bulunan.Tip = A.Tip;
            bulunan.Renk = A.Renk;
            bulunan.ResimYolu = A.ResimYolu;
            bulunan.Silindi = A.Silindi;
            bulunan.Varmi = A.Varmi;
            bulunan.YakitDurumu = A.YakitDurumu;
            bulunan.AracDurumu = A.AracDurumu;
            bulunan.GünlükFiyat = A.GünlükFiyat;
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

        public bool AracKontrolbyGuncelleme(Arac c)
        {
            bool Sonuc = false;
            Arac aranan = (from a in Genel.ent.Araclar
                           where a.Plaka == c.Plaka && a.Id!=c.Id
                           select a).FirstOrDefault();
            if (aranan != null)
            {
                Sonuc = true;
            }
            return Sonuc;
        }
    }
}
