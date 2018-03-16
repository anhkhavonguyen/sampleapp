using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Messages
{
    public class AddUserRequest : BaseRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
