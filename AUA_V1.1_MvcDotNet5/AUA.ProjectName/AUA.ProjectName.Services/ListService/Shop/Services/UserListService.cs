using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Models.ListModes.Shop.UserModel;
using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ProjectName.Services.ListService.Shop.Contracts;
using AUA.ServiceInfrastructure.BaseSearchService;
using AutoMapper;

namespace AUA.ProjectName.Services.ListService.Shop.Services
{
    public sealed class UserListService : BaseListService<Users, UserListDto, UserSearchVm>, IUserListService
    {
        public UserListService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {

        }

        public async Task<ListResultVm<UserListDto>> ListAsync(UserSearchVm UserSearchVm)
        {
            SetSearchVm(UserSearchVm);

            ApplyUserNameFilter();
            ApplyLastNameFilter();
            ApplyFirstNameFilter();
            ApplyIsActiveFilters();


            return await CreateListVmResultAsync();
        }

        private void ApplyUserNameFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.UserName))
                return;

            Query = Query.Where(p => p.UserName.Contains(SearchVm.UserName));
        }

        private void ApplyLastNameFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.LastName))
                return;

            Query = Query.Where(p => p.LastName.Contains(SearchVm.LastName));
        }

        private void ApplyFirstNameFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.FirstName))
                return;

            Query = Query.Where(p => p.FirstName.Contains(SearchVm.FirstName));
        }

        private void ApplyIsActiveFilters()
        {
            if (!SearchVm.IsActive.HasValue)
                return;

            Query = Query.Where(p => p.IsActive == SearchVm.IsActive);
        }


    }
}
