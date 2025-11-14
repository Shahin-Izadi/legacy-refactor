using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModernProducts.Data;

namespace ModernProducts.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductDbContext _db;
        public ProductsController(ProductDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var products = await _db.Products.ToListAsync();
            return View(products);
        }
    }
}