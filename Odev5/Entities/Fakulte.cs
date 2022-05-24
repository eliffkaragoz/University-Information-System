using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Entities
{
    public class Fakulte
    {

        public Fakulte()
        {
            Bolums = new List<Bolum>();
        }
        public int fakulteID { get; set; }
        public string fakulteAd { get; set; }
        public List<Bolum> Bolums { get; set; }

    }
}
