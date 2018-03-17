using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.DbContext
{
    public interface ISimpleAppDbContext
    {
        DbSet<User> Users { get; set; }
    }
}
