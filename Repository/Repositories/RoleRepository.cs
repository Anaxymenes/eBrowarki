using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Linq;

namespace Repository.Repositories {
    public class RoleRepository : IRoleRepository {
        private readonly DatabaseContext _context;

        public RoleRepository(DatabaseContext context) {
            _context = context;
        }

        public IQueryable<Role> GetAll() {
            return _context.Role.AsQueryable();
        }

        public Role GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
