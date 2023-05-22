using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Shop
{
    public class ProductConfig: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder
                .Property(p => p.TitleProduct)
                .HasMaxLength(LengthConsts.MaxStringLen100);
            builder
                .Property(p => p.IntroductionProduct)
                .HasMaxLength(LengthConsts.MaxStringLen200);

            builder.HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.Categoryid)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Author)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.Authorid)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
