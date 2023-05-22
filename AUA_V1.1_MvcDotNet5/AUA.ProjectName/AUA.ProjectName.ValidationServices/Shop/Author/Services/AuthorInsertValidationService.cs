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
   public class AuthorInsertValidationService:BaseValidationService,IAuthorInsertValidationService
   {
       private AuthorDto _AuthorInsertDto;
       private readonly IAuthorService _authorService;

       public AuthorInsertValidationService(IAuthorService authorService)
       {
           _authorService = authorService;
       }
       public async Task<ValidationResultVm> ValidationAsync(AuthorDto authorDto)
       {
           _AuthorInsertDto = authorDto;

           await DoValidationAsync();

           return ValidationResultVm;
       }

       private async Task DoValidationAsync()
       {
           DefaultValidation();

           if (HasError) return;

           await ValidationNameAsync();

       }

       private void DefaultValidation()
       {
           if (IsEmpty(_AuthorInsertDto.AuthorName))
               AddError("Name", "Name is empty");



       }


       private async Task ValidationNameAsync()
       {
           var isExistsAccessCode = await IsExistsAuthorTitleAsync();

           if (isExistsAccessCode)
               AddError("Name", "Name is a duplicate");

       }

       private async Task<bool> IsExistsAuthorTitleAsync()
       {
           return await _authorService
               .GetAll()
               .AsNoTracking()
               .AnyAsync(p => p.AuthorName == _AuthorInsertDto.AuthorName);

       }
    }
}
