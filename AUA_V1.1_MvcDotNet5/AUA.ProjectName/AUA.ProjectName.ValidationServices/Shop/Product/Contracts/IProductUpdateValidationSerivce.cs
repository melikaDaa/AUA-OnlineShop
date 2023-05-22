using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.ViewModels.Shop.ProductModels;

namespace AUA.ProjectName.ValidationServices.Shop.Product.Contracts
{
    public interface IProductUpdateValidationSerivce
    {
        Task<ValidationResultVm> ValidationAsync(ProductActionVm areaInsertVm);
    }
}
