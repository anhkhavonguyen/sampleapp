using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Logging.Messages
{
    public class LogErrorRequest
    {
        public string ErrorMessage { get; set; }
        public TypeProgramLog Type { get; set; }
    }
}
