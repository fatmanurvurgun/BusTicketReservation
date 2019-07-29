using BilgeTurizm.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİlgeTurizm.DAL
{
   public class Context :DbContext
    {
        public Context() : base(@"server = EMRE\SQLEXPRESS; database = BilgeTurizm; uid = sa; pwd = 123")
        {

        }


        public DbSet<Musteriler> MusterilerTablo { get; set; }
        public DbSet<Bilet> BiletTablo { get; set; }
        public DbSet<SeferBilgileri> SeferBilgiTablo { get; set; }
        public DbSet<Sehirler> Sehirler { get; set; }
        public DbSet<Yemekler> Yemekler { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MusterilerMapping());
            modelBuilder.Configurations.Add(new BiletMapping());
            modelBuilder.Configurations.Add(new SeferBilgileriMapping());
            modelBuilder.Configurations.Add(new SehirlerMapping());
            modelBuilder.Configurations.Add(new YemekMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();





            base.OnModelCreating(modelBuilder);
        }
    }
  }

