using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Odev5.Entities;

namespace Odev5
{
    public class Context : DbContext
    {
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Fakulte> Fakultes { get; set; }
        public DbSet<Bolum> Bolums { get; set; }

        public DbSet<OgrenciDers> OgrenciDerss { get; set; }
        public DbSet<Ders> Derss { get; set; }
        public DbSet<Hoca> Hocas { get; set; }




    }
}
