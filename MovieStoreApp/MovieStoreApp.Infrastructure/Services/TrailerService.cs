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
    public class TrailerServiceAsync : ITrailerServiceAsync
    {
        ITrailerRepositoryAsync trailerRepository;
        public TrailerServiceAsync(ITrailerRepositoryAsync _movie)
        {
            trailerRepository = _movie;
        }

        public async Task<IEnumerable<TrailerModel>> GetTrailerByMovieIdAsync(int id)
        {
            var result = await trailerRepository.TrailerByMovieIdAsync(id);
            List<TrailerModel> lstModel = new List<TrailerModel>();
            foreach (var entity in result)
            {
                TrailerModel model = new TrailerModel();
                model.Id = entity.Id;
                model.MovieId = entity.MovieId;
                model.TrailerUrl = entity.TrailerUrl;
                model.Name = entity.Name;
                lstModel.Add(model);
            }
            return lstModel;
        }
    }
}
