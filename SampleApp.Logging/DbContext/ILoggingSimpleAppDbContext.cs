using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Logging.DbContext
{
    public interface ILoggingSimpleAppDbContext
    {
        DbSet<BaseProgramLog> BaseProgramLogs { get; set; }
    }
}
