using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.ViewModels.Shop.ProductModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Product.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.Product.Services
{
   public class ProductUpdateValidationSerivce: BaseValidationService,IProductUpdateValidationSerivce
    {
        private ProductActionVm _productActionVm;
        private readonly IProductService _productService;

        public ProductUpdateValidationSerivce(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<ValidationResultVm> ValidationAsync(ProductActionVm areaInsertVm)
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

            if (IsEmpty(_productActionVm.ProductDtos.TitleProduct))
                AddError("نام محصول ", "نام محصول خالی است");
            if (_productActionVm.ProductDtos.PriceProduct == 0)
                AddError("قیمت محصول", " قیمت محصول خالی است");
            if (_productActionVm.ProductDtos.CountProduct == 0)
                AddError("تعداد ", "تعداد محصول خالی است");
            if (IsEmpty(_productActionVm.ProductDtos.NumberOfPages))
                AddError("تعداد صفحات ", "تعداد صفحات خالی است");
            if (IsEmpty(_productActionVm.ProductDtos.PublishYear))
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
                              .AnyAsync(p => p.TitleProduct == _productActionVm.ProductDtos.TitleProduct);

        }
    }
}
