namespace SampleApp.Core.DbContext
{
    using SampleApp.Core.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;

    public partial class SimpleAppContext : DbContext, ISimpleAppDbContext
    {
        public SimpleAppContext()
            : base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Setup(modelBuilder.Entity<User>());
            Setup(modelBuilder.Entity<Article>());
            Setup(modelBuilder.Entity<Category>());
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

        private void Setup(EntityTypeConfiguration<Article> entityTypeConfiguration)
        {
            entityTypeConfiguration
                .ToTable("Article")
                .HasKey(x => x.Id);
        }

        private void Setup(EntityTypeConfiguration<Category> entityTypeConfiguration)
        {
            entityTypeConfiguration
                .ToTable("Category")
                .HasKey(x => x.Id);
        }
    }
}
