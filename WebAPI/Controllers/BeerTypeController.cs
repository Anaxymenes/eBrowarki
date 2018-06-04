using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class BeerTypeController : Controller
    {
        private readonly IBeerTypeService _beerTypeService;

        public BeerTypeController(IBeerTypeService beerTypeService) {
            this._beerTypeService = beerTypeService;
        }
        [HttpGet("getAllToForm")]
        public IActionResult GetBeerTypeListToForm() {
            var result = _beerTypeService.GetAllBeerTypeFormList();
            if (result == null)
                return BadRequest();
            return Ok(result);
        }
    }
}
