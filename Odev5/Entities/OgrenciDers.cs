using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Entities
{
    public class OgrenciDers
    {
        public int Id { get; set; }

        public int ogrenciID { get; set; }
        public int dersID { get; set; }
        public int yil { get; set; }
        public int yariyil { get; set; }
        public int vize { get; set; }
        public int final { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }
    }
}
