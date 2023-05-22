using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Product.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.Product.Services
{
   public class ProductDeleteValidationSerivce: BaseValidationService,IProductDeleteValidationSerivce
    {
        private int _productid;
        private readonly IProductService _productService;

        public ProductDeleteValidationSerivce(IProductService productService)
        {
            _productService = productService;
       
        }

        public async Task<ValidationResultVm> ValidationAsync(int productid)
        {
            _productid = productid;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {
            DefaultValidation();

            if (HasError) return;

            await ValidationUserIdAsync();

        }

        private void DefaultValidation()
        {
            if (IsEmpty(_productid))
                AddError("Code", "Code is empty");

        }

        private async Task ValidationUserIdAsync()
        {
            var role = await _productService.GetByIdAsync(_productid);

            if (role is null)
                AddError("Id", "Id is empty");

        }

     

    }
}
