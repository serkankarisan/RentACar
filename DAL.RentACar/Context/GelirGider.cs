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
    [Table("GelirGider")]
    public class GelirGider
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Aciklama { get; set; }
        [Required]
        public string Tür { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }
        public virtual List<KasaHareket> KasaHareketler { get; set; }
    }
}
