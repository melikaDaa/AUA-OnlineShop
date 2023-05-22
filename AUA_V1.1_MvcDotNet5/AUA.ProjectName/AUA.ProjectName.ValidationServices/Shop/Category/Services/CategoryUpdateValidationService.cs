using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;
using AUA.ProjectName.Models.ViewModels.Shop.CategoryModels;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Category.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.Category.Services
{
  public  class CategoryUpdateValidationService:BaseValidationService,ICategoryUpdateValidationService
    {
        private CategoryDto _categoryActionVm;
        private readonly ICategoryService _categoryService;

        public CategoryUpdateValidationService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<ValidationResultVm> ValidationAsync(CategoryDto categoryupdatevm)
        {
            _categoryActionVm = categoryupdatevm;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {

            DefaultValidation();

            if (HasError) return;

            await ValidationTitleAsync();

        }

        private void DefaultValidation()
        {
            if (IsEmpty(_categoryActionVm.CategoryTitle))
                AddError("Title", "Title is empty");

        }

        private async Task ValidationTitleAsync()
        {
            var isExists = await IsExistsCategoryTitleAsync();

            if (isExists)
                AddError("Title", "Title is exists");

        }

        private async Task<bool> IsExistsCategoryTitleAsync()
        {
            return await _categoryService
                .GetAll()
                .AsNoTracking()
                .AnyAsync(p => p.CategoryTitle == _categoryActionVm.CategoryTitle &&
                               p.Id != _categoryActionVm.Id);


        }
    }
}
