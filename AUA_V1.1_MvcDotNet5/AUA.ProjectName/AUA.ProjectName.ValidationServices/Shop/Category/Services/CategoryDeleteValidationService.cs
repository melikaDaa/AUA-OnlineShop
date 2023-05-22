using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Category.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.Category.Services
{
    public class CategoryDeleteValidationService: BaseValidationService,ICategoryDeleteValidationService
    {
        private int _Categoryid;
        private readonly ICategoryService _categoryService;

        public CategoryDeleteValidationService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<ValidationResultVm> ValidationAsync(int Categoryid)
        {
            _Categoryid = Categoryid;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {
            DefaultValidation();

            if (HasError) return;

            await ValidationCategoryIdAsync();

        }

        private void DefaultValidation()
        {
            if (IsEmpty(_Categoryid))
                AddError("Code", "Code is empty");

        }

        private async Task ValidationCategoryIdAsync()
        {
            var role = await _categoryService.GetByIdAsync(_Categoryid);

            if (role is null)
                AddError("Id", "Id is empty");

        }

        //private async Task ValidationRelationRoleAsync()
        //{
        //    var role = await _categoryService
        //        .GetAllDto()
        //        .FirstOrDefaultAsync(x => x.Categoryid ==_Categoryid);

        //    if (role != null)
        //        AddError("RoleId", "This role has relation");

        //}
    }
}
