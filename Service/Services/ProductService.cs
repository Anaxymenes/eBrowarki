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
                if (temp == null)
                    return null;
                foreach (var obj in temp) {
                    List<BeerTypeBeerDTO> list = new List<BeerTypeBeerDTO>();
                    foreach (var beerTypeBeer in obj.BeerTypeBeers)
                        list.Add(_mapper.Map<BeerTypeBeerDTO>(beerTypeBeer));
                    var productDTO = _mapper.Map<ProductDTO>(obj);
                    productDTO.Beer.BeerTypeBeerDTO = list;
                    results.Add(productDTO);
                }
                    
                
            } else {
                var res = _productRepository.GetAllBreweries(page, itemsOnPage);
                if (res == null)
                    return null;
                foreach (var obj in res)
                    results.Add(_mapper.Map<ProductDTO>(obj));
            }
            return results;
        }

        public ProductDTO GetBeerById(int id) {
            try {
                var resultDb = _productRepository.GetBeerById(id).First();
                List<BeerTypeBeerDTO> list = new List<BeerTypeBeerDTO>();
                foreach (var beerTypeBeer in resultDb.BeerTypeBeers)
                    list.Add(_mapper.Map<BeerTypeBeerDTO>(beerTypeBeer));
                var result = _mapper.Map<ProductDTO>(resultDb);
                result.Beer.BeerTypeBeerDTO = list;
                return result;
            } catch (Exception e) {
                return null;
            }
        }

        public ProductDTO GetBreweryById(int id) {
            try {
                return _mapper.Map<ProductDTO>(_productRepository.GetBreweryById(id).First());
            }catch(Exception e) {
                return null;
            }
        }
    }
}
