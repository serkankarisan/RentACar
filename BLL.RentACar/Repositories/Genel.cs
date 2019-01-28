using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.RentACar.Repositories
{
    public class Genel
    {
        public static RentContext ent = new RentContext();
        public static string UserName;
        public static string Yetki;
        public static string MusteriAdi;
        public static string MusteriSoyadi;
        public static string MusteriTCKNo;
        public static string MusteriTelefon;
        public static string MusteriEmail;
        public static string MusteriAdres;
        public static string MusteriCinsiyet;
        public static string MusteriEhliyetNo;
        public static string PersonelAdi;
        public static string PersonelSoyadi;
        public static int MusteriID;
        public static int PersonelID;


    }
}
