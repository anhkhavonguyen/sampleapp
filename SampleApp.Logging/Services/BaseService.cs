using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Logging.Messages;
using SampleApp.Logging.DbContext;

namespace SampleApp.Logging.Services
{
    public abstract class BaseService : ILoggingService
    {
        private LoggingSimpleAppDbContext _loggingSimpleAppDbContext = null;

        public BaseService()
        {
            _loggingSimpleAppDbContext = new LoggingSimpleAppDbContext();
        }

        public void LogError(LogErrorRequest request)
        {
            var baseProgramLog = new BaseProgramLog();
            baseProgramLog.Type = request.Type;
            baseProgramLog.Message = request.ErrorMessage;
            _loggingSimpleAppDbContext.BaseProgramLogs.Add(baseProgramLog);
            _loggingSimpleAppDbContext.SaveChanges();
        }
    }
}
