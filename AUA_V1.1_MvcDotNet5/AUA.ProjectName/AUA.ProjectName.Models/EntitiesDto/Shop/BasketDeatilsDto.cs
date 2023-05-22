using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUA.ProjectName.Models.EntitiesDto.Shop
{
  public  class BasketDeatilsDto : BaseEntityDto, IMapFrom<BasketDetails>
    {
        public int BasketId { get; set; }
     
        public int ProductId { get; set; }

        public int Price { get; set; }

        public  Basket Order { get; set; }

        public  Product Product { get; set; }
    }
}
