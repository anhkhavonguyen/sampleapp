using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Models
{
    public class BaseProgramLog
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }
    }
}
