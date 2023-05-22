using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Common.Tools.Security;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Shop.UserModel;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ServiceInfrastructure.BaseServices;
using AutoMapper;

namespace AUA.ProjectName.Services.EntitiesService.Shop.Services
{
    public class UserService :GenericEntityService<Users, UserDto>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {
        }
        public async Task<EResultStatus> ChangePasswordAsync(string newPassword, int userId)
        {
            var appUser = await GetByIdAsync(userId);

            if (appUser is null)
                return EResultStatus.UserNotFind;

            appUser.Password = EncryptionHelper.GetSha512Hash(newPassword);

            await UpdateAsync(appUser);

            return EResultStatus.Success;
        }
    }
}
