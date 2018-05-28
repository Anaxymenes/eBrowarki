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
    public class BeerController : Controller
    {
        private readonly IBeerService _beerService;

        public BeerController(IBeerService beerService) {
            _beerService = beerService;
        }

        [HttpPost("addBeer")]
        public IActionResult AddBeer([FromBody] BeerAdd beerAdd) {
            if (_beerService.Add(beerAdd))
                return Ok();
            return BadRequest();
        }
    }
}
