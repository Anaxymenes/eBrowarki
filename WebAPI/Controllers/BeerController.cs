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
    [Authorize]
    [Route("api/[controller]")]
    public class BeerController : Controller
    {
        private readonly IBeerService _beerService;

        public BeerController(IBeerService beerService) {
            _beerService = beerService;
        }

        
        [HttpPost]
        public IActionResult AddBeer([FromBody] BeerAdd beerAdd) {
            if (_beerService.Add(beerAdd, ClaimsMethods.GetClaimsList(User.Claims)))
                return Ok();
            return BadRequest();
        }


    }
}
