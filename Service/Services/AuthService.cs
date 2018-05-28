using Data.DBModels;
using Data.DTO;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Service.Services
{
    public class AuthService : IAuthService {
        private IConfiguration Configuration;
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountVerificationService _accountVerificationService;

        public AuthService(
            IConfiguration config,
            IAccountRepository accountRepository,
            IAccountVerificationService accountVerificationService
            ) {
            Configuration = config;
            _accountRepository = accountRepository;
            _accountVerificationService = accountVerificationService;
        }

        public JWTBearerToken GetToken(AccountLoginVerificationDTO user) {
            return this.JwtTokenBuilder(user);
        }

        public bool IsValid(AccountLoginVerificationDTO user, LoginDTO loginDTO) {
            return user.Password.Equals(this.GetHashedPassword(loginDTO.Password, Encoding.UTF8.GetBytes(user.PasswordSalt)));
        }

        public AccountLoginVerificationDTO GetUserByUserNameOrEmail(LoginDTO loginDTO) {
            var results = _accountRepository.GetUserByUsernameOrEmail(loginDTO.Email);
            if (results == null)
                return null;
            return new AccountLoginVerificationDTO() {
                Id = results.Id,
                Active = results.Active,
                Avatar = results.Avatar,
                Email = results.Email,
                Password = results.Password,
                PasswordSalt = results.PasswordSalt,
                Role = results.Role.Name,
                Username = results.Username
            };
        }

        private JWTBearerToken JwtTokenBuilder(AccountLoginVerificationDTO user) {
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(Configuration["JWT:key"]));

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString(),"Id"),
                new Claim(ClaimTypes.Email,user.Email,"Email"),
                new Claim(ClaimTypes.Name, user.Username,"Username"),
                new Claim(ClaimTypes.Role, user.Role, "Role")
            };
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(issuer: Configuration["JWT:issuer"],
                audience: Configuration["JWT:audience"],
                signingCredentials: credentials,
                claims: claims,
                expires: DateTime.Now.AddMinutes(5));
            JWTBearerToken jwTBearerToken = new JWTBearerToken();
            jwTBearerToken.Token = new JwtSecurityTokenHandler().WriteToken(token);
            jwTBearerToken.Expires = token.ValidTo;
            return jwTBearerToken;
        }

        protected byte[] GetSalt() {
            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create()) {
                rng.GetBytes(salt);
            }
            string result = Convert.ToBase64String(salt);
            return Encoding.ASCII.GetBytes(result);
        }

        protected byte[] GetCodeVerification() {
            byte[] salt = new byte[32 / 4];
            using (var rng = RandomNumberGenerator.Create()) {
                rng.GetBytes(salt);
            }
            string result = Convert.ToBase64String(salt);
            return Encoding.ASCII.GetBytes(result);
        }

        protected string EncodeByteToString(byte[] value) {
            return Encoding.UTF8.GetString(value);
        }

        protected string GetHashedPassword(string password, byte[] salt) {
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8
                ));
            return hashedPassword;
        }


        public bool ExistUser(RegisterAccountDTO registerAccountDTO) {
            return _accountRepository.ExistEmail(registerAccountDTO.Email);
        }

        public bool RegisterUser(RegisterAccountDTO registerAccountDTO) {
            byte[] salt = this.GetSalt();
            Account account = new Account() {
                Email = registerAccountDTO.Email,
                Username = registerAccountDTO.Email.Substring(0,registerAccountDTO.Email.IndexOf('@')),
                Active = false,
                RoleId = 3,
                Password = this.GetHashedPassword(registerAccountDTO.Password, salt),
                PasswordSalt = this.EncodeByteToString(salt)
            };
            AccountVerification accountVerification = new AccountVerification() {
                CodeVerification = this.EncodeByteToString(this.GetCodeVerification())
            };
            try {
                _accountRepository.RegisterUser(account, accountVerification);
                this.SendVerificationEmail(account.Email);
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool SendVerificationEmail(string email) {
            try {
                var acountVerification = _accountVerificationService.GetVerificationCodeForUserByEmail(email);
                using (var client = new SmtpClient() {
                    Host = "smtp.gmail.com",
                    Port = 587, // Port 
                    EnableSsl = true,
                    Credentials = new NetworkCredential("adm.ehobby@gmail.com", "3Hobby1234")
                }) {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("adm.ehobby@gmail.com");
                    mailMessage.To.Add(email);
                    mailMessage.Body = "Your verification code is : " + acountVerification.CodeVerification;
                    mailMessage.Subject = "eBrowarki Account Verification";
                    client.Send(mailMessage);
                    return true;
                }
            } catch (Exception e) {
                return false;
            }
        }

        public bool SendVerificationEmail(IEnumerable<ClaimDTO> claimDTOEnumarable) {
            foreach (var claim in claimDTOEnumarable)
                if (claim.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"))
                    return this.SendVerificationEmail(claim.Value);
            return false;
        }

        public bool ActiveAccount(ActivatedAccount activatedAccount) {
            return _accountRepository.ActiveAccount(activatedAccount);
        }
    }
}
