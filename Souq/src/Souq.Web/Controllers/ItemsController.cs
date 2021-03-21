using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clean.Architecture.Core.Entities;
using System.Net.Http;
using Newtonsoft.Json;
using Souq.Core.ViewModels;
using X.PagedList;

namespace Souq.Web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly StoreDbContext _context;
        private IEnumerable<Item> x;

        public ItemsController(StoreDbContext context)
        {

            using var client = new HttpClient();
            var task = Task.Run(async () =>
            {
                HttpResponseMessage result = await client.GetAsync("https://localhost:44399/api/Products");
              x= JsonConvert.DeserializeObject<IEnumerable<Item>>(await result.Content.ReadAsStringAsync());

            });
           // task.Wait();
            // Console.WriteLine(result.StatusCode);

            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Items.ToListAsync());
        }
        public async Task<IActionResult> ItemPage()
        {
            return View(await _context.Items.ToListAsync());
        }
        // GET: Items

        public async Task<IActionResult> CategoryItems(int category_id,int page_number)
            {
            ViewBag.category_id = category_id;
            /*ViewBag.categories =  _context.Categories.ToListAsync();


             var items =  _context.Items;
             List <Item> new_items = new List<Item>();
             foreach(var item in items)
             {
                 if(item.CategoryID == category_id)
                 {
                     new_items.Add(item);
                 }
             }
         ViewBag.items = new_items;
             return View();


         var skip = (page_number - 1) * 6;
         var take = 6;*/

            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.page_number = page_number;

            var items = _context.Items;
            List<Item> new_items = new List<Item>();
            foreach (var item in items)
            {
                if (item.CategoryID == category_id)
                {
                    new_items.Add(item);
                }
            }
            ViewBag.items = new_items.ToList().ToPagedList(page_number, 3);
            var carts = _context.Carts.ToList();
            CartItems c = new CartItems();
            List<CartItems> cart1Items = new List<CartItems>();
            foreach (var cart in carts)
            {
                //customer_id = 1;
               if (cart.CustomerId == 1)
                {
                    var cartitems = _context.CartItems.ToList();
                    foreach (var i in cartitems)
                    {
                        if (i.CartID == cart.Id)
                        {
                            cart1Items.Add(i);
                        }
                       

                    }
                     break;
                }
            }
            var customer_items = cart1Items.ToList();
            ViewBag.customer_items = customer_items;

            return View();
            //ViewBag.PageNumber = page_number;


            //return View(await _context.Items.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> SupplierItems()
        {
            // var storeDbContext = _context.Items.Include(i => i.Category);
            List<ItemViewModel> res = new List<ItemViewModel>()
                ;
            foreach (var item in x)
            {
                ItemViewModel addedItem = new ItemViewModel
                { 
                Id=item.Id,
                Name=item.Name,
                Description=item.Description,
                ProductionDate=item.ProductionDate,
                ExpireDate=item.ExpireDate,
                Amount=item.Amount,
                Price=item.Price,
                CategoryID=item.CategoryID,
                IsOffer=item.isoffer
               
                
                };
                var i = _context.Items.FirstOrDefault(m => m.Id == item.Id);
                if (i != null)
                {
                    addedItem.IsSelected = true;
                }
                res.Add(addedItem);

            }
           

            return View( res.ToList());
        }
        [HttpPost]
        public async Task<ActionResult> SupplierItems([FromForm]List<ItemViewModel> entities)
        {
            foreach(var item in entities)
            {
                var tempItem=_context.Items.FirstOrDefault(m => m.Name == item.Name);
                if(tempItem==null && item.IsSelected)
                {
                    _context.Items.Add(x.First(m=>m.Name==item.Name));
                  //  _context.SaveChanges();
                }
                else if (tempItem != null && !item.IsSelected)
                {
                    _context.Items.Remove(x.First(m => m.Name == item.Name));
                }
                else
                {
                    continue;
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        
        public async Task<ActionResult> AddNewItem(int id)
        {
            var item = x.FirstOrDefault(m => m.Id == id);
            var itemVM = ItemVMCopy(item);
            return View(itemVM);
        }
        [HttpPost]
        public async Task<ActionResult> AddNewItem(ItemViewModel entity)
        {
            Item ni = ItemFromViewModel(entity);
            ni.Id = 0;
            ni.CategoryID = 1;
            _context.Items.Add(ni);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }
        Item ItemFromViewModel(ItemViewModel item)
        {
            return new Item {

                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                ProductionDate = item.ProductionDate,
                ExpireDate = item.ExpireDate,
                Amount = item.Amount,
                Price = item.Price+item.AdditionalPrice,
                CategoryID = item.CategoryID,
                isoffer = item.IsOffer
                
            };
        }
        ItemViewModel ItemVMCopy(Item item)
        {
            ItemViewModel viewModel = new ItemViewModel
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                ProductionDate = item.ProductionDate,
                ExpireDate = item.ExpireDate,
                Amount = item.Amount,
                Price = item.Price,
                CategoryID = item.CategoryID,
                IsOffer = item.isoffer
                ,AdditionalPrice=0

            };
            return viewModel;
        }
        // GET: Items/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "Id", "Id");
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ProductionDate,ExpireDate,Amount,Price,ImageName,ImagePath,CategoryID,isoffer")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "Id", "Id", item.CategoryID);
            return View(item);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "Id", "Id", item.CategoryID);
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ProductionDate,ExpireDate,Amount,Price,ImageName,ImagePath,CategoryID,isoffer")] Item item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "Id", "Id", item.CategoryID);
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Items.FindAsync(id);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}
