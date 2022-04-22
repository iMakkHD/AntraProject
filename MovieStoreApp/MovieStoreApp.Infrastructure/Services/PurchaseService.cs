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
    public class PurchaseService : IPurchaseServiceAsync
    {
        IPurchaseRepositoryAsync purchaseRepository;
        public PurchaseService(IPurchaseRepositoryAsync _movie)
        {
            purchaseRepository = _movie;
        }

        public async Task<IEnumerable<PurchaseModel>> GetAllPurchasesAsync()
        {
                var result = await purchaseRepository.GetAllAsync();
                List<PurchaseModel> lstModel = new List<PurchaseModel>();
                foreach (var entity in result)
                {
                    PurchaseModel model = new PurchaseModel();
                    model.Id = entity.Id;
                    model.UserId = entity.UserId;
                    model.PurchaseNumber = entity.PurchaseNumber;
                    model.PurchaseDateTime = entity.PurchaseDateTime;
                    model.TotalPrice = entity.TotalPrice;
                    model.MovieId = entity.MovieId;
                    lstModel.Add(model);
                }
                return lstModel;
        }

        public async Task<IEnumerable<PurchaseModel>> GetPurchaseByIdAsync(int id)
        {
            var entity = await purchaseRepository.GetAsync(id);
            List<PurchaseModel> lstModel = new List<PurchaseModel>();
            PurchaseModel model = new PurchaseModel();
            model.Id = entity.Id;
            model.UserId = entity.UserId;
            model.PurchaseNumber = entity.PurchaseNumber;
            model.PurchaseDateTime = entity.PurchaseDateTime;
            model.TotalPrice = entity.TotalPrice;
            model.MovieId = entity.MovieId;
            lstModel.Add(model);
            return lstModel;
        }
    }
}
