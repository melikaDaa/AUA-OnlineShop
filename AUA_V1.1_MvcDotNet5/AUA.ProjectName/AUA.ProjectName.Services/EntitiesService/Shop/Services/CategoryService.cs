using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Shop.CategoryModels;
using AUA.ProjectName.Services.EntitiesService.Shop.Contracts;
using AUA.ServiceInfrastructure.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Services.EntitiesService.Shop.Services
{
    public class CategoryService:GenericEntityService<Category,CategoryDto>,ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork,
            IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {

        }

        public async Task<IEnumerable<CategoryVm>> GetCategoryVmAsync()
        {
            var query = GetAll().Where(p => p.IsActive);

            return  MapperInstance
                .ProjectTo<CategoryVm>(query)
                .ToList();
        }

       
    }
}
