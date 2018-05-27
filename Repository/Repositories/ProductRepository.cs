using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class ProductRepository : IProductRepository {
        public IQueryable<Product> GetAll() {
            throw new NotImplementedException();
        }

        public Product GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
