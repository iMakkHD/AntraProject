using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Service
{
    public class CastServiceAsync : ICastServiceAsync
    {
        ICastRepositoryAsync castRepositoryAsync;
        public CastServiceAsync(ICastRepositoryAsync _castRepositoryAsync)
        {
            castRepositoryAsync = _castRepositoryAsync;
        }

        public async Task<int> AddCastAsync(CastModel model)
        {
            Cast c = new Cast();
            c.Name = model.Name;
            c.TmdbUrl = model.TmdbUrl;
            c.ProfilePath = model.ProfilePath;
            c.Gender = model.Gender;
            return await castRepositoryAsync.InsertAsync(c);
        }
    }
}