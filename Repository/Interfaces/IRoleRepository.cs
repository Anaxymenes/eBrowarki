﻿using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IRoleRepository : IRepository<Role> {
        IQueryable<Role> GetAll();
    }
}
