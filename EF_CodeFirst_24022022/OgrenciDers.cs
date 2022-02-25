using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_24022022
{
    public class OgrenciDers
    {
        [Key,Column(Order = 0)]
        public int Ogrenciid { get; set; }

        [Key,Column(Order = 1)]
        public int Dersid { get; set; }
    }
}
