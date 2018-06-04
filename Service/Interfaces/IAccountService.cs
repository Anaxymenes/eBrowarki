using System;
using System.Collections.Generic;
using System.Text;
using Data.DTO.Edit;

namespace Service.Interfaces
{
    public interface IAccountService {
        bool UpdateRole(UpdateRole updateRole);
        bool BlockStateUserManagement(BlockedUser blockedUser);
    }
}
