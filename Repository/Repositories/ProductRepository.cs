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

        public bool AddVote(Vote vote) {
            try {
                if (_context.Vote.Any(x => x.AccountId == vote.AccountId && x.ProductId == vote.ProductId))
                    return false;
                _context.Vote.Add(vote);
                _context.SaveChanges();
                return true;
            }catch(Exception e) {
                return false;
            }
        }

        public bool ApproveProduct(int id) {
            try {
                var product = _context.Product.First(x => x.Id == id);
                product.Approved = true;
                _context.Product.Update(product);
                _context.SaveChanges();
                return true;
            }catch(Exception e) {
                return false;
            }
        }

        public bool Delete(int id, int userId) {
            throw new NotImplementedException();
        }

        public Product Edit(Product entity, int userId) {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll() {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllBeers(int page, int itemsOnPage) {
            return _context.Product.Where(x => x.Approved == true && x.IsBeer == true)
                .Include(beer => beer.Beer)
                    .ThenInclude(x => x.Brewery)
                        .ThenInclude(x => x.Product)
                .Include(x=>x.BeerTypeBeers)
                    .ThenInclude(x=>x.BeerType)
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

        public IQueryable<Product> GetAllBeersWithNotApproved() {
            return _context.Product.Where(x => x.IsBeer == true)
                .Include(beer => beer.Beer)
                    .ThenInclude(x => x.Brewery)
                        .ThenInclude(x => x.Product)
                 .Include(x => x.BeerTypeBeers)
                    .ThenInclude(x => x.BeerType)
                .Include(x => x.Country)
                .Include(x => x.Comments)
                    .ThenInclude(x => x.Account)
                .Include(x => x.Votes);
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

        public IQueryable<Product> GetAllBreweriesWithNotApproved() {
            return _context.Product.Where(x => x.IsBeer == false)
                        .Include(x => x.Brewery)
                        .Include(x => x.Country)
                        .Include(x => x.Comments)
                            .ThenInclude(x => x.Account)
                        .Include(x => x.Votes);
        }

        public IQueryable<Product> GetBeerById(int id) {
            try {
                return _context.Product.Where(x => x.Id == id && x.IsBeer == true)
                .Include(beer => beer.Beer)
                    .ThenInclude(x => x.Brewery)
                        .ThenInclude(x => x.Product)
                .Include(x => x.BeerTypeBeers)
                    .ThenInclude(x => x.BeerType)
                .Include(x => x.Country)
                .Include(x => x.Comments)
                    .ThenInclude(x => x.Account)
                .Include(x => x.Votes);
            }catch(Exception e) {
                return null;
            }
        }

        public IQueryable<Product> GetBreweryById(int id) {
            try {
                return _context.Product.Where(x => x.Id == id && x.IsBeer == false)
                        .Include(x => x.Brewery)
                        .Include(x => x.Country)
                        .Include(x => x.Comments)
                            .ThenInclude(x => x.Account)
                        .Include(x => x.Votes);
            }catch(Exception e) {
                return null;
            }
        }
    }
}
