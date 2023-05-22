using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Shop
{
    class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(p => p.CategoryTitle)
                .HasMaxLength(LengthConsts.MaxStringLen100);
        }
    }
}
