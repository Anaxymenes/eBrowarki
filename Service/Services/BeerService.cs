﻿using AutoMapper;
using Data.DBModels;
using Data.DTO;
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
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public BeerService(IBeerRepository beerRepository,
            IProductRepository productRepository,
            IMapper mapper) {
            _beerRepository = beerRepository;
            _productRepository = productRepository;
            this._mapper = mapper;
        }

        public bool Add(BeerAdd beerAdd, List<ClaimDTO> claimsList) {
            if (beerAdd == null)
                return false;
            int authorId = Convert.ToInt32(claimsList.Find(x => x.Type == "nameidentifier").Value);
            var product = _mapper.Map<Product>(beerAdd);
            product.AccountId = authorId;
            product.IsBeer = true;
            var beer = _mapper.Map<Beer>(beerAdd);
            if (_beerRepository.Add(product, beer, beerAdd.BeerTypeBeerList))
                return true;
            return false;
        }
    }
}
