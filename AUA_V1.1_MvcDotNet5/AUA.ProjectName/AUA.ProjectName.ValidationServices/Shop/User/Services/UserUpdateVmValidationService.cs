using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserModels;
using AUA.ProjectName.Models.ViewModels.Shop.UserModel;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Contracts;
using AUA.ProjectName.ValidationServices.BaseValidations;
using AUA.ProjectName.ValidationServices.Shop.User.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.ValidationServices.Shop.User.Services
{
    public class UserUpdateVmValidationService : BaseValidationService, IUserUpdateVmValidationService
    {
        private UserActionVm _appUserActionVm;
        private readonly IUserService _appUserService;

        public UserUpdateVmValidationService(IUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public async Task<ValidationResultVm> ValidationAsync(UserActionVm appUserVm)
        {
            _appUserActionVm = appUserVm;

            await DoValidationAsync();

            return ValidationResultVm;
        }

        private async Task DoValidationAsync()
        {
            FixValues();

            DefaultValidation();

            if (HasError) return;

            ValueValidation();

            if (HasError) return;

            SecurityValidation();

            if (HasError) return;

            await ValidationUserIdAsync();

            if (HasError) return;

            await ValidationUserNameAsync();
        }


        private void FixValues()
        {
            if (!IsEmpty(_appUserActionVm.UserDto.Phone) && _appUserActionVm.UserDto.Phone.Length == 10)
                _appUserActionVm.UserDto.Phone = "0" + _appUserActionVm.UserDto.Phone;
        }

        private void DefaultValidation()
        {
            if (IsEmpty(_appUserActionVm.UserDto.Id))
                AddError("Id", "Id is empty");

            if (IsEmpty(_appUserActionVm.UserDto.UserName))
                AddError("UserName", "UserName is empty");

            if (IsEmpty(_appUserActionVm.UserDto.FirstName))
                AddError("FirstName", "FirstName is empty");

            if (IsEmpty(_appUserActionVm.UserDto.LastName))
                AddError("LastName", "LastName is empty");

            if (IsEmpty(_appUserActionVm.UserDto.Email))
                AddError("Email", "Email is empty");

            if (IsEmpty(_appUserActionVm.UserDto.Phone))
                AddError("Phone", "Phone is empty");

            if (!IsPhoneNumber(_appUserActionVm.UserDto.Phone))
                AddError("Phone", "Phone is not valid");

        }

        private void ValueValidation()
        {
            if (_appUserActionVm.UserDto.UserName.Length > LengthConsts.MaxStringLen50)
                AddError("UserName", "UserName length is longer than allowed");

        }

        private void SecurityValidation()
        {
            if (HasDangerCharacters(_appUserActionVm.UserDto.UserName))
                AddError("UserName", "Username contains unauthorized characters");


        }

        private async Task ValidationUserIdAsync()
        {
            var userId = await GetAppUserIdAsync();

            if (userId is null)
                AddError("Id", "User not find");

        }

        private async Task<long?> GetAppUserIdAsync()
        {
            return await _appUserService
                                .GetAll()
                                .AsNoTracking()
                                .Where(p => p.Id == _appUserActionVm.UserDto.Id)
                                .Select(p => p.Id)
                                .FirstOrDefaultAsync();

        }
        private async Task ValidationUserNameAsync()
        {
            var userIds = await GetUserNameAsync();

            if (userIds.Any())
                AddError("Id", "UserName is exists");

        }

        private async Task<List<int>> GetUserNameAsync()
        {
            return await _appUserService
                .GetAll()
                .AsNoTracking()
                .Where(p => p.Id != _appUserActionVm.UserDto.Id &&
                            p.UserName == _appUserActionVm.UserDto.UserName)
                .Select(p => p.Id)
                .ToListAsync();

        }

    }
}
