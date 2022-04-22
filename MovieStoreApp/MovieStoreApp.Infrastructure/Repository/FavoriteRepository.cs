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
    public class FavoriteRepositoryAsync : BaseRepositoryAsync<Favorite>, IFavoriteRepository
    {
        MovieContext context;
        public FavoriteRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<Favorite>> GetFavoriteByMovieIdAsync(int movieId)
        {
            return await context.Favorite.Where(x => x.MovieId == movieId).ToListAsync();
        }

        public async Task<IEnumerable<Favorite>> GetFavoriteByUserIdAsync(int userId)
        {
            return await context.Favorite.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
