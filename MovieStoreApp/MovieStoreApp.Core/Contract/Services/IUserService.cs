using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Core.Contract.Services
{
    public interface IUserServiceAsync
    {
        Task<UserModel> GetByIdAsync(int id);
    }
}
