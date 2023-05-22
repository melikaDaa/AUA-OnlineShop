using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;
using AUA.ProjectName.Models.ViewModels.Shop.CategoryModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Services;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Category.Contracts;
using AUA.ServiceInfrastructure.BaseServices;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.Category.Services
{
public class CategoryInsertValidationService : BaseValidationService, ICategoryInsertValidationService
    {
        private CategoryDto _categoryInsertVm;

        private readonly ICategoryService _CategoryService;

        public CategoryInsertValidationService( ICategoryService categoryService)
        {
            _CategoryService = categoryService;
        }

        public async Task<ValidationResultVm> ValidationAsync(CategoryDto categoryDto)
        {
            _categoryInsertVm = categoryDto;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {
            DefaultValidation();

            if (HasError) return;

            await ValidationAccessCodeAsync();

        }

        private void DefaultValidation()
        {
            if (IsEmpty(_categoryInsertVm.CategoryTitle))
                AddError("PageTitle", "PageTitle is empty");



        }


        private async Task ValidationAccessCodeAsync()
        {
            var isExistsAccessCode = await IsExistsCategoryTitleAsync();

            if (isExistsAccessCode)
                AddError("Title", "Title is a duplicate");

        }

        private async Task<bool> IsExistsCategoryTitleAsync()
        {
            return await _CategoryService
                .GetAll()
                .AsNoTracking()
                .AnyAsync(p => p.CategoryTitle == _categoryInsertVm.CategoryTitle);

        }

    }
}
