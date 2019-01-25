using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IMusteriRepository
    {
        bool MusteriKontrol(Musteri yeni);
        List<Musteri> MusteriListele();
        List<Musteri> MusteriSorgula(string Ad,string Soyad,string TCKNo,string EhliyetNo);

        Musteri MusteriGetirById(int ID);

        bool MusteriEkle(Musteri M);
        bool MusteriGuncelle(Musteri M);

        bool MusteriSil(int ID);
        bool MusteriSil(Musteri M);
    }
}
