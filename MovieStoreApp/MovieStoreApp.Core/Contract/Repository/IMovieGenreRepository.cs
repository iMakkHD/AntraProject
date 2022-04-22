using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IMovieGenreRepository : IRepositoryAsync<MovieGenre>
    {
        Task<IEnumerable<MovieGenre>> GetMGByMovieIdAsync(int movieId);
        Task<IEnumerable<MovieGenre>> GetMGByGenreIdAsync(int genreId);
    }
}
