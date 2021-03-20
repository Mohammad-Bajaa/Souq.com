using Clean.Architecture.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Souq.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreDbContext _context;

        public HomeController(StoreDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CategoriesItems()
        {


            return View(await _context.Categories.ToListAsync());
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
