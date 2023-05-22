using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Accounting.Services;
using AUA.ProjectName.Services.EntitiesService.School.Contract;
using AUA.ProjectName.Services.EntitiesService.School.Services;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Services;
using AUA.ProjectName.WebUI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AUA.ProjectName.WebUi.RegistrationServices
{
    public static class EntitiesService
    {

        public static void RegistrationEntitiesService(this IServiceCollection services)
        {
            services.RegistrationBaseService();

            services.RegistrationAccountingService();
            services.RegistrationSchoolService();
            services.RegistrationShopService();
            services.RegistrationBaseInformationService();

        }

        private static void RegistrationBaseService(this IServiceCollection services)
        {
            services.AddDbContext<IUnitOfWork, ApplicationEfContext>();
        }

        private static void RegistrationAccountingService(this IServiceCollection services)
        {
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IUserAccessService, UserAccessService>();
            services.AddScoped<IUserRoleAccessService, UserRoleAccessService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<IRoleService, RoleService>();
        }

        private static void RegistrationSchoolService(this IServiceCollection services)
        {
            services.AddScoped<IStudentService,StudentService>();
        }

        private static void RegistrationShopService(this IServiceCollection service)
        {
            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<IAuthorService, AuthorService>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IBasketService, BasketService>();

        }

        private static void RegistrationBaseInformationService(this IServiceCollection services)
        {
           
        }

      

      

    }
}
