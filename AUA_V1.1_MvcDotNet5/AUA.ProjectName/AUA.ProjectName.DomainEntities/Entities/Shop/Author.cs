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
    [Table("Author", Schema = SchemaConsts.Shop)]

    public class Author:DomainEntity
    {
        public string AuthorName { get; set; }
        public  ICollection<Product> Products { get; set; }


    }
}
