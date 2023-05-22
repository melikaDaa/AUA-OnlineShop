using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Shop.AuthorModels;
using AUA.ServiceInfrastructure.BaseServices;

namespace AUA.ProjectName.Services.EntitiesService.Shop.Contracts
{
   public interface IAuthorService: IGenericEntityService<Author, AuthorDto>
    {
       IEnumerable<AuthorVm> GetAuthorVmAsync();
   }
}
