using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ListModes.Shop.Products
{
    public class ProductSearchVm: BaseSearchVm
    {
        public string TitleProduct { get; set; }
        public string Publisher { get; set; }
        public int Authorid { get; set; }
    }
}
