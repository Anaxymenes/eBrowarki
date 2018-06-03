using Data.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller {
        private readonly IAuthService _authService;

        public AuthController(IConfiguration config,
            IAuthService authService) {

            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult LoginAndGetToken([FromBody] LoginDTO loginDTO) {
            if (loginDTO == null)
                return BadRequest("Błąd przesyłu danych");
            var user = _authService.GetUserByUserNameOrEmail(loginDTO);
            if (user == null || !_authService.IsValid(user, loginDTO) || user.Active == false)
                return NotFound("Błędny dane logowania, konto nie aktywne lub użytkownik nie istnieje");
            return Ok(_authService.GetToken(user));
        }

        [Authorize]
        [HttpGet("test")]
        public IActionResult Test(string email) {
            //return Ok(_authService.SendVerificationEmail(email));
            return Ok(HttpContext.User.Claims.Select(x => new {
                Type = x.Type,
                Value = x.Value
            }
                ));
        }

        [HttpPost("register")]
        public IActionResult RegisterNewAccount([FromBody]RegisterAccountDTO registerAccountDTO) {
            if (registerAccountDTO == null ||
                _authService.ExistUser(registerAccountDTO) ||
                !registerAccountDTO.IsValid()
                )
                return BadRequest("Błąd rejestracji.");
            if (_authService.RegisterUser(registerAccountDTO) == false)
                return BadRequest("Błąd podczas rejestracji użytkownika. Spróbuj ponownie później.");
            return Ok();

        }

        [HttpPost("sendVerificationEmail")]
        public IActionResult SendVerificationEmail([FromBody] string email) {
            if (_authService.SendVerificationEmail(email))
                return Ok("Email aktywacyjny wysłany");
            return BadRequest("Email aktywacyjny nie został wysłany");
        }

        [HttpPost("activeAccount")]
        public IActionResult ActivatedAccount([FromBody] ActivatedAccount activatedAccount) {
            if (_authService.ActiveAccount(activatedAccount))
                return Ok("Konto pomyślnie aktywowane");
            return BadRequest("Błąd aktywacji");
        }
    }
}
