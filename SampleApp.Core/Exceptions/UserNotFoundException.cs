using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Exceptions
{
    public class UserNotFoundException : BaseNotFoundException
    {
        public override string Key => "User Not Found";
        public UserNotFoundException(int id) : base(id)
        {

        }
    }
}
