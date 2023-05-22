using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.Shop;

namespace AUA.ProjectName.ValidationServices.Shop.Author.Contracts
{
    public interface IAuthorInsertValidationService
    {
        Task<ValidationResultVm> ValidationAsync(AuthorDto authorDto);
    }
}
