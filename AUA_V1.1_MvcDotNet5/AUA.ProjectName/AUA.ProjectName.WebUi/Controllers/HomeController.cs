using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.Models.ViewModels.BaseViewModel;
using AUA.ProjectName.Services.ListService.Shop.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using System;
using System.Linq;
using System.Security.Claims;
using System.Web;
using AUA.ProjectName.Common.Tools.Security;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.ViewModels.Shop.UserModel;
using AUA.ProjectName.WebUI.Areas.Shop.Data;
using AUA.ProjectName.WebUI.Services;
using AUA.ProjectName.WebUI.Utility.Authorizations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace AUA.ProjectName.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AUAProjectNameWebUIContext _context;
        private readonly ApplicationEfContext ctx;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IProductListService _productlistservice;
        private readonly IBasketService _basketService;
        public HomeController(ILogger<HomeController> logger, AUAProjectNameWebUIContext context, IWebHostEnvironment webHostEnvironment, IProductListService productlistservice, IBasketService basketService)
        {
            _logger = logger;
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
            _productlistservice = productlistservice;
            _basketService = basketService;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.Product.Include("Category").Include("Author").ToListAsync());

        }

        public IActionResult Product(string postTitle)
        {
            if (postTitle != null)
            {
                var postdata = _context.Product.Where(p => p.TitleProduct.Contains(postTitle)).ToList();
                return View(postdata);
            }
            return View( _context.Product.Include("Category").Include("Author").ToList());
        }
        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Author)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        public IActionResult AddToCard(int id)
        {
            _basketService.AddToCard(id);
            return Redirect($"/Home/ShowCard/{id}");
        }

      [Authorize]
        public void ShowCard( )
        {
            return;
        }
        public async Task<IActionResult> DeleteFromBasket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketDetails = await _context.OrderDetails
                .Include(b => b.Order).Include(b=>b.Order)
                .Include(b => b.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (basketDetails == null)
            {
                return NotFound();
            }
            return View(basketDetails);
        }

    
        [HttpPost, ActionName("DeleteFromBasket")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketDetails = await _context.OrderDetails.FindAsync(id);
            _context.OrderDetails.Remove(basketDetails);
       
            await _context.SaveChangesAsync();
        
            return RedirectToAction("ShowCard","Account");
        }
        public IActionResult ErrorPage(EResultStatus resultStatus)
        {
            _logger.LogError(resultStatus.ToDescription());

            var errorPageVm = CreateErrorPageVm(resultStatus);

            return View(errorPageVm);
        }

        private static ErrorPageVm CreateErrorPageVm(EResultStatus resultStatus)
        {
            return new ErrorPageVm
            {
                Message = resultStatus.ToDescription(),
                ErrorCode = resultStatus.GetId()
            };
        }
      
    }
}
