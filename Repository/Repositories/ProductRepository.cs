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
            return _context.Product.Where(x=>x.Approved == true)
                .Include(beer => beer.Beer)
                .ThenInclude(x => x.Brewery)
                .Include(x => x.Country)
                .Include(x => x.Comments)
                .ThenInclude(x => x.Account)
                .Include(x => x.Votes);
        }

        public IQueryable<Product> GetAllBeers() {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllBeersByBeerType(string beedType) {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllBreweries() {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetBeerById() {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetBeerById(int id) {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetBreweryById() {
            throw new NotImplementedException();
        }
    }
}
