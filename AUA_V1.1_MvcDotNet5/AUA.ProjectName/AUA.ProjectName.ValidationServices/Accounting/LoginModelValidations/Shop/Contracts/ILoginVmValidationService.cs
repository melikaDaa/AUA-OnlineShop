using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.GeneralModels.LoginModels.Shop;

namespace AUA.ProjectName.ValidationServices.Accounting.LoginModelValidations.Shop.Contracts
{
    public interface ILoginVmShopValidationService
    {

        ValidationResultVm Validation(LoginShopVm loginVm);


    }
}
