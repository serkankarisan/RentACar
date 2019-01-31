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
    [Table("Personeller")]
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Adi { get; set; }
        [Required]
        public string Soyadi { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public decimal Maas { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        public virtual List<Sozlesme> Sozlesmeler { get; set; }
        public virtual List<Kullanici> Kullanicilar { get; set; }
        public override string ToString()
        {
            return Adi+" "+Soyadi;
        }
        public Personel()
        {
            Silindi = false;
            Maas = 0;
        }
    }
}
