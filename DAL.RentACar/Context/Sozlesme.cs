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
    [Table("Sozlesmeler")]
    public class Sozlesme
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public string MusteriAdiSoyadi { get; set; }
        [NotMapped]
        public string PersonelAdiSoyadi { get; set; }
        public int PersonelId { get; set; }
        public int MusteriId { get; set; }
        [Required]
        public DateTime SozlesmeTarihi { get; set; }
        [Required]
        public decimal SozlesmeTutari { get; set; }
        public int AracSayisi { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations

        [ForeignKey("PersonelId")]
        public virtual Personel Personel { get; set; }
        [ForeignKey("MusteriId")]
        public virtual Musteri Musteri { get; set; }

        public virtual List<SozlesmeDetay> SozlesmeDetaylar { get; set; }

    }
}
