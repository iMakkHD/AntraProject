﻿using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Services
{
    public interface IRoleServiceAsync
    {
        Task<IEnumerable<RoleModel>> GetRoleByNameAsync(string name);
    }
}
