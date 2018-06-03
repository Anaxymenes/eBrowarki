using Data.DBModels;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class ProductRepository : IProductRepository {

        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context) {
            _context = context;
        }

        public Product Add(Product entity) {
            try {
                _context.Add(entity);
                _context.SaveChanges();
                return _context.Product.Last();
            }catch(Exception e) {
                throw e;
            }
        }

        public IQueryable<Product> GetAll() {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllBeers(int page, int itemsOnPage) {
            return _context.Product.Where(x => x.Approved == true && x.IsBeer == true)
                .Include(beer => beer.Beer)
                    .ThenInclude(x => x.Brewery)
                        .ThenInclude(x => x.Product)
                .Include(x => x.Country)
                .Include(x => x.Comments)
                    .ThenInclude(x => x.Account)
                .Include(x => x.Votes)
                .Skip((page - 1) * itemsOnPage)
                .Take(itemsOnPage);
                
        }

        public IQueryable<Product> GetAllBeersByBeerType(string beerType) {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllBreweries(int page, int itemsOnPage) {
            return _context.Product.Where(x => x.Approved == true && x.IsBeer == false)
                        .Include(x => x.Brewery)
                        .Include(x => x.Country)
                        .Include(x => x.Comments)
                            .ThenInclude(x => x.Account)
                        .Include(x => x.Votes)
                        .Skip((page - 1) * itemsOnPage)
                        .Take(itemsOnPage);
                        
        }

        public IQueryable<Product> GetBeerById(int id) {
            return _context.Product.Where(x=>x.Id == id)
                .Include(beer => beer.Beer)
                    .ThenInclude(x => x.Brewery)
                        .ThenInclude(x => x.Product)
                .Include(x => x.Country)
                .Include(x => x.Comments)
                    .ThenInclude(x => x.Account)
                .Include(x => x.Votes);
        }

        public IQueryable<Product> GetBreweryById(int id) {
            return _context.Product.Where(x => x.Id==id)
                        .Include(x => x.Brewery)
                        .Include(x => x.Country)
                        .Include(x => x.Comments)
                            .ThenInclude(x => x.Account)
                        .Include(x => x.Votes);
        }
    }
}
