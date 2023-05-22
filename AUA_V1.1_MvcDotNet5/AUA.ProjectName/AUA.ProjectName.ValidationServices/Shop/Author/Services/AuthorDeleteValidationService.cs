using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.Author.Contracts;

namespace AUA.ProjectName.ValidationServices.Shop.Author.Services
{
    public class AuthorDeleteValidationService:BaseValidationService,IAuthorDeleteValidationService
    {
        private int _Authorid;
        private readonly IAuthorService _authorService;

        public AuthorDeleteValidationService(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        public async Task<ValidationResultVm> ValidationAsync(int authorid)
        {
            _Authorid = authorid;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {
            DefaultValidation();

            if (HasError) return;

            await ValidationAuthorIdAsync();

        }

        private void DefaultValidation()
        {
            if (IsEmpty(_Authorid))
                AddError("Code", "Code is empty");

        }

        private async Task ValidationAuthorIdAsync()
        {
            var role = await _authorService.GetByIdAsync(_Authorid);

            if (role is null)
                AddError("Id", "Id is empty");

        }
    }
}
