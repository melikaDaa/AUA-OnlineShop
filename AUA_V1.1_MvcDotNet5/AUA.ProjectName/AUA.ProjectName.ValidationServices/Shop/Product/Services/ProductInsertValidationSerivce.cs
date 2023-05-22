using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Shop.ProductModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Services;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Product.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.ViewModels.Shop.AuthorModels;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.Product.Services
{
   public class ProductInsertValidationSerivce: BaseValidationService, IProductInsertValidationSerivce
    {
        private ProductDto _productActionVm;
        private readonly IProductService _productService;

        public ProductInsertValidationSerivce(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<ValidationResultVm> ValidationAsync(ProductDto areaInsertVm)
        {
            _productActionVm = areaInsertVm;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {

        
            if (HasError) return;

            await ValidationTitleAsync();

            if (HasError) return;
            DefaultValidation();


        }


        private void DefaultValidation()
        {

            if (IsEmpty(_productActionVm.TitleProduct))
                AddError("نام محصول ", "نام محصول خالی است");
            if (_productActionVm.PriceProduct==0)
                AddError("قیمت محصول", " قیمت محصول خالی است");
            if (_productActionVm.CountProduct == 0)
                AddError("تعداد ", "تعداد محصول خالی است");
            if (IsEmpty(_productActionVm.NumberOfPages))
                AddError("تعداد صفحات ", "تعداد صفحات خالی است");
            if (IsEmpty(_productActionVm.PublishYear))
                AddError("تعداد صفحات ", "تعداد صفحات خالی است");
        }

        private async Task ValidationTitleAsync()
        {
            var isExistsRoleTitleAsync = await IsExistsProductTitleAsync();

            if (isExistsRoleTitleAsync)
                AddError("نام محصول", "نام محصول خالی است");

        }

        private async Task<bool> IsExistsProductTitleAsync()
        {
            return await _productService
                              .GetAll()
                              .AsNoTracking()
                              .AnyAsync(p => p.TitleProduct == _productActionVm.TitleProduct);

        }
      
    }
}
