using MongoDB.Driver;
using SampleApp.Sale.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Sale.Persistance
{
    public class SaleDbContext : ISaleDbContext
    {
        //Create C:\data\db
        //"C:\Program Files\MongoDB\Server\3.4\bin\mongod.exe" --dbpath "C:\data\db"

        private readonly IMongoDatabase _mongoDatabase;

        public SaleDbContext()
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            _mongoDatabase = client.GetDatabase("SampleAppSaleDb");
        }

        public IMongoCollection<Product> ProductCollection => _mongoDatabase.GetCollection<Product>(nameof(Product));
        public IQueryable<Product> Products => ProductCollection.AsQueryable();
    }
}
