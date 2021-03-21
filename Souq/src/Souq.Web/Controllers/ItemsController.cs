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

namespace Souq.Web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly StoreDbContext _context;
        private IEnumerable<Item> _itemsFromSupplir;

        public ItemsController(StoreDbContext context)
        {

            using var client = new HttpClient();
            var task = Task.Run(async () =>
            {
                HttpResponseMessage result = await client.GetAsync("https://localhost:44399/api/Products");
              _itemsFromSupplir= JsonConvert.DeserializeObject<IEnumerable<Item>>(await result.Content.ReadAsStringAsync());

            });
            task.Wait();
            // Console.WriteLine(result.StatusCode);

            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Items.ToListAsync());
        }
        // GET: Items
        [HttpGet]
        public async Task<IActionResult> SupplierItems()
        {
            // var storeDbContext = _context.Items.Include(i => i.Category);
            List<ItemViewModel> res = new List<ItemViewModel>();
                ;
            foreach (var item in _itemsFromSupplir)
            {
                var tempItem = _context.Items.FirstOrDefault(m =>( 
                    m.Name == item.Name
                &&m.ProductionDate==item.ProductionDate
                &&m.ExpireDate==item.ExpireDate
                ));
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
               
                if (tempItem != null)
                {
                    addedItem.IsSelected = true;
                }
                else {
                    addedItem.IsSelected = false;
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
                    _context.Items.Add(_itemsFromSupplir.First(m=>m.Name==item.Name));
                  //  _context.SaveChanges();
                }
                else if (tempItem != null && !item.IsSelected)
                {
                    _context.Items.Remove(_itemsFromSupplir.First(m => m.Name == item.Name));
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
            var item = _itemsFromSupplir.FirstOrDefault(m => m.Id == id);
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

        public async Task<ActionResult> RemoveItem(int id)//here we will take the id from supplier, getTheSupplierItemBy id and then find the item from the Client items
        {
            var selectedItem = _itemsFromSupplir.FirstOrDefault(m => m.Id == id);
            var item = ItemVMCopy(selectedItem);
           
            return View(item);
        }
        [HttpPost, ActionName("RemoveItem")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveConfirmed(int id)
        {
            var selectedItem = _itemsFromSupplir.FirstOrDefault(m => m.Id == id);
            var item = ItemVMCopy(selectedItem);
            Item itemToRemove = _context.Items.FirstOrDefault(m => (
                    m.Name == item.Name
                && m.ProductionDate == item.ProductionDate
                && m.ExpireDate == item.ExpireDate
                ));

            _context.Items.Remove(itemToRemove);
            await _context.SaveChangesAsync();
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
