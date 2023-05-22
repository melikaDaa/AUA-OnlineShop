using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.DomainEntities.Entities.Shop;

namespace AUA.ProjectName.WebUI.Services
{
    public interface IBasketService
    {

        void AddToCard(int productId);

        Basket GetUserOrder();
    }
}
