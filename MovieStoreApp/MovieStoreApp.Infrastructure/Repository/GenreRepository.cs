using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Contract.Repository;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class GenreRepositoryAsync : BaseRepositoryAsync<Genre>, IGenreRepositoryAsync
    {
        MovieContext context;
        public GenreRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<Genre>> GetGenreByNameAsync(string name)
        {
            return await context.Genre.Where(x => x.Name == name).ToListAsync();
        }
    }
}
