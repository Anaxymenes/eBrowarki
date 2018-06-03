using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{

    public interface IBeerRepository : IRepository<Beer> {
        bool Add(Product product, Beer beer, List<int> beerTypeBeerList);
    }
}
