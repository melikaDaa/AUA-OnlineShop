using System.Threading.Tasks;
using AUA.ProjectName.Models.DataModels.LoginDataModels;
using AUA.ProjectName.Models.DataModels.LoginDataModels.Shop;
using AUA.ProjectName.Models.GeneralModels.LoginModels;
using AUA.ProjectName.Models.GeneralModels.LoginModels.Shop;
using AUA.ProjectName.Services.BaseService.Contracts;

namespace AUA.ProjectName.Services.GeneralService.Login.Sop.Contracts
{
    public interface ILoginServiceShop : IBaseBusinessService
    {
        Task<LoginDmShop> LoginAsync(LoginShopVm loginVm);

    }
}
