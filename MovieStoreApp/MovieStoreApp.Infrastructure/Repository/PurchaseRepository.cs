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
    public class PurchaseRepositoryAsync : BaseRepositoryAsync<Purchase>, IPurchaseRepositoryAsync
    {
        MovieContext context;
        public PurchaseRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<Purchase>> GetPurchaseByNumberAsync(int purchaseNumber)
        {
            return await context.Purchase.Where(x => x.PurchaseNumber == purchaseNumber).ToListAsync();
        }
    }
}
