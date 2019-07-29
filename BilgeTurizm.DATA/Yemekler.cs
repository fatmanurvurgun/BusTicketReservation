using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTurizm.DATA
{
    public class Yemekler

    {
        public int YemekID { get; set; }

        public string MenuAdi { get; set; }

        public string Description { get; set; }


        public virtual List<Bilet> YemekBiletBilgisi { get; set; }
    }
}
