using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Infrastructure.Services
{
    public class GenreServiceAsync : IGenreServiceAsync
    {
        IGenreRepository genreRepositoryAsync;

        public GenreServiceAsync(IGenreRepository _genreRepositoryAsync)
        {
            genreRepositoryAsync = _genreRepositoryAsync;
        }
        public async Task<int> AddGenreAsync(GenreModel model)
        {
            Genre c = new Genre();
            c.Name = model.Name;
            return await genreRepositoryAsync.InsertAsync(c);
        }

        public async Task<IEnumerable<GenreModel>> GetAllGenreAsync()
        {
            var result = await genreRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                List<GenreModel> list = new List<GenreModel>();
                foreach (var item in result)
                {
                    GenreModel model = new GenreModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public async Task<GenreModel> GetGenreAsync(int id)
        {
            var item = await genreRepositoryAsync.GetAsync(id);
            if (item != null)
            {
                GenreModel model = new GenreModel();
                model.Id = item.Id;
                model.Name = item.Name;
                return model;
            }
            return null;
        }
    }
}
