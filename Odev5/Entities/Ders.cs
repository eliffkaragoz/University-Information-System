using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Entities
{
    public class Ders
    {
        public int Id { get; set; }

        public string dersAd { get; set; }
        public Hoca Hoca { get; set; }
        public List<OgrenciDers> OgrenciDerss { get; set; }

        public override string ToString()
        {
            return dersAd;
        }

    }
}
