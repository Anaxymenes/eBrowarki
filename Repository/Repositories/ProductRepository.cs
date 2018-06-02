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

        public IQueryable<BeerTypeBeer> GetAllBeers() {
            throw new NotImplementedException();
        }

        public IQueryable<BeerTypeBeer> GetAllBeersByBeerType(string beedType) {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllBreweries() {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetBeerById(int id) {
            //if (!_context.Product.Any(x => x.Id == id))
            //    return null;
            //if (_context.Product.First(x => x.Id == id).IsBeer == true)
            //    return _context.Product
            //        .Include(comment => comment.Comments)
            //        .ThenInclude(author => author.Account)
            //        .Include(country => country.Country)
            //        .Include(account => account.Account)
            //        .Include(votes => votes.Votes)
            //        .Where(x => x.Id == id)
            //        .Include(beer => beer.Beer)
            //            .ThenInclude(brewery => brewery.Brewery)
            //            .ThenInclude(product => product.Product)
            //        .Include(beer => beer.Beer)
            //            .ThenInclude(beerType => beerType.BeerTypeBeers);
            //return _context.Product
            //        .Include(comment => comment.Comments)
            //        .ThenInclude(author => author.Account)
            //        .Include(country => country.Country)
            //        .Include(account => account.Account)
            //        .Include(votes => votes.Votes)
            //        .Where(x => x.Id == id)
            //        .Include(brewery => brewery.Brewery);
            return null;
        }

        public IQueryable<BeerTypeBeer> GetBeerById() {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetBreweryById() {
            throw new NotImplementedException();
        }
    }
}
