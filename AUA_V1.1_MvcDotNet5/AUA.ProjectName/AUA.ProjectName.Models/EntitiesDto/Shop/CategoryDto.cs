using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseDto;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AutoMapper;

namespace AUA.ProjectName.Models.EntitiesDto.Shop
{
    public class CategoryDto:BaseEntityDto,IMapFrom<Category>

    {
        public string CategoryTitle { get; set; }
        public string Description { get; set; }
       
    }
}
