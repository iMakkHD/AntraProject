using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Infrastructure.Services
{
    public class RoleServiceAsync : IRoleServiceAsync
    {
        IRoleRepositoryAsync roleRepository;
        public RoleServiceAsync(IRoleRepositoryAsync _movie)
        {
            roleRepository = _movie;
        }

        public async Task<IEnumerable<RoleModel>> GetRoleByNameAsync(string name)
        {
            var result = await roleRepository.GetRoleByNameAsync(name);
            List<RoleModel> lstModel = new List<RoleModel>();
            foreach (var entity in result)
            {
                RoleModel model = new RoleModel();
                model.Id = entity.Id;
                model.Name = entity.Name;
                lstModel.Add(model);
            }
            return lstModel;
        }
    }
}
