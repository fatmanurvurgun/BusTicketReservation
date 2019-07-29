using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgeTurizm.DATA;

namespace BilgeTurizmUI
{
    public class Yolcu : Musteriler
    {
        public int koltukNo { get; set; }

        public bool vipMi { get; set; }

        public int yemekID { get; set; }

        public bool YetiskinMi { get; set; }

    }
}
