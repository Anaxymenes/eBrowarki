﻿using Data.DTO;
using Data.DTO.Add;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpPost("addBeer")]
        public IActionResult AddBeer([FromBody] BeerAdd beerAdd) {
            List<ClaimDTO> claims = new List<ClaimDTO>();
            foreach (var claim in User.Claims)
                claims.Add(new ClaimDTO { Type = claim.Type, Value = claim.Value });
            if (_beerService.Add(beerAdd, claims))
                return Ok();
            return BadRequest();
            //return Ok(claims);
        }


    }
}
