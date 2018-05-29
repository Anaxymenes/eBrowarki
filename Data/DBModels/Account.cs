using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Account : Entity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Avatar { get; set; }
        public bool Active { get; set; }
        public bool Blocked { get; set; }

        public Role Role { get; set; }
        public int RoleId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Vote> Votes { get; set; }
        public AccountToken AccountToken { get; set; }
        public AccountVerification AccountVerification { get; set; }
    }
}
