using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.WebUI.Areas.Shop.Data;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.WebUI.Services
{
    public class BasketService:IBasketService
    {
        private readonly AUAProjectNameWebUIContext _context;

        public BasketService(AUAProjectNameWebUIContext context)
        {
            _context = context;
        }

        public void AddToCard(int productId )
        {
            var product = _context.Product.Find(productId);
            var order = _context.Orders.SingleOrDefault(p => p.IsFinaly == false); if (order == null)
            {
                _context.Orders.Add(new Basket()
                {
                    IsFinaly = false,
                    OrderSum = product.PriceProduct,
                    DateBought = DateTime.Now,
                    OrderDetails = new List<BasketDetails>()
                    {
                        new BasketDetails()
                        {
                            Price = product.PriceProduct,
                            ProductId = product.Id
                        }
                    }
                });

            }
            else
            {
                var details = _context.OrderDetails.Include(p => p.Product).SingleOrDefault(p => p.BasketId == order.Id && p.ProductId == product.Id);
                if (details != null)
                {

                }
                else
                {
                    details = new BasketDetails()
                    {
                        Price = product.PriceProduct,
                        ProductId = productId,
                        BasketId = order.Id
                    };
                    order.OrderDetails = new List<BasketDetails>();
                    order.OrderDetails.Add(details);
                    order.OrderSum += product.PriceProduct;

                }

            }
            _context.SaveChanges();
        }

        public void RemoveFromCart(int productid)
        {
           
        }



        public Basket GetUserOrder( )
        {
            return _context.Orders.Include(o => o.OrderDetails).ThenInclude(o => o.Product).SingleOrDefault();
        }

    }
}
