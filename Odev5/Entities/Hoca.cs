using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Entities
{
    public  class Hoca
    {
        public int Id { get; set; }

        public string ad { get; set; }
        public string soyad { get; set; }
 
        public List<Ders> Derss { get; set; }

    }
}
