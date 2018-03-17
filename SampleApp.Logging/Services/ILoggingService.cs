using SampleApp.Logging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Logging.Services
{
    public interface ILoggingService
    {
        void LogError(LogErrorRequest request);
    }
}
