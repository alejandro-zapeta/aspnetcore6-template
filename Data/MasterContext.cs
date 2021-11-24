using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Master.Data {

    public partial class MasterContext : DbContext {

        public MasterContext(DbContextOptions<MasterContext> options) : base(options) {

        }

        public virtual DbSet<Master.Data.Entities.Countries> Countries { get; set; }
        //public virtual DbSet<Master.Data.Entities.Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.CountriesMap());
           //modelBuilder.ApplyConfiguration(new Master.Data.Mapping.UsersMap());
        }
    }
}
