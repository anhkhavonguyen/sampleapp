namespace SampleApp.Core.DbContext
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;

    public partial class SimpleAppContext : DbContext, ISimpleAppDbContext
    {
        public SimpleAppContext()
            : base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Setup(modelBuilder.Entity<User>());
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
