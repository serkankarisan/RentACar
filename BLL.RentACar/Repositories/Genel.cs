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
        public static int gecicimusteriId;
        public static int MusteriID;
        public static int PersonelID;
        public static int AracID;
        public static Sozlesme soz;
        public static int SozID;
        public static int MusteriId;
        public static string cbIslem;
        public static ImageList ResimListesi;
    }
}
