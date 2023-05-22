using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Services;
using AUA.ProjectName.ValidationServices.Accounting.LoginModelValidations.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.LoginModelValidations.Services;
using AUA.ProjectName.ValidationServices.Accounting.LoginModelValidations.Shop.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.LoginModelValidations.Shop.Services;
using AUA.ProjectName.ValidationServices.Accounting.RoleValidation.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.RoleValidation.Services;
using AUA.ProjectName.ValidationServices.Accounting.UserAccessValidations.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.UserAccessValidations.Services;
using AUA.ProjectName.ValidationServices.Accounting.UserRole.Contracts;
using AUA.ProjectName.ValidationServices.Accounting.UserRole.Services;
using AUA.ProjectName.ValidationServices.Shop.Author.Contracts;
using AUA.ProjectName.ValidationServices.Shop.Author.Services;
using AUA.ProjectName.ValidationServices.Shop.Category.Contracts;
using AUA.ProjectName.ValidationServices.Shop.Category.Services;
using AUA.ProjectName.ValidationServices.Shop.Product.Contracts;
using AUA.ProjectName.ValidationServices.Shop.Product.Services;
using AUA.ProjectName.ValidationServices.Shop.User.Contracts;
using AUA.ProjectName.ValidationServices.Shop.User.Services;
using Microsoft.Extensions.DependencyInjection;
using ChangePasswordValidationService = AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Services.ChangePasswordValidationService;
using IChangePasswordValidationService = AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Contracts.IChangePasswordValidationService;
using IUserIdValidationService = AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Contracts.IUserIdValidationService;
using UserIdValidationService = AUA.ProjectName.ValidationServices.Accounting.AppUserValidations.Services.UserIdValidationService;

namespace AUA.ProjectName.WebUi.RegistrationServices
{
    public static class ValidationService
    {
        public static void RegistrationValidationService(this IServiceCollection services)
        {
            services.AccountingValidationService();
            services.ShopValidationService();
        }

        private static void AccountingValidationService(this IServiceCollection services)
        {
            services.AddScoped<ILoginVmValidationService, LoginVmValidationService>();

            services.AddScoped<IAppUserDtoInsertValidationService, AppUserDtoInsertValidationService>();
            services.AddScoped<IAppUserUpdateVmValidationService, AppUserUpdateVmValidationService>();
            services.AddScoped<IAppUserDeleteValidationService, AppUserDeleteValidationService>();

            services.AddScoped<IChangePasswordValidationService, ChangePasswordValidationService>();
            services.AddScoped<IUserIdValidationService, UserIdValidationService>();
            services.AddScoped<IRoleInsertValidationService, RoleInsertValidationService>();
            services.AddScoped<IRoleUpdateValidationService, RoleUpdateValidationService>();
            services.AddScoped<IRoleDeleteValidationService, RoleDeleteValidationService>();

            services.AddScoped<IUserRoleInsertValidationService, UserRoleInsertValidationService>();

            services.AddScoped<IUserAccessDtoInsertValidationService, UserAccessDtoInsertValidationService>();
            services.AddScoped<IUserAccessDtoUpdateValidationService, UserAccessDtoUpdateValidationService>();



        }

        private static void ShopValidationService(this IServiceCollection services)
        {
            services.AddScoped<ILoginVmShopValidationService,LoginVmShopValidationService>();

            services.AddScoped<ICategoryInsertValidationService,CategoryInsertValidationService>();
            services.AddScoped<ICategoryUpdateValidationService, CategoryUpdateValidationService>();
            services.AddScoped<ICategoryDeleteValidationService, CategoryDeleteValidationService>();

            services.AddScoped<IAuthorInsertValidationService, AuthorInsertValidationService>();
            services.AddScoped<IAuthorUpdateValidationService,AuthorUpdateValidationService>();
            services.AddScoped<IAuthorDeleteValidationService,AuthorDeleteValidationService>();

            services.AddScoped<IProductInsertValidationSerivce, ProductInsertValidationSerivce>();
            services.AddScoped<IProductUpdateValidationSerivce, ProductUpdateValidationSerivce>();
            services.AddScoped<IProductDeleteValidationSerivce, ProductDeleteValidationSerivce>();


            services.AddScoped<IUserDtoInsertValidationService, UserDtoInsertValidationService>();
            services.AddScoped<IUserUpdateVmValidationService, UserUpdateVmValidationService>();
            services.AddScoped<IUserDeleteValidationService, UserDeleteValidationService>();

            services.AddScoped<IChangePasswordValidationService, ChangePasswordValidationService>();
            services.AddScoped<IUserIdValidationService, UserIdValidationService>();
        }


    }

}
