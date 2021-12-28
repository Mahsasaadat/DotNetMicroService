using Catalog.Api.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.DataAccessLayer
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
