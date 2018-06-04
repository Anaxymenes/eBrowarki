using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        

        public CountryController(ICountryService countryService) {
            this._countryService = countryService;
        }

        [HttpGet("getAllToForm")]
        public IActionResult GetAllCountryFormList() {
            var result = _countryService.GetAllFormList();
            if (result == null || result.Count == 0)
                return BadRequest();
            return Ok(result);
        }
    }
}
