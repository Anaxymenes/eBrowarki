//using Data.DBModels;
//using Data.DTO.FormList;
//using Microsoft.AspNetCore.Mvc;
//using Moq;
//using Repository.Interfaces;
//using Service.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using WebAPI.Controllers;
//using Xunit;

//namespace XUnitTest
//{
//    public class CountryUnitTest
//    {
//        [Fact]
//        public void ShoulReturnListOfCountries()
//        {
//            List<Country> countries = new List<Country>()
//            {
//                new Country()
//                {
//                    Name = "Poland",
//                    Id = 20,
//                    Shortcut = "PL"
//                },
//                new Country()
//                {
//                    Name = "Germany",
//                    Id = 10,
//                    Shortcut = "GER"
//                }
//            };

//            var repository = new Mock<ICountryRepository>();
//            repository.Setup(r => r.GetAll()).Returns(countries.AsQueryable());
//            AutoMapper.IMapper mapper = null;
//            var service = new CountryService(repository.Object, mapper);
//            var controller = new CountryController(service);

//            IActionResult result = controller.GetAll();
//            var okObjectResult = result as OkObjectResult;
//            Assert.NotNull(okObjectResult);

//            Assert.Equal(result, countries);
//        }
//    }
//}
