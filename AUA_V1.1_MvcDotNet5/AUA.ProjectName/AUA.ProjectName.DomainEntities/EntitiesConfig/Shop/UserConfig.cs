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
    public class UserConfig: IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder
                .Property(p => p.FirstName)
                .HasMaxLength(LengthConsts.MaxStringLen50);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(LengthConsts.MaxStringLen50);

            builder
                .Property(p => p.UserName)
                .HasMaxLength(LengthConsts.MaxStringLen50);

            builder
                .Property(p => p.Password)
                .HasMaxLength(LengthConsts.MaxStringLen250);

            builder
                .Property(p => p.Phone)
                .HasMaxLength(LengthConsts.MaxStringLen25);

            builder
                .Property(p => p.Email)
                .HasMaxLength(LengthConsts.MaxStringLen100);
        }
    }
}
