using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IAccountVerificationService {
        AccountVerification GetVerificationCodeForUserByEmail(string email);
    }
}
