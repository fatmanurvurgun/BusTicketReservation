using BilgeTurizm.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİlgeTurizm.DAL
{
   public class BiletMapping : EntityTypeConfiguration<Bilet>
    {
        public BiletMapping()
        {
            ToTable("Bilet");
            Property(x => x.RezerveMi).IsRequired();
            Property(x => x.YetiskinMi);
            Property(x => x.SigortaliMi).IsOptional();
            Property(x => x.PnrKodu).HasColumnType("nvarchar");
            Property(x => x.KoltukNo).IsRequired().HasColumnType("smallint");
            Property(x => x.KalkisTarihi).HasColumnType("datetime2").IsRequired();
            Property(x => x.VarisTarihi).HasColumnType("datetime2").IsRequired();
            Property(x => x.ToplamFiyat);


            HasRequired(x => x.SeferBiletBilgisi).WithMany(x => x.BiletSeferBilgisi).HasForeignKey(x => x.SeferBilgileriID);
            HasRequired(x => x.BiletYemekBilgisi).WithMany(x => x.YemekBiletBilgisi).HasForeignKey(x => x.YemekID);
            HasRequired(x => x.Musteri).WithMany(x => x.MusterininBileti).HasForeignKey(x => x.MusteriID);



        } 




    }
}
