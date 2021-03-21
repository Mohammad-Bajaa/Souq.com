using Clean.Architecture.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

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
        public IActionResult HomePage()
        {
            return View();
        }
        public async Task<IActionResult> CategoriesItems(int page_number =1)
        {   var skip = (page_number - 1) * 6;
            var take = 6;
            
            ViewBag.Items =  _context.Items.ToList().ToPagedList(page_number, 3);
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.page_number = page_number;
         

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
