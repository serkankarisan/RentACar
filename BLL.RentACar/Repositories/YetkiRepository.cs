using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class YetkiRepository : IYetkiRepository
    {
        public bool YetkiEkle(Yetki y)
        {
            bool Sonuc = false;

            Genel.ent.Yetkiler.Add(y);
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

        public Yetki YetkiGetirById(int ID)
        {
            Yetki bulunan = (from a in Genel.ent.Yetkiler
                            where a.Id == ID
                            select a).FirstOrDefault();

            return bulunan;
        }

        public List<Yetki> YetkiListele()
        {
            return Genel.ent.Yetkiler.ToList();
        }

        public bool YetkiSil(int ID)
        {
            bool Sonuc = false;
            Yetki silinen = (from a in Genel.ent.Yetkiler
                            where a.Id == ID
                            select a).FirstOrDefault();
            Genel.ent.Yetkiler.Remove(silinen);

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

        public bool YetkiSil(Yetki y)
        {
            bool Sonuc = false;

            Genel.ent.Yetkiler.Remove(y);
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
