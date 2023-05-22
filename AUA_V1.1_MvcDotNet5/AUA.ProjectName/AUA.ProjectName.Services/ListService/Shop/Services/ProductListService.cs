using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Models.ListModes.Shop.Products;
using AUA.ProjectName.Services.ListService.Shop.Contracts;
using AUA.ServiceInfrastructure.BaseSearchService;
using AutoMapper;

namespace AUA.ProjectName.Services.ListService.Shop.Services
{
   public class ProductListService:BaseListService<Product,ProductListDto,ProductSearchVm>,IProductListService
    {
        public ProductListService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {

        }
        public async Task<ListResultVm<ProductListDto>> ListAsync(ProductSearchVm productSearch)
        {
            SetSearchVm(productSearch);

            ApplyTitleFilter();
            ApplyPublisherFilter();
            ApplyAuthorFilter();


            return await CreateListVmResultAsync();
        }

        private void ApplyTitleFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.TitleProduct))
                return;

            Query = Query.Where(p => p.TitleProduct.Contains(SearchVm.TitleProduct));
        }

        private void ApplyPublisherFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.Publisher))
                return;

            Query = Query.Where(p => p.Publisher.Contains(SearchVm.Publisher));
        }

   

        private void ApplyAuthorFilter()
        {
            if (SearchVm.Authorid==0)
                return;

            Query = Query.Where(p => p.Authorid == SearchVm.Authorid);
        }
    }
}
