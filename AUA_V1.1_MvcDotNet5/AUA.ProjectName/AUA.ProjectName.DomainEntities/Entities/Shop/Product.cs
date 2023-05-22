using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.BaseEntities;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace AUA.ProjectName.DomainEntities.Entities.Shop
{
    [Table("Product", Schema = SchemaConsts.Shop)]


    public class Product : DomainEntity
    {
        public string TitleProduct { get; set; }
        public int CountProduct { get; set; }
        public string IntroductionProduct { get; set; }
        public int PriceProduct { get; set; }
        public  int NumberOfPages { get; set; }
        public string PublishYear { get; set; }
        public string Publisher { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        public IFormFile PicProduct { get; set; }
        public int Categoryid { get; set; }
        public int Authorid { get; set; }
        public  virtual Category Category { get; set; }
        public   virtual Author Author { get; set; }
     


    }
}
