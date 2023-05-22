using System.Collections.Generic;
using System.Linq;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseDto;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AutoMapper;

namespace AUA.ProjectName.Models.ListModes.Shop.UserModel
{
    public class UserListDto :BaseEntityDto<long>, IMapFrom<Users>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string RegistrationDatePersian => RegistrationDate.ToPersianDate();

     
    }
}
