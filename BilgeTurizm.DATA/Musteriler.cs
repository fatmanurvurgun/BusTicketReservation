using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTurizm.DATA
{
    public class Musteriler
    {
        public int MusteriID { get; set; }

        public string Ad { get; set; }

        public string SoyAd { get; set; }

        public string Telefon { get; set; }

        public string TcNo { get; set; }

        public bool Cinsiyet { get; set; }

        public string EMail { get; set; }

        public string Adres { get; set; }

        public virtual List<Bilet> MusterininBileti { get; set; }


    }
}
