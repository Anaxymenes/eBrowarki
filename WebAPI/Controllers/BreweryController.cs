using Data.DTO;
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
    public class BreweryController : Controller {

        private readonly IBreweryService _breweryService;

        public BreweryController(IBreweryService breweryService) {
            _breweryService = breweryService;
        }

        [HttpPost("addBeer")]
        public IActionResult AddBeer([FromBody] BreweryAdd breweryAdd) {
            List<ClaimDTO> claims = new List<ClaimDTO>();
            foreach (var claim in User.Claims)
                claims.Add(new ClaimDTO { Type = claim.Type, Value = claim.Value });
            if (_breweryService.Add(breweryAdd, claims))
                return Ok();
            return BadRequest();
            //return Ok(claims);
        }
    }
}
