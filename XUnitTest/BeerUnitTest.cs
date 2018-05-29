using Data.DBModels;
using Moq;
using Repository.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Controllers;
using Xunit;

namespace XUnitTest
{
    public class BeerUnitTest
    {
        [Fact]
        public void ShouldReturnBeerById()
        {
            var beerTypeList = BeerTypeMoq.BeerTypeList;
            var breweryList = BreweryMoq.BreweryList;
            var productList = ProductMoq.ProductList;

            List<Beer> beer = new List<Beer>() {
                new Beer(){
                Id=1, Alcohol=5.6,  BeerType = beerTypeList[0],  BeerTypeId = beerTypeList[0].Id, Brewery = breweryList[0], BreweryId = breweryList[0].Id, Product = productList[0], ProductId=productList[0].Id
                }
            };
            var productRepository = new Mock<IProductRepository>();
            var beerRepository = new Mock<IBeerRepository>();
            beerRepository.Setup(b => b.GetById(1)).Returns(beer.AsQueryable());
            var beerService = new BeerService(beerRepository.Object, productRepository.Object);
            var beerController = new BeerController(beerService);
        }
    }
}
