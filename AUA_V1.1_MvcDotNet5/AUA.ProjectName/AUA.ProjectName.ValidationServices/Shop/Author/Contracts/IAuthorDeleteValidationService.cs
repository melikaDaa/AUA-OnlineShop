using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;

namespace AUA.ProjectName.ValidationServices.Shop.Author.Contracts
{
   public interface IAuthorDeleteValidationService
    {
        Task<ValidationResultVm> ValidationAsync(int authorid);
    }
}
