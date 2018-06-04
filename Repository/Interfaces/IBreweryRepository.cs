using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IBreweryRepository : IRepository<Brewery> {
        bool Add(Product product, Brewery brewery);
    }
}
