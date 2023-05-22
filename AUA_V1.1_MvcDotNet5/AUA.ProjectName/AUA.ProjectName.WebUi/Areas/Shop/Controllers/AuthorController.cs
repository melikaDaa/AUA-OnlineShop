using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.Shop.Author.Contracts;
using AUA.ProjectName.ValidationServices.Shop.Category.Contracts;
using AUA.ProjectName.WebUI.Controllers;
using AUA.ProjectName.WebUI.Utility.Authorizations;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.WebUI.Areas.Shop.Controllers
{

    [Area(AreasConsts.Shop)]
    [WebAuthorize(EUserAccess.AppUser)]
    public class AuthorController :  BaseController
    {

        private readonly IAuthorInsertValidationService _authorInsertValidationService;
        private readonly IAuthorUpdateValidationService _authorUpdateValidationService;
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorInsertValidationService authorInsertValidationService, IAuthorUpdateValidationService authorUpdateValidationService, IAuthorService authorService)
        {
            _authorInsertValidationService = authorInsertValidationService;
            _authorUpdateValidationService = authorUpdateValidationService;
            _authorService = authorService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var authorDto = await GetAuthorDtosAsync();

            return View(authorDto);
        }

        private async Task<IEnumerable<AuthorDto>> GetAuthorDtosAsync()
        {
            return await _authorService
                             .GetAllDto()
                             .AsNoTracking()
                             .ToListAsync();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _InsertAsync(AuthorDto authorDto)
        {
            await AppUserDtoInsertValidationAsync(authorDto);

            if (HasError)
                return RedirectToAction("Index");

            await _authorService.InsertAsync(authorDto);

            SuccessMessage("نام نویسنده با موفقیت ثبت گردید");

            return RedirectToAction("Index");
        }

        private async Task AppUserDtoInsertValidationAsync(AuthorDto authorDto)
        {
            var validationResultVm = await _authorInsertValidationService
                                                           .ValidationAsync(authorDto);

            AddErrors(validationResultVm);
        }

        public async Task<IActionResult> _UpdateAsync(int id)
        {
            var model = await _authorService.GetDtoByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Update(AuthorDto authorDto)
        {

            await ValidationUpdateVmAsync(authorDto);

            if (HasError)
                return RedirectToAction("Index");

            await _authorService.UpdateAsync(authorDto);

            return RedirectToAction("Index");
        }

        private async Task ValidationUpdateVmAsync(AuthorDto authorDto)
        {
            var validationResultVm = await _authorUpdateValidationService
                                                           .ValidationAsync(authorDto);
            AddErrors(validationResultVm);
        }

        public async Task<bool> _Delete(int id)
        {
            var hasDeleted = await _authorService.TryDeleteAsync(id);

            return hasDeleted;
        }
    }
}
