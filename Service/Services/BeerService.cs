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

        public BeerService(IBeerRepository beerRepository,
            IProductRepository productRepository) {
            _beerRepository = beerRepository;
            _productRepository = productRepository;
        }

        public bool Add(BeerAdd beerAdd, List<ClaimDTO> claimsList) {
            int authorId = Convert.ToInt32(claimsList.Find(x => x.Type == "nameidentifier").Value);
            Product product = new Product() {
               AccountId =  authorId,
               CountryId = beerAdd.CountryId,
               Date = DateTime.Now,
               Description = beerAdd.Description,
               Picture = beerAdd.Picture,
               Name = beerAdd.Name,
               IsBeer = true,
            };
            var productFromDb = _productRepository.Add(product);
            Beer beer = new Beer() {
                Alcohol = beerAdd.Alcohol,
                //BeerTypeId = beerAdd.BeerTypeId,
                BreweryId = beerAdd.ProducerId,
                ProductId = productFromDb.Id
            };
            if (_beerRepository.Add(beer) != null)
                return true;

            return false;
        }
    }
}
