﻿using Data.DTO;
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
            return Ok(_productService.GetBeerById(id));
        }

        [HttpGet("getBrewery/{id}")]
        public IActionResult GetBreweryById(int id) {
            return Ok(_productService.GetBreweryById(id));
        }

        [HttpGet("getAllBeers/{itemsOnPage}/{page}")]
        public IActionResult GetAllBeers(int page, int itemsOnPage) {
            return Ok(_productService.GetAllProductByType(true, page, itemsOnPage));
        }

        [HttpGet("getAllBrewery/{itemsOnPage}/{page}")]
        public IActionResult GetAllBreweries(int page, int itemsOnPage) {
            return Ok(_productService.GetAllProductByType(false, page, itemsOnPage));
        }
        [Authorize]
        [HttpPost("addVote")]
        public IActionResult AddVote([FromBody]VoteDTO voteDTO) {
            if (_productService.AddVote(voteDTO, ClaimsMethods.GetClaimsList(HttpContext.User.Claims)) == true)
                return Ok();
            return BadRequest();
        }


    }
}
