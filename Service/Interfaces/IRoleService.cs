using Data.DBModels;
using System.Collections.Generic;

namespace Service.Interfaces {
    public interface IRoleService {
        List<Role> GetAll();
    }
}
