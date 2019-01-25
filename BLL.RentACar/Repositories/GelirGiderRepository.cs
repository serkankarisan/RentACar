using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class GelirGiderRepository : IGelirGiderRepository
    {
        public bool GelirGiderEkle(GelirGider gg)
        {
            bool Sonuc = false;
            Genel.ent.GelirGider.Add(gg);
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

        public GelirGider GelirGiderGetirById(int ID)
        {
            GelirGider gelirgider = (from gg in Genel.ent.GelirGider
                               where gg.Id == ID
                               select gg).FirstOrDefault();

            return gelirgider;
        }

        public bool GelirGiderGuncelle(GelirGider gg)
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

        public List<GelirGider> GelirGiderLİstele()
        {
            return Genel.ent.GelirGider.Where(m => m.Silindi == false).ToList();
        }

        public bool GelirGiderSil(int ID)
        {
            bool Sonuc = false;
            GelirGider silinen = (from gg in Genel.ent.GelirGider
                               where gg.Id == ID
                               select gg).FirstOrDefault();
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

        public bool GelirGiderSil(GelirGider gg)
        {
            bool Sonuc = false;
            Genel.ent.GelirGider.Remove(gg);
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
