using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class SozlesmeRepository : ISozlesmeRepository
    {
        public bool SozlesmeEkle(Sozlesme s)
        {
            bool Sonuc = false;
            Genel.ent.Sozlesmeler.Add(s);
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

        public Sozlesme SozlesmeGetirById(int ID)
        {
            Sozlesme sozlesme = (from s in Genel.ent.Sozlesmeler
                               where s.Id == ID
                               select s).FirstOrDefault();

            return sozlesme;
        }

        public bool SozlesmeGuncelle(Sozlesme s)
        {
            bool Sonuc = false;
            Sozlesme degisen = SozlesmeGetirById(s.Id);
            degisen.AracSayisi = s.AracSayisi;
            degisen.SozlesmeTutari = s.SozlesmeTutari;
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

        public bool SozlesmeKontrol(Sozlesme yeni)
        {
            return Convert.ToBoolean(Genel.ent.Sozlesmeler.Where(s => s.SozlesmeTarihi == yeni.SozlesmeTarihi && s.MusteriId==yeni.MusteriId && s.PersonelId == yeni.PersonelId).ToList().Count);
        }
        public int SozlesmeIdBul(Sozlesme yeni)
        {
            Sozlesme soz = Genel.ent.Sozlesmeler.Where(s => s.SozlesmeTarihi == yeni.SozlesmeTarihi && s.MusteriId == yeni.MusteriId && s.PersonelId == yeni.PersonelId).FirstOrDefault();
            return soz.Id;
        }

        public List<Sozlesme> SozlesmeListele()
        {
            return Genel.ent.Sozlesmeler.Where(s => s.Silindi == false).ToList();
        }

        public List<Sozlesme> SozlesmeListeleByMusteriId(int ID)
        {
            return Genel.ent.Sozlesmeler.Where(s => s.MusteriId == ID).ToList();
        }

        public List<Sozlesme> SozlesmeListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            return Genel.ent.Sozlesmeler.Where(s => s.Silindi == false && s.SozlesmeTarihi >= baslangic && s.SozlesmeTarihi <= bitis).ToList();
        }

        public bool SozlesmeSil(int ID)
        {
            bool Sonuc = false;
            Sozlesme silinen = (from s in Genel.ent.Sozlesmeler
                               where s.Id == ID
                               select s).FirstOrDefault();
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

        public bool SozlesmeSil(Sozlesme s)
        {
            bool Sonuc = false;
            Genel.ent.Sozlesmeler.Remove(s);
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

        public List<Sozlesme> SozlesmeSorgula(int SozlesmeId, string TckNo, string EhliyetNo)
        {
            return Genel.ent.Sozlesmeler.Where(k => k.Silindi == false && k.Id.ToString().StartsWith(SozlesmeId.ToString()) && k.Musteri.TcKimlikNo.StartsWith(TckNo) && k.Musteri.EhliyetNo.StartsWith(EhliyetNo)).ToList();
        }
        public List<Sozlesme> SozlesmeSorgula(string TckNo, string EhliyetNo)
        {
            return Genel.ent.Sozlesmeler.Where(k => k.Silindi == false && k.Musteri.TcKimlikNo.StartsWith(TckNo) && k.Musteri.EhliyetNo.StartsWith(EhliyetNo)).ToList();
        }
    }
}
