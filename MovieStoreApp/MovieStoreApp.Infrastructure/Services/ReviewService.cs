using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Infrastructure.Services
{
    public class ReviewService : IReviewServiceAsync
    {
        IReviewRepositoryAsync reviewRepository;
        public ReviewService(IReviewRepositoryAsync _movie)
        {
            reviewRepository = _movie;
        }

        public async Task<IEnumerable<ReviewModel>> GetReviewByMovieIdAsync(int movieId)
        {
            var result = await reviewRepository.GetReviewByMovieAsync(movieId);
            List<ReviewModel> lstModel = new List<ReviewModel>();
            foreach (var entity in result)
            {
                ReviewModel model = new ReviewModel();
                model.Id = entity.Id;
                model.MovieId = entity.MovieId;
                model.UserId = entity.UserId;
                model.Rating = entity.Rating;
                model.ReviewText = entity.ReviewText;
                model.User = entity.User;
                model.Movie = entity.Movie;
                lstModel.Add(model);
            }
            return lstModel;
        }

        public async Task<IEnumerable<ReviewModel>> GetReviewByUserIdAsync(int userId)
        {
            var result = await reviewRepository.GetReviewByUserAsync(userId);
            List<ReviewModel> lstModel = new List<ReviewModel>();
            foreach (var entity in result)
            {
                ReviewModel model = new ReviewModel();
                model.Id = entity.Id;
                model.MovieId = entity.MovieId;
                model.UserId = entity.UserId;
                model.Rating = entity.Rating;
                model.ReviewText = entity.ReviewText;
                model.User = entity.User;
                model.Movie = entity.Movie;
                lstModel.Add(model);
            }
            return lstModel;
        }
    }
}
