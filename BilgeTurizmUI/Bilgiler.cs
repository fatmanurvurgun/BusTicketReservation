using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgeTurizm.DATA;

namespace BilgeTurizmUI
{
    public static class Bilgiler
    {
        // Burada yolcuların ve program içerisindeki sabit değerler tutulacak

        public static DateTime GidisTarihi { get; set; }

        public static DateTime DonusTarihi { get; set; }

        public static string GidisSaati { get; set; }

        public static string DonusSaati { get; set; }

        public static int NeredenSehir { get; set; }

        public static int NereyeSehir { get; set; }

        public static OtobusTipi GidisOtobusTipi { get; set; }

        public static OtobusTipi DonusOtobusTipi { get; set; }

        public static Dictionary<int, string> GidisSecilenKoltuklar { get; set; }

        public static Dictionary<int, string>  DonusSecilenKoltuklar { get; set; }

        public static int GidisSeferID { get; set; }

        public static int  DonusSeferID { get; set; }

        public static List<Yolcu> GidisMusteriler;

        public static List<Yolcu> DonusMusteriler;

        public static bool RezerveMi { get; set; }

        public static SeyehatTipi SeyahatTipi { get; set; }

        public static decimal ToplamFiyat { get; set; }

        public static bool SigortaVarMi { get; set; }

        public static string PNRKodu { get; set; }

        public static decimal GidisToplamFiyat { get; set; }

        public static decimal DonusToplamFiyat { get; set; }

    }

    public enum OtobusTipi
    {
        Standart,
        Suit
    }


    public enum SeyehatTipi
    {
        GidisDonus,
        TekYon
    }
}


