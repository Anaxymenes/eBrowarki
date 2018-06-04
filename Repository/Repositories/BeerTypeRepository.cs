using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class BeerTypeRepository : IBeerTypeRepository {
        private readonly DatabaseContext _context;

        public BeerTypeRepository(DatabaseContext context) {
            this._context = context;
        }

        public BeerType Add(BeerType entity) {
            throw new NotImplementedException();
        }

        public bool Delete(int id, int userId) {
            throw new NotImplementedException();
        }

        public BeerType Edit(BeerType entity, int userId) {
            throw new NotImplementedException();
        }

        public IQueryable<BeerType> GetAll() {
            return _context.BeerType.AsQueryable();
        }
    }
}
