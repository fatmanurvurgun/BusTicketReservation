using BilgeTurizm.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİlgeTurizm.DAL
{
    public class MusterilerMapping :EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMapping()
        {
            ToTable("Musteriler");
            Property(x => x.Ad).IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            Property(x => x.SoyAd).IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            Property(x => x.Telefon).IsRequired().HasColumnType("nchar").HasMaxLength(11);
            Property(x => x.Adres).HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.TcNo).IsRequired().HasColumnType("nchar").HasMaxLength(11);
            Property(x => x.Cinsiyet).IsRequired();
            Property(x => x.EMail).HasColumnType("nchar").HasMaxLength(50);

            HasKey(x => x.MusteriID);
            

        }
    }
}
