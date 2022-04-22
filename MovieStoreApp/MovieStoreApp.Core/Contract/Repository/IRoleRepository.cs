using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IRoleRepositoryAsync: IRepositoryAsync<Role>
    {
        Task<IEnumerable<Role>> GetRoleByNameAsync(string name);
    }
}
