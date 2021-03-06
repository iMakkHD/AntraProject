using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface ITrailerRepositoryAsync : IRepositoryAsync<Trailer>
    {
        Task<IEnumerable<Trailer>> TrailerByMovieIdAsync(int MovieId);

    }
}
