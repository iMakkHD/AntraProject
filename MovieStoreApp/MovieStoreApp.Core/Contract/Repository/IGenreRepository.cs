using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IGenreRepository : IRepositoryAsync<Genre>
    {
        Task<IEnumerable<Genre>> GetGenreByNameAsync(string name);
    }
}
