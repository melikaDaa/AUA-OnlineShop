using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.BaseEntities;

namespace AUA.ProjectName.DomainEntities.Entities.Shop
{
    [Table("Category", Schema = SchemaConsts.Shop)]


    public class Category:DomainEntity
    {
        public string CategoryTitle { get; set; }
        public string Description { get; set; }
        public ICollection<Product>Products { get; set; }


    }
}
