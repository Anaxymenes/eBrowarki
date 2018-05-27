using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class Repository<T> :IRepository<T> where T:Entity {
    }
}
