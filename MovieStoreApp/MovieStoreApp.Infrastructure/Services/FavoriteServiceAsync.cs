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
    public class FavoriteServiceAsync: IFavoriteServiceAsync
    {
        IFavoriteRepository favoriteRepositoryAsync;

        public FavoriteServiceAsync(IFavoriteRepository _favoriteRepositoryAsync)
        {
            favoriteRepositoryAsync = _favoriteRepositoryAsync;
        }

        public async Task<IEnumerable<FavoriteModel>> GetAllFavoritesAsync()
        {
            var result = await favoriteRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                List<FavoriteModel> list = new List<FavoriteModel>();
                foreach (var item in result)
                {
                    FavoriteModel model = new FavoriteModel();
                    model.Id = item.Id;
                    model.UserId = item.UserId;
                    model.MovieId = item.MovieId;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }
    }
}
