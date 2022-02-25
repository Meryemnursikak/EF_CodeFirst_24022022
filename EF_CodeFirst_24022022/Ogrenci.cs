using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_24022022
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        [Key]  //ogrid nin primary key olması için üstüne key yazdık
        public int Ogrid { get; set; }

        [StringLength(20),Required] // girilen isimi nvarchara dönüşür ve required not null anlamına gelir
        public string Isim { get; set; }


        [StringLength(20),Required]
        public string Soyisim { get; set; }
        public string Okulno { get; set; }
        public string Tcno { get; set; }
        public List<Ders> Ders { get; set; }
        public Veli Veli { get; set; }

    }
}
