using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_24022022
{
    public class Ogretmen
    {
        [Key] //ogrtid key olarak belirledik(attribute)
        public int Ogrtid { get; set; }

        [StringLength(20), Required]
        public string Isim { get; set; }

        [StringLength(20), Required]
        public string Soyisim { get; set; }
        public string Tcno { get; set; }
        public Ders Ders { get; set; }
    }
}
