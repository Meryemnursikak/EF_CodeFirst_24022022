using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_24022022
{
    public class Veli
    {
        [Key]
        public int Veliid { get; set; }

        [StringLength(20),Required]
        public string isim { get; set; }

        [StringLength(20),Required]
        public string Soyisim { get; set; }

        [StringLength(11)]
        public string Telno { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        public List<Ogrenci> Ogrenci { get; set; }

    }
}
