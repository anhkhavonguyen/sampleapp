using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Exceptions
{
    public abstract class BaseException : Exception
    {
        public abstract string Key { get; }
        public virtual string[] Values { get; set; }

        protected BaseException()
        {

        }

        protected BaseException(string[] value)
        {

        }

        protected BaseException(string message, string[] values) : base(message)
        {

        }

        protected BaseException(string message) : base(message)
        {

        }
    }
}
