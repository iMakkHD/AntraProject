using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class MovieRepositoryAsync : BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        MovieContext context;
        public MovieRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync()
        {
            return await context.Movie.OrderByDescending(x => x.Revenue).Take(10).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync()
        {
            return await context.Movie.OrderByDescending(x => x.ReleaseDate).Take(3).ToListAsync();
        }
    }
}
