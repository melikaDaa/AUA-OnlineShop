using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ViewModels.Shop.AuthorModels
{
   public class AuthorUpdateVm:GeneralVm,IMapFrom<Author>
    {
        public string AuthorName { get; set; }
    }
}
