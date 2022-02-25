using System;
using System.Data.Entity;
using System.Linq;

namespace EF_CodeFirst_24022022
{
    public class OkulDatabase : DbContext
    {
     
        public OkulDatabase() : base("name=OkulDatabase")
        {
        }

      
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Ogretmen> Ogretmenler { get; set; }
        public virtual DbSet<Ders> Dersler { get; set; }
        public virtual DbSet<Veli> Veliler { get; set; }
        public virtual DbSet<Kurs> Kurs { get; set; }

    }


}