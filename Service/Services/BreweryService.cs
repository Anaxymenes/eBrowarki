using AutoMapper;
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
    public class BreweryService : IBreweryService {
        private readonly IBreweryRepository _breweryRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public BreweryService(IBreweryRepository breweryRepository,
            IProductRepository productRepository,
            IMapper mapper) {
            _breweryRepository = breweryRepository;
            _productRepository = productRepository;
            this._mapper = mapper;
        }

        public bool Add(BreweryAdd breweryAdd, List<ClaimDTO> claimsList) {
            //int authorId = Convert.ToInt32(claimsList.Find(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value);
            //Product product = new Product() {
            //    AccountId = authorId,
            //    CountryId = breweryAdd.CountryId,
            //    Date = DateTime.Now,
            //    Description = breweryAdd.Description,
            //    Picture = breweryAdd.Picture,
            //    Name = breweryAdd.Name,
            //    IsBeer = true,
            //};
            //var productFromDb = _productRepository.Add(product);
            //Brewery brewery = new Brewery() {
            //    NumberOfBuilding = breweryAdd.NumberOfBuilding,
            //    Place = breweryAdd.Place,
            //    PostalCode = breweryAdd.PostalCode,
            //    PostOffice = breweryAdd.PostOffice,
            //    Street = breweryAdd.Street,
            //    ProductId = productFromDb.Id
            //};
            //if (_breweryRepository.Add(brewery) != null)
            //    return true;
            if (breweryAdd == null)
                return false;
            int authorId = Convert.ToInt32(claimsList.Find(x => x.Type == "nameidentifier").Value);
            var product = _mapper.Map<Product>(breweryAdd);
            var brewery = _mapper.Map<Brewery>(breweryAdd);
            if (_breweryRepository.Add(product, brewery))
                return true;
            return false;
        }
    }
}
