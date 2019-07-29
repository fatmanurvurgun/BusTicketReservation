using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTurizm.DATA
{
    public class Sehirler
    {
        public int SehirID { get; set; }

        public string Sehir { get; set; }


        public virtual List<SeferBilgileri> NeredenBilgi { get; set; }

        public virtual List<SeferBilgileri> NereyeBilgi { get; set; }


    }
}
