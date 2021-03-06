﻿using Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IAuthService {
        JWTBearerToken GetToken(AccountLoginVerificationDTO user);
        AccountLoginVerificationDTO GetUserByUserNameOrEmail(LoginDTO loginDTO);
        bool IsValid(AccountLoginVerificationDTO user, LoginDTO loginDTO);
        bool ExistUser(RegisterAccountDTO registerAccountDTO);
        bool RegisterUser(RegisterAccountDTO registerAccountDTO);
        bool SendVerificationEmail(string email);
        bool SendVerificationEmail(IEnumerable<ClaimDTO> claimDTOEnumarable);
        bool ActiveAccount(ActivatedAccount activatedAccount);
    }
}
