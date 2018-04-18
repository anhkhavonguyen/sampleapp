namespace SampleApp.Logging.DbContext
{
    using System.Data.Entity;

    public interface ILoggingSimpleAppDbContext
    {
        DbSet<BaseProgramLog> BaseProgramLogs { get; set; }
    }
}
