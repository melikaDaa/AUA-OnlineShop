using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.Accounting.UserRoleModels;
using AUA.ProjectName.Models.ListModes.Shop.Products;
using AUA.ServiceInfrastructure.BaseSearchService;

namespace AUA.ProjectName.Services.ListService.Shop.Contracts
{
   public interface IProductListService:IBaseListService<Product, ProductListDto>
   {

       Task<ListResultVm<ProductListDto>> ListAsync(ProductSearchVm productSearchVm);

    
    }
}
