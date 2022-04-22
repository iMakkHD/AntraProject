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
    public class MovieGenreServiceAsync : IMovieGenreServiceAsync
    {
        IMovieGenreRepositoryAsync movieGenreRepository;
        public MovieGenreServiceAsync(IMovieGenreRepositoryAsync _movie)
        {
            movieGenreRepository = _movie;
        }

        public async Task<IEnumerable<MovieGenreModel>> GetAllGenresAsync()
        {
            var result = await movieGenreRepository.GetAllAsync();
            List<MovieGenreModel> lstModel = new List<MovieGenreModel>();
            foreach (var entity in result)
            {
                MovieGenreModel model = new MovieGenreModel();
                model.MovieId = entity.MovieId;
                model.GenreId = entity.GenreId;
                lstModel.Add(model);
            }
            return lstModel;
        }
    }
}
