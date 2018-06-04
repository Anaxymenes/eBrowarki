using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product> {
        IQueryable<Product> GetAllBreweries(int page, int itemsOnPage);
        IQueryable<Product> GetAllBeers(int page, int itemsOnPage);
        IQueryable<Product> GetBeerById(int id);
        IQueryable<Product> GetBreweryById(int id);
        IQueryable<Product> GetAllBeersByBeerType(string beerType);
        IQueryable<Product> GetAllBeersWithNotApproved();
        IQueryable<Product> GetAllBreweriesWithNotApproved();
    }
}
