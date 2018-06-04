using AutoMapper;
using Data.DTO.Edit;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AccountService : IAccountService{
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountService(IAccountRepository accountRepository, IMapper mapper) {
            this._accountRepository = accountRepository;
            this._mapper = mapper;
        }

        public bool BlockStateUserManagement(BlockedUser blockedUser) {
            return _accountRepository.ChangeBlockUserStatus(blockedUser);
        }

        public bool UpdateRole(UpdateRole updateRole) {
            return _accountRepository.UpdateRole(updateRole);
        }
    }
}
