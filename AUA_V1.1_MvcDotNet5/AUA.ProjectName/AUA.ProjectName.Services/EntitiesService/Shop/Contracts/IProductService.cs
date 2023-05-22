using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Shop.ProductModels;
using AUA.ServiceInfrastructure.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUA.ProjectName.Services.EntitiesService.Shop.Contracts
{
   public interface IProductService: IGenericEntityService<Product, ProductDto>
    {
        IEnumerable<ProductVm> GetUProductVmsAsync();
    }
}
