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
    public class UserRoleServiceAsync: IUserRoleServiceAsync
    {
        IUserRoleRepositoryAsync userRoleRepository;
        public UserRoleServiceAsync(IUserRoleRepositoryAsync _movie)
        {
            userRoleRepository = _movie;
        }

        public async Task<IEnumerable<UserRoleModel>> GetAllUserRolesAsync()
        {
            var result = await userRoleRepository.GetAllAsync();
            List<UserRoleModel> lstModel = new List<UserRoleModel>();
            foreach (var entity in result)
            {
                UserRoleModel model = new UserRoleModel();
                model.UserId = entity.UserId;
                model.RoleId = entity.RoleId;
                lstModel.Add(model);
            }
            return lstModel;
        }
    }
}
