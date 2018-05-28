using System;
using System.Collections.Generic;
using System.Text;
using Data.DTO.Add;

namespace Service.Interfaces
{
    public interface IBeerService {
        bool Add(BeerAdd beerAdd);
    }
}
