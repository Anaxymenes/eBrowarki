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
                throw new Exception();
            }

        }

        public IQueryable<Brewery> GetAll() {
            throw new NotImplementedException();
        }

        public IQueryable<Brewery> GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
