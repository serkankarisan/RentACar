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
            bool Sonuc = false;
            //Önce arakatmana eklenir.
            Genel.ent.KasaHareketler.Add(kh);
            try
            {
                Genel.ent.SaveChanges(); //Arakatmana göre veritabanı güncellenir.
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
        
        public KasaHareket KasaHareketGetirById(int ID)
        {
            KasaHareket degisen = (from kh in Genel.ent.KasaHareketler
                                  where kh.Id == ID
                                  select kh).FirstOrDefault();
            return degisen;
        }

        public bool KasaHareketGuncelle(KasaHareket kh)
        {
            bool Sonuc = false;
            try
            {
                Genel.ent.SaveChanges(); //Arakatmana göre veritabanı güncellenir.
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public List<KasaHareket> KasaHareketListele()
        {
            return Genel.ent.KasaHareketler.ToList();
        }

        public List<KasaHareket> KasaHareketListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            List<KasaHareket> listeTarih = (from kh in Genel.ent.KasaHareketler
                                            where kh.Tarih >= baslangic && kh.Tarih <= bitis
                                            select kh).ToList();
            return listeTarih;
        }

        public bool KasaHareketSil(int ID)
        {
            bool Sonuc = false;
            KasaHareket silinen = (from kh in Genel.ent.KasaHareketler
                                   where kh.Id == ID
                                   select kh).FirstOrDefault();
            Genel.ent.KasaHareketler.Remove(silinen);
            try
            {
                Genel.ent.SaveChanges(); //Arakatmana göre veritabanı güncellenir.
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool KasaHareketSil(KasaHareket silinen)
        {
            bool Sonuc = false;
            //Önce arakatmandan silinir.
            Genel.ent.KasaHareketler.Remove(silinen);
            try
            {
                Genel.ent.SaveChanges(); //Arakatmana göre veritabanı güncellenir.
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
