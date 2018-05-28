﻿using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class BeerRepository : IBeerRepository {

        private readonly DatabaseContext _context;

        public BeerRepository(DatabaseContext context) {
            _context = context;
        }

        public Beer Add(Beer entity) {
            try {
                _context.Add(entity);
                _context.SaveChanges();
                return _context.Beer.Last();
            }catch(Exception e) {
                throw e;
            }
        }

        public IQueryable<Beer> GetAll() {
            throw new NotImplementedException();
        }

        public IQueryable<Beer> GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
