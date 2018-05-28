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

        public ProductService(IProductRepository productRepository) {
            _productRepository = productRepository;
        }

        public List<ProductDTO> GetAllProductByType(bool isBeer) {
            var resultsFromDB = _productRepository.GetAllByType(isBeer);
            if (resultsFromDB == null)
                return null;
            List<ProductDTO> results = new List<ProductDTO>();
            foreach (var obj in resultsFromDB)
                results.Add(this.GetProductDTO(obj));

            return results;
        }

        public ProductDTO GetById(int id) {
            return this.GetProductDTO(_productRepository.GetById(id).First());
        }

        protected ProductDTO GetProductDTO(Product result) {
            ProductDTO productDTO = new ProductDTO() {
                Id = result.Id,
                Country = result.Country.Name,
                CountryId = result.CountryId,
                Date = result.Date,
                Name = result.Name,
                Description = result.Description,
                Picture = result.Picture,

            };
            List<CommentDTO> commentList = new List<CommentDTO>();
            if (result.Comments.Count > 0) {
                foreach (var obj in result.Comments) {
                    commentList.Add(
                        new CommentDTO {
                            AccountId = obj.AccountId,
                            Author = obj.Account.Username,
                            Content = obj.Content,
                            Date = obj.Date,
                            Id = obj.Id
                        }
                        );
                }
                productDTO.Comments = commentList;
            }
            if (result.Votes.Count > 0) {
                int countOfVotes = result.Votes.Count;
                int value = 1;
                foreach (var obj in result.Votes)
                    value += obj.VoteValue;
                productDTO.Vote = (double)value / countOfVotes;
            }
            if (result.IsBeer == true) {
                BeerDTO beerDTO = new BeerDTO() {
                    Alcohol = result.Beer.Alcohol,
                    BeerType = result.Beer.BeerType.Name,
                    Producer = result.Beer.Brewery.Product.Name,
                    ProducerId = result.Beer.Brewery.Product.Id
                };
                productDTO.Beer = beerDTO;
            } else {
                BreweryDTO breweryDTO = new BreweryDTO() {
                    NumberOfBuilding = result.Brewery.NumberOfBuilding,
                    Place = result.Brewery.Place,
                    PostalCode = result.Brewery.PostalCode,
                    PostOffice = result.Brewery.PostOffice,
                    Street = result.Brewery.Street
                };
                productDTO.Brewery = breweryDTO;
            }
            return productDTO;
        }
    }
}
