using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.DataModels.Accounting.AppUserDataModels;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.User.Contracts;

namespace AUA.ProjectName.ValidationServices.Shop.User.Services
{
    public class UserDeleteValidationService : BaseValidationService, IUserDeleteValidationService
    {
        private long _userId;
        private readonly IUserService _appUserService;

        public UserDeleteValidationService(IUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public async Task<ValidationResultVm> ValidationAsync(long userId)
        {
            _userId = userId;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {
            DefaultValidation();

            if (HasError) return;

            

            if (HasError) return;


        }

        private void DefaultValidation()
        {
            if (IsEmpty(_userId))
                AddError("UserId", "UserId is empty");

        }


        

    }
}
