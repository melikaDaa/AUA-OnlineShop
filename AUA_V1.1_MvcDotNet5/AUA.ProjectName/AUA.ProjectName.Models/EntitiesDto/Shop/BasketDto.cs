using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseDto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUA.ProjectName.Models.EntitiesDto.Shop
{
  public  class BasketDto: BaseEntityDto, IHaveCustomMappings
    {
        public int OrderSum { get; set; }
        public bool IsFinaly { get; set; }
        public DateTime DateBought { get; set; }
        public ICollection<BasketDeatilsDto> basketDeatils { get; set; }

        public void ConfigureMapping(Profile configuration)
        {
            configuration.CreateMap<Basket, BasketDto>()
                .ForMember(p => p.basketDeatils, p => p.MapFrom(q => q.OrderDetails));

            configuration.CreateMap<BasketDto, Basket>();
        }
    }
}
