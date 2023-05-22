using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.EntitiesDto.Shop;
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;
using AUA.ProjectName.Models.ViewModels.Shop.AuthorModels;
using AUA.ProjectName.Models.ViewModels.Shop.CategoryModels;


namespace AUA.ProjectName.Models.ViewModels.Shop.ProductModels
{
    public class ProductActionVm
    {
        public  ProductDto ProductDtos { get; set; }
        public int Authorid { get; set; }

        public IEnumerable<AuthorVm> AuthorVms { get; set; }
        public int Categoryid { get; set; }

        public IEnumerable<CategoryVm> CategoryVms { get; set; }

    }
}
