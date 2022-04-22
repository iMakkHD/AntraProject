using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Services
{
    public interface IReviewServiceAsync
    {
        Task<IEnumerable<ReviewModel>> GetReviewByMovieIdAsync(int movieId);
        Task<IEnumerable<ReviewModel>> GetReviewByUserIdAsync(int userId);
    }
}
