using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTurizm.DATA
{
     public class SeferBilgileri
    {
        public int ID { get; set; }

        public int Nereden { get; set; }

        public int Nereye { get; set; }


        public string KalkisSaati { get; set; }

        public string VarisSaati { get; set; }

        public string OtobusTipi { get; set; }

        public decimal Ucret { get; set; }

        public virtual List<Bilet> BiletSeferBilgisi { get; set; }

        public virtual Sehirler NeredenSehirBilgisi { get; set; }

        public virtual Sehirler NereyeSehirBilgisi { get; set; }

    }
}
