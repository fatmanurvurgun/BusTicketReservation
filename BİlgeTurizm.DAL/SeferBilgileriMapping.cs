using BilgeTurizm.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİlgeTurizm.DAL
{
   public class SeferBilgileriMapping : EntityTypeConfiguration<SeferBilgileri>
    {
        public SeferBilgileriMapping()
        {
            ToTable("SeferBilgileri");
            
            Property(x => x.Ucret).HasColumnType("money").IsRequired();
            Property(x => x.OtobusTipi).HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.KalkisSaati).HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.VarisSaati).HasColumnType("nvarchar").IsRequired().HasMaxLength(20);

            
            HasRequired(x => x.NeredenSehirBilgisi).WithMany(x => x.NeredenBilgi).HasForeignKey(x => x.Nereden).WillCascadeOnDelete(false);
            HasRequired(x => x.NereyeSehirBilgisi).WithMany(x => x.NereyeBilgi).HasForeignKey(x => x.Nereye).WillCascadeOnDelete(false);


        }
    }
}
