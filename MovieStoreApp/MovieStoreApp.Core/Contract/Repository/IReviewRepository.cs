﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IReviewRepositoryAsync : IRepositoryAsync<Review>
    {
        Task<IEnumerable<Review>> GetReviewByUserAsync(int userId);
        Task<IEnumerable<Review>> GetReviewByMovieAsync(int movieId);
    }
}
