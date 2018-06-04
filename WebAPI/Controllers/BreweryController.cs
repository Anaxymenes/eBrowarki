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
    public class BreweryController : Controller {

        private readonly IBreweryService _breweryService;

        public BreweryController(IBreweryService breweryService) {
            _breweryService = breweryService;
        }

        [HttpPost]
        public IActionResult AddBrewery([FromBody] BreweryAdd breweryAdd) {
            if (_breweryService.Add(breweryAdd, ClaimsMethods.GetClaimsList(HttpContext.User.Claims)))
                return Ok();
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] ProductDTO breweryDTO) {
            return BadRequest();
        }

        [AllowAnonymous]
        [HttpGet("getAllToForm")]
        public IActionResult GetAllBreweryFormList() {
            var result = _breweryService.GetAllFormList();
            if (result == null || result.Count == 0)
                return BadRequest();
            return Ok(result);
        }
    }
}
