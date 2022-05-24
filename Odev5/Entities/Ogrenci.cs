using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Entities
{
    public class Ogrenci
    {
        public int ogrenciID { get; set; }
        public string ogrenciAd { get; set; }
        public string ogrenciSoyad { get; set; }

        public int bolumID { get; set; }

        public Bolum Bolum { get; set; }

        public List<OgrenciDers> OgrenciDerss { get; set; }
       
        public override string ToString()
        {
            return ogrenciAd;
        }

    }
}
