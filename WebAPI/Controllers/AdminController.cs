using AutoMapper;
using Data.DTO.Edit;
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
    [Authorize(Roles ="Admin,Moderator")]
    public class AdminController : Controller {
        private readonly IAccountService _accountService;

        public AdminController(IAccountService accountService
            ) {
            this._accountService = accountService;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("updateRole")]
        public IActionResult UpdateRole([FromBody] UpdateRole updateRole) {
            if(_accountService.UpdateRole(updateRole))
                return Ok();
            return BadRequest();
        }

        [HttpPost("blockUserManagement")]
        public IActionResult BlockUserManagement([FromBody] BlockedUser blockedUser) {
            if (_accountService.BlockStateUserManagement(blockedUser))
                return Ok();
            return BadRequest();
        }

    }
}
