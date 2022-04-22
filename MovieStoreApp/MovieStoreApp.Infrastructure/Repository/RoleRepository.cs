using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class RoleRepository : BaseRepositoryAsync<Role>, IRoleRepositoryAsync
    {
        MovieContext _movieContext;
        public RoleRepository(MovieContext _db) : base(_db)
        {
            _movieContext = _db;
        }

        public async Task<IEnumerable<Role>> GetRoleByNameAsync(string name)
        {
            return await _movieContext.Role.Where(x => x.Name == name).ToListAsync();
        }
    }
}
