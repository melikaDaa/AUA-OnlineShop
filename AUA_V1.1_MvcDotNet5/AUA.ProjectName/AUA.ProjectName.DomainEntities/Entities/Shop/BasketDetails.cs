using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.BaseEntities;

namespace AUA.ProjectName.DomainEntities.Entities.Shop
{
    [Table("BasketDetails", Schema = SchemaConsts.Shop)]

    public class BasketDetails:DomainEntity
    {
        public int BasketId { get; set; }
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Price { get; set; }

        [ForeignKey("BasketId")]
        public virtual Basket Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
