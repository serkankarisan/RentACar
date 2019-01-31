using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class MusteriHareketRepository : IMusteriHareketRepository
    {
        public bool MusteriHareketEkle(MusteriHareket mh)
        {
            bool Sonuc = false;
            Genel.ent.MusteriHareketler.Add(mh);
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

        public MusteriHareket MusteriHareketGetirById(int ID)
        {
            MusteriHareket musterihareket = (from mh in Genel.ent.MusteriHareketler
                                      where mh.Id == ID
                                      select mh).FirstOrDefault();

            return musterihareket;
        }

        public bool MusteriHareketGuncelle(MusteriHareket mh)
        {
            bool Sonuc = false;
            MusteriHareket degisen = MusteriHareketGetirById(mh.Id);
            degisen = mh;
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

        public List<MusteriHareket> MusteriHareketListele()
        {
            return Genel.ent.MusteriHareketler.Where(mh => mh.Silindi == false).ToList();
        }

        public List<MusteriHareket> MusteriHareketListeleByMusteri(int MusteriId)
        {
            return Genel.ent.MusteriHareketler.Where(mh => mh.Silindi == false && mh.MusteriId == MusteriId).ToList();
        }

        public List<MusteriHareket> MusteriHareketListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            return Genel.ent.MusteriHareketler.Where(mh => mh.Silindi == false && mh.Tarih>=baslangic && mh.Tarih<=bitis).ToList();
        }

        public bool MusteriHareketSil(int ID)
        {
            bool Sonuc = false;
            MusteriHareket silinen = (from mh in Genel.ent.MusteriHareketler
                                where mh.Id == ID
                                select mh).FirstOrDefault();
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

        public bool MusteriHareketSil(MusteriHareket mh)
        {
            bool Sonuc = false;
            Genel.ent.MusteriHareketler.Remove(mh);
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

        public List<MusteriHareket> MusteriHareketSorgula(int MusteriId, DateTime baslangic, DateTime bitis)
        {
            DateTime b = Convert.ToDateTime(baslangic.ToShortDateString());
            
            return Genel.ent.MusteriHareketler.Where(m => m.Silindi == false && m.MusteriId==MusteriId && m.Tarih >=b && m.Tarih <=bitis ).ToList();
        }
    }
}
