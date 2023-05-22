using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ServiceInfrastructure.BaseServices;

namespace AUA.ProjectName.Services.EntitiesService.Shop.Contracts
{
 public   interface IUserService: IGenericEntityService<Users, UserDto>
    {
        Task<EResultStatus> ChangePasswordAsync(string newPassword, int userId);
    }
}
