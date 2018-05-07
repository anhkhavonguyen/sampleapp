namespace SampleApp.Logging.DbContext
{
    public interface ILoggingSimpleAppDbContext
    {
        System.Data.Entity.DbSet<BaseProgramLog> BaseProgramLogs { get; set; }
    }
}
