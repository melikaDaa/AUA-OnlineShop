using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;
using AUA.ProjectName.Models.ViewModels.Shop.CategoryModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.Shop.Category.Contracts;
using AUA.ProjectName.WebUI.Controllers;
using AUA.ProjectName.WebUI.Utility.Authorizations;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.WebUI.Areas.Shop.Controllers
{
    [Area(AreasConsts.Shop)]
    [WebAuthorize(EUserAccess.AppUser)]

    public class CategoryController : BaseController
    {
        private readonly ICategoryInsertValidationService _categoryInsertValidationService;
        private readonly ICategoryUpdateValidationService _categoryUpdateValidationService;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryInsertValidationService categoryInsertValidationService, ICategoryUpdateValidationService categoryUpdateValidationService, ICategoryService categoryService)
        {
            _categoryInsertValidationService = categoryInsertValidationService;
            _categoryUpdateValidationService = categoryUpdateValidationService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var categoryDto = await GetCategoryDtosAsync();

            return View(categoryDto);
        }

        private async Task<IEnumerable<CategoryDto>> GetCategoryDtosAsync()
        {
            return await _categoryService
                             .GetAllDto()
                             .AsNoTracking()
                             .ToListAsync();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _InsertAsync(CategoryDto categoryDto)
        {
            await AppUserDtoInsertValidationAsync(categoryDto);

            if (HasError)
                return RedirectToAction("Index");

            await _categoryService.InsertAsync(categoryDto);

            SuccessMessage("دسته بندی با موفقیت ثبت گردید");

            return RedirectToAction("Index");
        }

        private async Task AppUserDtoInsertValidationAsync(CategoryDto categoryDto)
        {
            var validationResultVm = await _categoryInsertValidationService
                                                           .ValidationAsync(categoryDto);

            AddErrors(validationResultVm);
        }

        public async Task<IActionResult> _UpdateAsync(int id)
        {
            var model = await _categoryService.GetDtoByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Update(CategoryDto categoryDto)
        {

            await ValidationUpdateVmAsync(categoryDto);

            if (HasError)
                return RedirectToAction("Index");

            await _categoryService.UpdateAsync(categoryDto);

            return RedirectToAction("Index");
        }

        private async Task ValidationUpdateVmAsync(CategoryDto categoryDto)
        {
            var validationResultVm = await _categoryUpdateValidationService
                                                           .ValidationAsync(categoryDto);
            AddErrors(validationResultVm);
        }

        public async Task<bool> _Delete(int id)
        {
            var hasDeleted = await _categoryService.TryDeleteAsync(id);

            return hasDeleted;
        }
    }
}
