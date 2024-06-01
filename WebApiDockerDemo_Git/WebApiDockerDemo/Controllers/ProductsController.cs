using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDockerDemo.Data;
using WebApiDockerDemo.Models;

namespace WebApiDockerDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly OnlineShopDbContext _context;
        public ProductsController(OnlineShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.ToListAsync();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
