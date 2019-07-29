using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTurizm.DATA
{
   public class Bilet
    {
        public int ID { get; set; }

        public int SeferBilgileriID { get; set; }
        public int MusteriID { get; set; }

        public short KoltukNo { get; set; }

        public bool RezerveMi { get; set; }

        public bool YetiskinMi { get; set; }

        public DateTime KalkisTarihi { get; set; }

        public DateTime VarisTarihi { get; set; }

        public int YemekID { get; set; }

        public string PnrKodu { get; set; }

        public bool SigortaliMi { get; set; }

        public decimal ToplamFiyat { get; set; }


        public virtual Musteriler Musteri { get; set; }

        public virtual SeferBilgileri SeferBiletBilgisi { get; set; }

        public virtual Yemekler BiletYemekBilgisi { get; set; }





    }
}
