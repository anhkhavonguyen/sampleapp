using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Exceptions
{
    public abstract class BaseNotFoundException : BaseException
    {
        public BaseNotFoundException(int? id) : base(new string[] { id?.ToString() })
        {

        }
    }
}
