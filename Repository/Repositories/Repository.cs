﻿using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity {
        public T Add(T entity) {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll() {
            throw new NotImplementedException();
        }

        public T GetById(int id) {
            throw new NotImplementedException();
        }

        IQueryable<T> IRepository<T>.GetBeerById(int id) {
            throw new NotImplementedException();
        }
    }
}
