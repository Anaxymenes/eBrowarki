using Data.DBModels;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{
    public class RoleService : IRoleService {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository  roleRepository) {
            _roleRepository = roleRepository;
        }

        public List<Role> GetAll() {
            return _roleRepository.GetAll().ToList();
        }
    }
}
