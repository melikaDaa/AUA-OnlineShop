using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AutoMapper;

namespace AUA.ProjectName.Models.ViewModels.Shop.AuthorModels
{
   public class AuthorVm:BaseVm,IMapFrom<Author>
    {
        public string AuthorName { get; set; }

    }
}
