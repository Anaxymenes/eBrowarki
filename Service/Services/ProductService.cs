using AutoMapper;
using Data.DBModels;
using Data.DTO;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{
    public class ProductService : IProductService {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository,
            IMapper mapper) {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public bool AddVote(VoteDTO voteDTO, List<ClaimDTO> claims) {
            //var vote = new Vote() {
            //    AccountId =Convert.ToInt32(claims.First(x => x.Type == "nameidentifier").Value),

            //};
            //return _productRepository.AddVote()
            var authorId = Convert.ToInt32(claims.First(x => x.Type == "nameidentifier").Value);
            var vote = _mapper.Map<Vote>(voteDTO);
            vote.AccountId = authorId;
            return _productRepository.AddVote(vote);
        }

        public bool ApproveProduct(int id) {
            return _productRepository.ApproveProduct(id);
        }

        public List<ProductDTO> GetAllProductByType(bool isBeer, int page, int itemsOnPage) {
            List<ProductDTO> results = new List<ProductDTO>();
            if (isBeer) {
                var temp = _productRepository.GetAllBeers(page, itemsOnPage);
                foreach (var obj in temp)
                    results.Add(_mapper.Map<ProductDTO>(obj));
                
            } else {
                var res = _productRepository.GetAllBreweries(page, itemsOnPage);
                foreach (var obj in res)
                    results.Add(_mapper.Map<ProductDTO>(obj));
            }
            return results;
        }

        public ProductDTO GetBeerById(int id) {
            return _mapper.Map<ProductDTO>(_productRepository.GetBeerById(id).First());
        }

        public ProductDTO GetBreweryById(int id) {
            return _mapper.Map<ProductDTO>(_productRepository.GetBreweryById(id).First());
        }
    }
}
