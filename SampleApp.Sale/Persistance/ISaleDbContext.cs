using MongoDB.Driver;
using SampleApp.Sale.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Sale.Persistance
{
    public interface ISaleDbContext
    {
        IMongoCollection<Product> ProductCollection { get; }
    }
}
