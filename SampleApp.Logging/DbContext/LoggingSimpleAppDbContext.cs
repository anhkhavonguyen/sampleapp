namespace SampleApp.Logging.DbContext
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;

    public class LoggingSimpleAppDbContext : DbContext, ILoggingSimpleAppDbContext
    {
        public virtual DbSet<BaseProgramLog> BaseProgramLogs { get; set; }

        public LoggingSimpleAppDbContext():
            base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Setup(modelBuilder.Entity<BaseProgramLog>());
        }

        private void Setup(EntityTypeConfiguration<BaseProgramLog> entityTypeConfiguration)
        {
            entityTypeConfiguration
                .ToTable("BaseProgramLog")
                .HasKey(x => x.Id);
        }
    }
}
