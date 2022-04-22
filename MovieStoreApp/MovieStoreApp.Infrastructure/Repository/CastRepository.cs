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
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>, ICastRepository
    {
        MovieContext context;
        public CastRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<Cast>> GetCastByNameAsync(string name)
        {
            return await context.Cast.Where(x => x.Name == name).Take(1).ToListAsync();
        }
    }
}