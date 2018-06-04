using AutoMapper;
using Data.DBModels;
using Data.DTO;
using Data.DTO.Add;
using Data.DTO.FormList;
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
            if (breweryAdd == null)
                return false;
            int authorId = Convert.ToInt32(claimsList.Find(x => x.Type == "nameidentifier").Value);
            var product = _mapper.Map<Product>(breweryAdd);
            product.AccountId = authorId;
            var brewery = _mapper.Map<Brewery>(breweryAdd);
            if (_breweryRepository.Add(product, brewery))
                return true;
            return false;
        }

        public List<BreweryFormList> GetAllFormList() {
            var resultsDb = _productRepository.GetAllBreweriesWithNotApproved();
            List<BreweryFormList> results = new List<BreweryFormList>();
            if(results != null) {
                foreach (var obj in resultsDb)
                    results.Add(_mapper.Map<BreweryFormList>(obj));
                return results;
            }
            return null;
        }
    }
}
