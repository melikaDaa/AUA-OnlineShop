using System.Collections.Generic;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Tools.Security;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
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
    public class UserDtoInsertValidationService : BaseValidationService, IUserDtoInsertValidationService
    {
        private UserActionVm _appUserActionVm;
        private readonly IUserService _appUserService;


        public UserDtoInsertValidationService(IUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public async Task<ValidationResultVm> ValidationAsync(UserActionVm appUserInsertVm)
        {
            _appUserActionVm = appUserInsertVm;

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

            await ValidationUserNameAsync();

            if (HasError) return;

            SetHashPasswordValue();

        }

        private void FixValues()
        {

            if (_appUserActionVm.UserDto.Phone != null && _appUserActionVm.UserDto.Phone.Length == 10)
                _appUserActionVm.UserDto.Phone = "0" + _appUserActionVm.UserDto.Phone;

        }

        private void DefaultValidation()
        {

            if (IsEmpty(_appUserActionVm.UserDto.UserName))
                AddError("UserName", "UserName is empty");

            if (IsEmpty(_appUserActionVm.UserDto.Password))
                AddError("Password", "Password is empty");

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

            if (_appUserActionVm.UserDto.Password.Length > LengthConsts.MaxStringLen50)
                AddError("Password", "Password length is longer than allowed");

        }

        private void SecurityValidation()
        {
            if (HasDangerCharacters(_appUserActionVm.UserDto.UserName))
                AddError("UserName", "Username contains unauthorized characters");


            if (HasDangerCharacters(_appUserActionVm.UserDto.Password))
                AddError("Password", "Password contains unauthorized characters ");

        }

        private void SetHashPasswordValue()
        {
            if (string.IsNullOrWhiteSpace(_appUserActionVm.UserDto.Password))
                return;

            _appUserActionVm.UserDto.Password = EncryptionHelper.GetSha512Hash(_appUserActionVm.UserDto.Password);
        }

        private async Task ValidationUserNameAsync()
        {
            var isExistUserNames = await IsExistUserNamesAsync();

            if (isExistUserNames)
                AddError("UserName", "Username is a duplicate");

        }

        private async Task<bool> IsExistUserNamesAsync()
        {
            return await _appUserService.GetAll()
                                        .AsNoTracking()
                                        .AnyAsync(p => p.UserName == _appUserActionVm.UserDto.UserName);

        }

 
     
    }
}
