using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ViewModels.Shop.ProductModels
{
    public class ProductVm:BaseVm,IMapFrom<Product>
    {
        public string TitleProduct { get; set; }
        public int CountProduct { get; set; }
        public string IntroductionProduct { get; set; }
        public int PriceProduct { get; set; }
        public int NumberOfPages { get; set; }
        public string PublishYear { get; set; }
        public int Categoryid { get; set; }
        public int Authorid { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }

    }
}
