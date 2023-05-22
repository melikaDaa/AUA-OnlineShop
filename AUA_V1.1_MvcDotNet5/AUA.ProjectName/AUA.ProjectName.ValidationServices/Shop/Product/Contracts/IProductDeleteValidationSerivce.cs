using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;

namespace AUA.ProjectName.ValidationServices.Shop.Product.Contracts
{
   public interface IProductDeleteValidationSerivce
   {
       Task<ValidationResultVm> ValidationAsync(int productid);

   }
}
