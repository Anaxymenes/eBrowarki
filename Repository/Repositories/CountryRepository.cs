using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class CountryRepository : ICountryRepository {
        private readonly DatabaseContext _context;

        public CountryRepository(DatabaseContext context) {
            this._context = context;
        }

        public Country Add(Country entity) {
            throw new NotImplementedException();
        }

        public bool Delete(int id, int userId) {
            throw new NotImplementedException();
        }

        public Country Edit(Country entity, int userId) {
            throw new NotImplementedException();
        }

        public IQueryable<Country> GetAll() {
            return _context.Country.AsQueryable(); 
        }
    }
}
