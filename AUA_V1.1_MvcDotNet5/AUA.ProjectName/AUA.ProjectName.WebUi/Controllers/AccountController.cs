using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.Models.DataModels.General;
using AUA.ProjectName.Models.DataModels.LoginDataModels;
using AUA.ProjectName.Models.DataModels.LoginDataModels.Shop;
using AUA.ProjectName.Models.GeneralModels.LoginModels;
using AUA.ProjectName.Models.GeneralModels.LoginModels.Shop;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Models.ListModes.Shop.UserModel;
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserModels;
using AUA.ProjectName.Models.ViewModels.Shop.UserModel;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Sop.Contracts;
using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ProjectName.Services.ListService.Shop.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.LoginModelValidations.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.LoginModelValidations.Shop.Contracts;
using AUA.ProjectName.ValidationServices.Shop.User.Contracts;
using AUA.ProjectName.WebUI.Areas.Accounting.Controllers;
using AUA.ProjectName.WebUI.Services;
using AUA.ProjectName.WebUI.Utility.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;



namespace AUA.ProjectName.WebUI.Controllers
{

    public class AccountController : BaseController
    {

        private readonly IUserDtoInsertValidationService _appUserDtoInsertValidationService;
        private readonly IUserService _appUserService;
        private readonly IUserListService _appUserListService;
        private readonly IBasketService _basketService;

        private readonly ILoginVmShopValidationService _loginVmValidationService;
        private readonly ILoginServiceShop _loginService;
        private readonly ILogger<Areas.Accounting.Controllers.AccountController> _logger;

        public AccountController(IUserDtoInsertValidationService appUserDtoInsertValidationService, IUserService appUserService, IUserListService appUserListService, ILoginVmShopValidationService loginVmValidationService, ILoginServiceShop loginService, ILogger<Areas.Accounting.Controllers.AccountController> logger, IBasketService basketService)
        {
            _appUserDtoInsertValidationService = appUserDtoInsertValidationService;
            _appUserService = appUserService;
            _appUserListService = appUserListService;
            _loginVmValidationService = loginVmValidationService;
            _loginService = loginService;
            _logger = logger;
            _basketService = basketService;
        }
 

        public  IActionResult Register()
        {


            return View(new UserActionVm());
        }

   

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> RegisterAsync(UserActionVm actionVm)
        {
            await AppUserDtoInsertValidationAsync(actionVm);

            if (HasError)
            {
                ErrorMessage("USer or password is invalid");
                return RedirectToAction("Index", "Home");
            }

            await _appUserService.InsertAsync(actionVm.UserDto);

            SuccessMessage("Insert user is success");

            return RedirectToAction("Login");
        }

        private async Task AppUserDtoInsertValidationAsync(UserActionVm actionVm)
        {
            actionVm.UserDto.CreatorUserId = CurrentUserId;

            var validationResultVm = await _appUserDtoInsertValidationService
                .ValidationAsync(actionVm);

            AddErrors(validationResultVm);
        }

   
        public IActionResult Login()
        {

            return View(new LoginShopVm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(LoginShopVm loginVm)
        {
            ValidationLoginVm(loginVm);

            if (HasError)
                return View(loginVm);

            var loginDm = await DoLoginAsync(loginVm);

            if (!loginDm.IsAuthenticated)
                AddError(loginDm.ResultStatus);

            Log(loginDm, loginVm.UserName);

            if (HasError)
                return View(loginVm);

            var resultVm = await CreateLoginResultVmAsync(loginDm);

            await UserLoginSuccessAsync(resultVm, loginVm.RememberMe);
            
            return RedirectToAction("ShowCard", "Account", new { area = "" });
        }

        private void ValidationLoginVm(LoginShopVm loginVm)
        {
            var resultVm = _loginVmValidationService.Validation(loginVm);

            AddErrors(resultVm);
        }

        private void Log(LoginDmShop loginDm, string userName)
        {
            var logMessage = CreateLogMessage(loginDm.ResultStatus.ToDescription(),
                                              loginDm.ObjectSerialize(),
                                              userName);

            _logger.LogInformation(logMessage);

        }

        private async Task<LoginDmShop> DoLoginAsync(LoginShopVm loginVm)
        {
            return await _loginService.LoginAsync(loginVm);
        }


        private async Task<UserLoggedInVm> CreateLoginResultVmAsync(LoginDmShop loginDm)
        {
        

            return new UserLoggedInVm
            {
                UserId = loginDm.UserId,
                UserName = loginDm.UserName,
                FirstName = loginDm.FirstName,
                LastName = loginDm.LastName,
              
            };
        }
   

        private async Task UserLoginSuccessAsync(UserLoggedInVm userLoggedInVm, bool rememberMe)
        {
            await SecurityHelper
                  .UserLoginSuccessAsync(HttpContext, userLoggedInVm, rememberMe);

        }
        public IActionResult ShowCard()
        {
            var model = _basketService.GetUserOrder();
            return View(model);

        }

     
        public async Task<IActionResult> LogoutAsync()
        {
            await SecurityHelper
                          .LogoffAsync(HttpContext);

            return RedirectToAction("Index","Home");
        }
    }
}

