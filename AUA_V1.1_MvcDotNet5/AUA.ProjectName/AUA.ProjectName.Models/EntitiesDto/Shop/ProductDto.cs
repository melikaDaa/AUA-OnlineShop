using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseDto;
using AutoMapper;

namespace AUA.ProjectName.Models.EntitiesDto.Shop
{
   public class ProductDto: BaseEntityDto, IMapFrom<Product>
    {
        public string TitleProduct { get; set; }
        public int CountProduct { get; set; }
        public string IntroductionProduct { get; set; }
        public int PriceProduct { get; set; }
        public int NumberOfPages { get; set; }
        public string PublishYear { get; set; }
        public int Categoryid { get; set; }
        public int Authorid { get; set; }
        public  Category Category { get; set; }
        public  Author Author { get; set; }


    }
}
