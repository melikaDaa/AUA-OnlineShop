using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ViewModels.Shop.CategoryModels
{
   public class CategoryUpdateVm:GeneralVm,IMapFrom<Category>
    {
        public string CategoryTitle { get; set; }
        public string Description { get; set; }
    }
}
