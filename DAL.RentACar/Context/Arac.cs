using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RentACar.Context
{
    [Table("Araclar")]
    public class Arac
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public decimal GünlükFiyat { get; set; }
        [Required]
        public string Tip { get; set; }
        [Required]
        public string Renk { get; set; }
        [Required]
        public string Plaka { get; set; }
        [Required]
        public string AracDurumu { get; set; }
        [Required]
        public string YakitDurumu { get; set; }
        [DefaultValue(true)]
        public bool Varmi { get; set; }
        [Required]
        public string ResimYolu { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        public virtual List<SozlesmeDetay> SozlesmeDetaylar { get; set; }

        public Arac()
        {
            Silindi = false;
            Varmi = true;
            YakitDurumu = "%100";
            AracDurumu = "Hasarsız";
            GünlükFiyat = 0;
        }
        public override string ToString()
        {
            return Marka+" - "+Model;
        }
    }
}
