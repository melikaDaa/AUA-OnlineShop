using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;
using AUA.ProjectName.Models.ViewModels.Shop.CategoryModels;

namespace AUA.ProjectName.ValidationServices.Shop.Category.Contracts
{
  public  interface ICategoryInsertValidationService
    {
        Task<ValidationResultVm> ValidationAsync(CategoryDto categoryDto);
    }
}
