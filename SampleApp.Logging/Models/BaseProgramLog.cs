using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Logging
{
    public class BaseProgramLog
    {
        public int Id { get; set; }
        public TypeProgramLog Type { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }
    }

    public enum TypeProgramLog
    {
        Client,
        Server
    }
}
