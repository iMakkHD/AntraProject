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
    public class UserRoleRepository : BaseRepositoryAsync<UserRole>, IUserRoleRepositoryAsync
    {
        MovieContext _movieContext;
        public UserRoleRepository(MovieContext _db) : base(_db)
        {
            _movieContext = _db;
        }

        public async Task<IEnumerable<UserRole>> GetURByRoleIdAsync(int roleId)
        {
            return await _movieContext.UserRole.Where(x => x.RoleId == roleId).ToListAsync();
        }

        public async Task<IEnumerable<UserRole>> GetURByUserIdAsync(int userId)
        {
            return await _movieContext.UserRole.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
