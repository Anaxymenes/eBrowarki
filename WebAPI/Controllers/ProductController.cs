using Data.DTO.Add;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller{

        private readonly IProductService _productService;

        public ProductController(IProductService productService) {
            _productService = productService;
        }

        [HttpGet("getBeer/{id}")]
        public IActionResult GetBeerById(int id) {
            return Ok(_productService.GetBeerById(id));
        }

        [HttpGet("getAllBeers")]
        public IActionResult GetAllBeers() {
            return Ok(_productService.GetAllProductByType(true));
        }

        [HttpGet("getAllBrewery")]
        public IActionResult GetAllBreweries() {
            return Ok(_productService.GetAllProductByType(false));
        }


    }
}
