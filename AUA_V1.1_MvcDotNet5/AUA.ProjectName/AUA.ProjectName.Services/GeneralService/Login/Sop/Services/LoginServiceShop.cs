using System.Threading.Tasks;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Common.Tools.Security;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.DataModels.LoginDataModels;
using AUA.ProjectName.Models.DataModels.LoginDataModels.Shop;
using AUA.ProjectName.Models.GeneralModels.LoginModels;
using AUA.ProjectName.Models.GeneralModels.LoginModels.Shop;
using AUA.ProjectName.Services.BaseService.Services;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Sop.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Services.GeneralService.Login.Sop.Services
{
    public class LoginServiceShop : BaseBusinessService, ILoginServiceShop
    {
        private readonly IUserService _userService;

        public LoginServiceShop(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<LoginDmShop> LoginAsync(LoginShopVm loginVm)
        {
            var appUser = await GetUserByUserNameAsync(loginVm.UserName);

            if (appUser is null)
                return CreateInvalidResult(EResultStatus.InValidUserNameOrPassword);
            

            return IsValidatePassword(appUser.Password, loginVm.Password) ?
                   CreateSuccessResult(appUser) :
                   CreateInvalidResult(EResultStatus.InValidUserNameOrPassword);
        }

        private static LoginDmShop CreateSuccessResult(Users User)
        {
            return new LoginDmShop
            {
                ResultStatus = EResultStatus.Success,
                IsAuthenticated = true,
                UserId = User.Id,
                FirstName = User.FirstName,
                LastName = User.LastName,
                UserName = User.UserName
            };
        }

        private static bool IsValidatePassword(string password, string userPassword)
        {
            return password == EncryptionHelper.GetSha512Hash(userPassword);
        }

        private async Task<Users> GetUserByUserNameAsync(string userName)
        {
            return await _userService
                             .GetAll()
                             .FirstOrDefaultAsync(p => p.UserName == userName);
        }

        private static LoginDmShop CreateInvalidResult(EResultStatus eResultStatus)
        {
            return new LoginDmShop
            {
                IsAuthenticated = false,
                ResultStatus = eResultStatus
            };
        }

     
    }
}
