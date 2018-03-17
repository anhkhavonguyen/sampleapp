using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Exceptions
{
    public class UnhandleException : BaseException
    {
        public override string Key => "Unhandle Exception";

        public UnhandleException(string message) : base(message)
        {

        }
    }
}
