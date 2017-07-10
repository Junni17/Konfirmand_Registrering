using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Konf_ADM.Models
{
    public class Konfirmandhold
    {
        public int ID { get; set; }
      
        public string School { get; set; }
        public string Class { get; set; }

        public string Year { get; set; }

        //public ICollection<Konfirmand> TilsluttedeKonfirmander { get; set; }
    }
}
