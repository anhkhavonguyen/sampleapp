namespace SampleApp.Core.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SampleApp.Core.Models;
    using System.Data.Entity.ModelConfiguration;

    public partial class SimpleAppContext : DbContext, ISimpleAppDbContext
    {
        public SimpleAppContext()
            : base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<BaseProgramLog> BaseProgramLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Setup(modelBuilder.Entity<User>());
            Setup(modelBuilder.Entity<BaseProgramLog>());
        }

        private void Setup(EntityTypeConfiguration<BaseProgramLog> entityTypeConfiguration)
        {
            entityTypeConfiguration
                .ToTable("BaseProgramLog")
                .HasKey(x => x.Id);
        }

        private void Setup(EntityTypeConfiguration<User> entityTypeConfiguration)
        {
            entityTypeConfiguration
                .ToTable("User")
                .HasKey(x => x.Id);

            entityTypeConfiguration
                .Property(e => e.FirstName)
                .IsFixedLength();

            entityTypeConfiguration
                .Property(e => e.LastName)
                .IsFixedLength();
        }
    }
}
