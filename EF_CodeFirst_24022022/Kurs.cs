using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_24022022
{
    public class Kurs
    {
        [Key]
        public int Kursid { get; set; }
        public string Kursadi { get; set; }
        public string KusrSaati { get; set; }
    }
}
