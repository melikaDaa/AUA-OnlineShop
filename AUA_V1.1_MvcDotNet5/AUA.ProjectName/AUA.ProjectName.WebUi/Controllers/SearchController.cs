using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.WebUI.Areas.Shop.Data;

namespace AUA.ProjectName.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly AUAProjectNameWebUIContext _context;

        public SearchController(AUAProjectNameWebUIContext context)
        {
            _context = context;
        }
        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var names = _context.Product.Where(p => p.TitleProduct.Contains(term)).Select(p => p.TitleProduct).ToList();
                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
