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

        #region Role
        public static string UserName;
        public static string Yetki;
        #endregion

        #region Müşteri
        public static int MusteriID;
        public static string MusteriAdi;
        public static string MusteriSoyadi;
        public static string MusteriTCKNo;
        public static string MusteriTelefon;
        public static string MusteriEmail;
        public static string MusteriAdres;
        public static string MusteriCinsiyet;
        public static string MusteriEhliyetNo;
        #endregion

        #region Personel
        public static string PersonelAdi;
        public static string PersonelSoyadi;
        public static int PersonelID;
        #endregion

        #region Arac

        public static int AracID;
        public static string AracModel;
        public static string AracMarka;
        public static string AracRenk;
        public static string AracPlaka;
        public static string AracGunlukFiyat;
        public static string AracTip;
        public static string AracVarmi;
        public static string AracDurumu;
        public static string AracYakitDurumu;

        #endregion

    }
}
