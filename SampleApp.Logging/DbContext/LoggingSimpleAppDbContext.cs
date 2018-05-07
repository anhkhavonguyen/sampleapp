namespace SampleApp.Logging.DbContext
{
    public class LoggingSimpleAppDbContext : System.Data.Entity.DbContext, ILoggingSimpleAppDbContext
    {
        public virtual System.Data.Entity.DbSet<BaseProgramLog> BaseProgramLogs { get; set; }

        public LoggingSimpleAppDbContext():
            base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
                
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Setup(modelBuilder.Entity<BaseProgramLog>());
        }

        private void Setup(System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BaseProgramLog> entityTypeConfiguration)
        {
            entityTypeConfiguration
                .ToTable("BaseProgramLog")
                .HasKey(x => x.Id);
        }
    }
}
