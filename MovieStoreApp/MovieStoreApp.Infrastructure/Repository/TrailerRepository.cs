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
    public class TrailerRepository : BaseRepositoryAsync<Trailer>, ITrailerRepositoryAsync
    {
        MovieContext _movieContext;
        public TrailerRepository(MovieContext _db) : base(_db)
        {
            _movieContext = _db;
        }

        public async Task<IEnumerable<Trailer>> TrailerByMovieIdAsync(int MovieId)
        {
            return await _movieContext.Trailer.Where(x => x.MovieId == MovieId).ToListAsync();
        }
    }
}
