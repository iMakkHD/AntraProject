using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Core.Contract.Services
{
    public interface IGenreServiceAsync
    {
        Task<int> AddGenreAsync(GenreModel model);
        Task<IEnumerable<GenreModel>> GetAllGenreAsync();
        Task<GenreModel> GetGenreAsync(int id);
    }
}
