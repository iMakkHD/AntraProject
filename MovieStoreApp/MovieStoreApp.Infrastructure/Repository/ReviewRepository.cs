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
    public class ReviewRepositoryAsync : BaseRepositoryAsync<Review>, IReviewRepositoryAsync
    {
        MovieContext context;
        public ReviewRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<Review>> GetReviewByMovieAsync(int movieId)
        {
            return await context.Review.Where(x => x.MovieId == movieId).ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetReviewByUserAsync(int userId)
        {
            return await context.Review.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
