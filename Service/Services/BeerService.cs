using Data.DTO.Add;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BeerService : IBeerService {

        private readonly IBeerRepository _beerRepository;

        public BeerService(IBeerRepository beerRepository) {
            _beerRepository = beerRepository;
        }

        public bool Add(BeerAdd beerAdd) {
            throw new NotImplementedException();
        }
    }
}
