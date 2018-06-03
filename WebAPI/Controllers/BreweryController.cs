using Data.DTO;
using Data.DTO.Add;
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
    public class BreweryController : Controller {

        private readonly IBreweryService _breweryService;

        public BreweryController(IBreweryService breweryService) {
            _breweryService = breweryService;
        }

        [HttpPost("addBrewery")]
        public IActionResult AddBrewery([FromBody] BreweryAdd breweryAdd) {
            if (_breweryService.Add(breweryAdd, ClaimsMethods.GetClaimsList(HttpContext.User.Claims)))
                return Ok();
            return BadRequest();
            //return Ok(claims);
        }
    }
}
