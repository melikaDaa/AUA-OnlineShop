using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Shop.AuthorModels;
using AUA.ProjectName.Models.ViewModels.Shop.ProductModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ServiceInfrastructure.BaseServices;
using AutoMapper;

namespace AUA.ProjectName.Services.EntitiesService.Shop.Services
{
  public  class ProductService: GenericEntityService<Product,ProductDto>,IProductService

    {
        public ProductService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {
        }

        public IEnumerable<ProductVm> GetUProductVmsAsync()
        {
            var query = GetAll().Where(p => p.IsActive);

            return MapperInstance
                .ProjectTo<ProductVm>(query)
                .ToList();
        }
    }
}
