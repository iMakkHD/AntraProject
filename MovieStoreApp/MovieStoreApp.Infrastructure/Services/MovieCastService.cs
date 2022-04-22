using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
namespace MovieStoreApp.Infrastructure.Service
{
    public class MovieCastServiceAsync : IMovieCastServiceAsync
    {
        IMovieCastRepositoryAsync movieCastRepository;
        public MovieCastServiceAsync(IMovieCastRepositoryAsync _movie)
        {
            movieCastRepository = _movie;
        }

        public async Task<IEnumerable<MovieCastModel>> GetAllByCastIdAsync(int castId)
        {
            var result = await movieCastRepository.GetAllByCastIdAsync(castId);
            List<MovieCastModel> lstModel = new List<MovieCastModel>();
            foreach (var entity in result)
            {
                MovieCastModel model = new MovieCastModel();
                model.CastId = entity.CastId;
                model.Id = entity.Id;
                model.Cast = new CastModel()
                {
                    Id = entity.Cast.Id,
                    Gender = entity.Cast.Gender,
                    Name = entity.Cast.Name,
                    ProfilePath = entity.Cast.ProfilePath,
                    TmdbUrl = entity.Cast.TmdbUrl
                };
                lstModel.Add(model);
            }
            return lstModel;
        }

        public async Task<IEnumerable<MovieCastModel>> GetAllByMovieIdAsync(int movieId)
        {
            var result = await movieCastRepository.GetAllByMovieIdAsync(movieId);
            List<MovieCastModel> lstModel = new List<MovieCastModel>();
            foreach (var entity in result)
            {
                MovieCastModel model = new MovieCastModel();
                model.CastId = entity.CastId;
                model.Id = entity.Id;
                model.Cast = new CastModel()
                {
                    Id = entity.Cast.Id,
                    Gender = entity.Cast.Gender,
                    Name = entity.Cast.Name,
                    ProfilePath = entity.Cast.ProfilePath,
                    TmdbUrl = entity.Cast.TmdbUrl
                };
                lstModel.Add(model);
            }
            return lstModel;
        }
    }
}
