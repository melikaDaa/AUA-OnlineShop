using System.Threading.Tasks;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Models.ListModes.Shop.UserModel;
using AUA.ServiceInfrastructure.BaseSearchService;

namespace AUA.ProjectName.Services.ListService.Shop.Contracts
{
    public interface IUserListService : IBaseListService<Users, UserListDto>
    {

        Task<ListResultVm<UserListDto>> ListAsync(UserSearchVm UserSearchVm);

    }
}
