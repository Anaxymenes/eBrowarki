using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class BreweryRepository : IBreweryRepository {

        private readonly DatabaseContext _context;

        public BreweryRepository(DatabaseContext context) {
            _context = context;
        }

        public Brewery Add(Brewery entity) {
            try {
                _context.Add(entity);
                _context.SaveChanges();
                return _context.Brewery.Last();
            }catch(Exception e) {
                throw e ;
            }

        }

        public bool Add(Product product, Brewery brewery) {
            var result = false;
            using(var transaction = _context.Database.BeginTransaction()) {
                try {
                    _context.Product.Add(product);
                    _context.SaveChanges();
                    var productId = _context.Product.Last().Id;
                    brewery.ProductId = productId;
                    _context.Brewery.Add(brewery);
                    _context.SaveChanges();
                    transaction.Commit();
                    result = true;
                }catch(Exception e) {
                    transaction.Rollback();
                }
            }
            return result;
        }

        public bool Delete(int id, int userId) {
            throw new NotImplementedException();
        }

        public Brewery Edit(Brewery entity, int userId) {
            throw new NotImplementedException();
        }

        public IQueryable<Brewery> GetAll() {
            throw new NotImplementedException();
        }
    }
}
