using AUA.ProjectName.Common.Tools.Config.JsonSetting;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.WebUI.Areas.Shop.Data
{
    public class AUAProjectNameWebUIContext : DbContext
    {
        public AUAProjectNameWebUIContext (DbContextOptions<AUAProjectNameWebUIContext> options)
            : base(options)
        {
           
        }
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(AppConfiguration.EfConnectionString, sqlOptions =>
                {
                 
                    sqlOptions.EnableRetryOnFailure();
               
                });

        }


        public DbSet<AUA.ProjectName.DomainEntities.Entities.Shop.Product> Product { get; set; }
        public DbSet<Users> Users { get; set; }
   
        public DbSet<Basket> Orders { get; set; }
        public DbSet<BasketDetails> OrderDetails { get; set; }



    }
}
