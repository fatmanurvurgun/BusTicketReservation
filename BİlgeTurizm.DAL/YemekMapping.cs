using BilgeTurizm.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİlgeTurizm.DAL
{
    public class YemekMapping : EntityTypeConfiguration<Yemekler>
    {
        public YemekMapping()
        {
            ToTable("Yemekler");

            HasKey(x => x.YemekID);
            Property(x => x.MenuAdi);
            Property(x => x.Description);
            


        }
    }
}
