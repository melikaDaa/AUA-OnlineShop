using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUA.ProjectName.DomainEntities.Entities.Shop;
using AUA.ProjectName.WebUI.Utility.Authorizations;
 using System.Web;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Models.ListModes.Shop.Products;
using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ProjectName.Services.ListService.Shop.Contracts;
using AUA.ProjectName.WebUI.Areas.Shop.Data;
using AUA.ProjectName.WebUI.Controllers;
using Microsoft.AspNetCore.Hosting;

namespace AUA.ProjectName.WebUI.Areas.Shop.Controllers
{
    [Area(AreasConsts.Shop)]
    [WebAuthorize(EUserAccess.AppUser)]

    public class ProductsController : BaseController
    {

        private readonly AUAProjectNameWebUIContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IProductListService _productlistservice;
        public ProductsController(AUAProjectNameWebUIContext context, IWebHostEnvironment webHostEnvironment, IProductListService productlistservice)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
            _productlistservice = productlistservice;
        }

    
        public async Task<IActionResult> Index()
        {
         
         
            var aUAProjectNameWebUIContext = _context.Product.Include(p => p.Author).Include(p => p.Category);
            return View(await aUAProjectNameWebUIContext.ToListAsync());
        }

  

        public async Task<ListResultVm<ProductListDto>> FilterAsync(ProductSearchVm appUserSearchVm)
        {
            FixSearchVm(appUserSearchVm);

            var result = await _productlistservice.ListAsync(appUserSearchVm);

            return result;
        }

       
        public async Task<IActionResult> Details(int? id)
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

        public IActionResult Create()
        {
            ViewData["Authorid"] = new SelectList(_context.Set<Author>(), "Id", "AuthorName");
            ViewData["Categoryid"] = new SelectList(_context.Set<Category>(), "Id", "CategoryTitle");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TitleProduct,CountProduct,IntroductionProduct,PriceProduct,NumberOfPages,PublishYear,Categoryid,Authorid,Publisher,PicProduct")] Product product  )
        {
            if (ModelState.IsValid)
            {

                if (product.PicProduct != null)
                {
                    string wwwRootPath = webHostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(product.PicProduct.FileName);
                    string extension = Path.GetExtension(product.PicProduct.FileName);
                    product.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Images/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await product.PicProduct.CopyToAsync(fileStream);
                    }
                }

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Authorid"] = new SelectList(_context.Set<Author>(), "Id", "AuthorName", product.Authorid);
            ViewData["Categoryid"] = new SelectList(_context.Set<Category>(), "Id", "CategoryTitle", product.Categoryid);
            return View(product);
        }


    
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Authorid"] = new SelectList(_context.Set<Author>(), "Id", "AuthorName", product.Authorid);
            ViewData["Categoryid"] = new SelectList(_context.Set<Category>(), "Id", "CategoryTitle", product.Categoryid);
            return View(product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TitleProduct,CountProduct,IntroductionProduct,PriceProduct,NumberOfPages,PublishYear,Categoryid,Authorid,Publisher")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            ViewData["Authorid"] = new SelectList(_context.Set<Author>(), "Id", "AuthorName", product.Authorid);
            ViewData["Categoryid"] = new SelectList(_context.Set<Category>(), "Id", "CategoryTitle", product.Categoryid);
            return View(product);
        }

        public async Task<IActionResult> Delete(int? id)
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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product.PicProduct != null)
            {
                var imagePath = Path.Combine(webHostEnvironment.WebRootPath, "Images", product.ImageName);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
