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
    public class UserService: IUserServiceAsync
    {
        IUserRepositoryAsync userRepository;
        public UserService(IUserRepositoryAsync _movie)
        {
            userRepository = _movie;
        }

        public async Task<UserModel> GetByIdAsync(int id)
        {
            var entity = await userRepository.GetAsync(id);
            UserModel model = new UserModel();
            model.Id = entity.Id;
            model.FirstName = entity.FirstName;
            model.LastName = entity.LastName;
            model.DateOfBirth = entity.DateOfBirth;
            model.Email = entity.Email;
            model.HashedPassword = entity.HashedPassword;
            model.Salt = entity.Salt;
            model.PhoneNumber = entity.PhoneNumber;
            model.TwoFactorEnabled = entity.TwoFactorEnabled;
            model.LockedEndDate = entity.LockedEndDate;
            model.LastLoginDateTime = entity.LastLoginDateTime;
            model.IsLocked = entity.IsLocked;
            model.AccessFailedCount = entity.AccessFailedCount;
            return model;
        }
    }
}
