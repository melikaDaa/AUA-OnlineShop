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
    [Table("Basket", Schema = SchemaConsts.Shop)]

    public class Basket:DomainEntity
    {
        public int UserId { get; set; }
        public int OrderSum { get; set; }
        public bool IsFinaly { get; set; }
        public DateTime DateBought { get; set; }
        public virtual Users User { get; set; }
        public virtual List<BasketDetails> OrderDetails { get; set; }
    }
}
