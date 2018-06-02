using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product> {
        IQueryable<Product> GetAllBreweries();
        IQueryable<BeerTypeBeer> GetAllBeers();
        IQueryable<BeerTypeBeer> GetBeerById();
        IQueryable<Product> GetBreweryById();
        IQueryable<BeerTypeBeer> GetAllBeersByBeerType(string beedType);
    }
}
