using BilgeTurizm.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİlgeTurizm.DAL
{
   public class SehirlerMapping : EntityTypeConfiguration<Sehirler>
    {

        public SehirlerMapping()
        {
            ToTable("Sehirler");
            Property(x => x.Sehir).HasColumnType("nvarchar").HasMaxLength(20);
            HasKey(x => x.SehirID);
        }
    }
}
