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
    public class MovieGenreRepository : BaseRepositoryAsync<MovieGenre>, IMovieGenreRepositoryAsync
    {
        MovieContext context;
        public MovieGenreRepository(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<MovieGenre>> GetMGByGenreIdAsync(int genreId)
        {
            return await context.MovieGenre.Where(x => x.GenreId == genreId).ToListAsync();
        }

        public async Task<IEnumerable<MovieGenre>> GetMGByMovieIdAsync(int movieId)
        {
            return await context.MovieGenre.Where(x => x.MovieId == movieId).ToListAsync();
        }
    }
}
