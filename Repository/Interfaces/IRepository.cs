using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T:Entity {

        bool Delete(int id, int userId);
        IQueryable<T> GetAll();
        T Add(T entity);
        T Edit(T entity, int userId);
    }
}
