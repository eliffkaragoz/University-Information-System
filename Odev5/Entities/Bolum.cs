using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Entities
{
    public class Bolum
    {
        public int bolumID { get; set; }

        public string bolumAd { get; set; }
        public int fakulteID { get; set; }
        public Fakulte Fakulte { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
        public Bolum()
        {
            Ogrencis = new List<Ogrenci>();
        }

        public override string ToString()
        {
            return bolumAd;
        }
    }
}
