using System.Text.Encodings.Web;
using System.Text.Unicode;
using AUA.ProjectName.Services.GeneralService.Login.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Services;
using AUA.ProjectName.Services.GeneralService.Login.Sop.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Sop.Services;
using Microsoft.Extensions.DependencyInjection;


namespace AUA.ProjectName.WebUi.RegistrationServices
{
    public static class GeneralService
    {
        public static void RegistrationGeneralServices(this IServiceCollection services)
        {

            services.RegistrationAccessServices();
            services.RegistrationAccessServicesShop();

        }

        private static void RegistrationAccessServices(this IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IAccessTokenService, AccessTokenService>();
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));
            
        }

        private static void RegistrationAccessServicesShop(this IServiceCollection services)
        {
            services.AddScoped<ILoginServiceShop,LoginServiceShop>();

        }


    }
}
