using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class SozlesmeDetayRepository : ISozlesmeDetayRepository
    {
        public bool SozlesmeDetayEkle(SozlesmeDetay s)
        {
            bool Sonuc = false;

            Genel.ent.SozlesmeDetaylar.Add(s);
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

        public List<SozlesmeDetay> SozlesmeDetayGetirBySozlesmeId(int ID)
        {
            List<SozlesmeDetay> bulunan = (from sd in Genel.ent.SozlesmeDetaylar
                            where sd.Id == ID
                            select sd).ToList();

            return bulunan;
        }

        public bool SozlesmeDetayGuncelle(SozlesmeDetay s)
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

        public List<SozlesmeDetay> SozlesmeDetayListele()
        {
            return Genel.ent.SozlesmeDetaylar.ToList();
        }

        public List<SozlesmeDetay> SozlesmeDetayListeleByAranan(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
           Musteri Musteri = (from m in Genel.ent.Musteriler
                            where m.Adi.Substring(0,1).Substring(1)==Ad && m.Soyadi==Soyad && m.TcKimlikNo==TCKNo && m.EhliyetNo==EhliyetNo
                            select m).FirstOrDefault();
            Sozlesme Sozlesme = (from s in Genel.ent.Sozlesmeler
                                       where s.MusteriId == Musteri.Id
                                       select s).FirstOrDefault();
            List<SozlesmeDetay> SozlesmeDetay = (from soz in Genel.ent.SozlesmeDetaylar
                                 where soz.SozlesmeId == Sozlesme.Id
                                 select soz).ToList();

            return SozlesmeDetay;
        }

        public List<SozlesmeDetay> SozlesmeDetayListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            List<SozlesmeDetay> SozlesmeDetay = (from s in Genel.ent.SozlesmeDetaylar
                               where s.BaslangicTarihi==baslangic && s.BitisTarihi==bitis
                               select s).ToList();

            return SozlesmeDetay;
        }

        public bool SozlesmeDetaySil(int ID)
        {
            bool Sonuc = false;
            SozlesmeDetay silinen = (from a in Genel.ent.SozlesmeDetaylar
                            where a.Id == ID
                            select a).FirstOrDefault();
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

        public bool SozlesmeDetaySil(SozlesmeDetay s)
        {
            bool Sonuc = false;
            Genel.ent.SozlesmeDetaylar.Remove(s);
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
