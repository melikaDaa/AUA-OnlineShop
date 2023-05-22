using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Author.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.Author.Services
{
    public class AuthorUpdateValidationService:BaseValidationService,IAuthorUpdateValidationService
    {
        private AuthorDto _AuthorUpdateDto;
        private readonly IAuthorService _authorService;

        public AuthorUpdateValidationService(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        public async Task<ValidationResultVm> ValidationAsync(AuthorDto AuthorUpdateVm)
        {
            _AuthorUpdateDto = AuthorUpdateVm;

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
            if (IsEmpty(_AuthorUpdateDto.AuthorName))
                AddError("Name", "Name is empty");

        }

        private async Task ValidationTitleAsync()
        {
            var isExists = await IsExistsAuthorTitleAsync();

            if (isExists)
                AddError("Name", "Name is exists");

        }

        private async Task<bool> IsExistsAuthorTitleAsync()
        {
            return await _authorService
                .GetAll()
                .AsNoTracking()
                .AnyAsync(p => p.AuthorName == _AuthorUpdateDto.AuthorName &&
                               p.Id != _AuthorUpdateDto.Id);


        }
    }
}
