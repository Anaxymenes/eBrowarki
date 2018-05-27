using Data.DBModels;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class RoleController  : Controller {

        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService) {
            _roleService = roleService;

        }


        public IActionResult GetAll() {
            List<Role> results = _roleService.GetAll();
            if (results == null)
                return BadRequest("Error");
            return Ok(results);

        }
    }
}
