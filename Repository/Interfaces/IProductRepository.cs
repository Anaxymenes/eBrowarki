using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product> {
        IQueryable<Product> GetAllBreweries();
        IQueryable<Product> GetAllBeers();
        IQueryable<Product> GetBeerById();
        IQueryable<Product> GetBreweryById();
        IQueryable<Product> GetAllBeersByBeerType(string beedType);
    }
}
