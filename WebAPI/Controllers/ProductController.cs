using Data.DTO;
using Data.DTO.Add;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.utils;
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
            var result = _productService.GetBeerById(id);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }

        [HttpGet("getBrewery/{id}")]
        public IActionResult GetBreweryById(int id) {
            var result = _productService.GetBreweryById(id);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }

        [HttpGet("getAllBeers/{itemsOnPage}/{page}")]
        public IActionResult GetAllBeers(int page, int itemsOnPage) {
            var result = _productService.GetAllProductByType(true, page, itemsOnPage);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }

        [HttpGet("getAllBrewery/{itemsOnPage}/{page}")]
        public IActionResult GetAllBreweries(int page, int itemsOnPage) {
            var result = _productService.GetAllProductByType(false, page, itemsOnPage);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }
        [Authorize]
        [HttpPost("addVote")]
        public IActionResult AddVote([FromBody]VoteDTO voteDTO) {
            if (_productService.AddVote(voteDTO, ClaimsMethods.GetClaimsList(HttpContext.User.Claims)) == true)
                return Ok();
            return BadRequest();
        }

        [Authorize(Roles ="Moderator,Admin")]
        [HttpPost("approveProduct/{id}")]
        public IActionResult ApproveProduct(int id) {
            if (_productService.ApproveProduct(id))
                return Ok();
            return BadRequest();
        }


    }
}
