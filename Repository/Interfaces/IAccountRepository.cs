using Data.DBModels;
using Data.DTO;
using Data.DTO.Edit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IAccountRepository : IRepository<Account> {
        Account GetUserByUsernameOrEmail(string value);
        bool ExistEmail(string email);
        void RegisterUser(Account account,AccountVerification accountVerification);
        bool ActiveAccount(ActivatedAccount activatedAccount);
        bool UpdateRole(UpdateRole updateRole);

    }
}
