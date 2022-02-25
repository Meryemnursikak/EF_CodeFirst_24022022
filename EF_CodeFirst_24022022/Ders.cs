using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_24022022
{
    public class Ders
    {
        [Key]
        public int Dersid { get; set; }
        public string DersName { get; set; }
        public byte DersSaati { get; set; }
        public List<Ogretmen> Ogretmen { get; set; }
        public List<Ogrenci> Ogrenci { get; set; }
    }
}
