using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clean.Architecture.Core.Entities;

namespace Souq.Web.Controllers
{
    public class CartItemsController : Controller
    {
        private readonly StoreDbContext _context;

        public CartItemsController(StoreDbContext context)
        {
            _context = context;
        }

        // GET: CartItems
        public async Task<IActionResult> Index()
        {
            var storeDbContext = _context.CartItems.Include(c => c.Cart).Include(c => c.Item);
            return View(await storeDbContext.ToListAsync());
        }

        // GET: CartItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItems = await _context.CartItems
                .Include(c => c.Cart)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (cartItems == null)
            {
                return NotFound();
            }

            return View(cartItems);
        }

        // GET: CartItems/Create
        public IActionResult Create()
        {
            ViewData["ItemId"] = new SelectList(_context.Carts, "Id", "Id");
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id");
            return View();
        }

        // POST: CartItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity,CartID,ItemId")] CartItems cartItems)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartItems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemId"] = new SelectList(_context.Carts, "Id", "Id", cartItems.ItemId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id", cartItems.ItemId);
            return View(cartItems);
        }

        // GET: CartItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItems = await _context.CartItems.FindAsync(id);
            if (cartItems == null)
            {
                return NotFound();
            }
            ViewData["ItemId"] = new SelectList(_context.Carts, "Id", "Id", cartItems.ItemId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id", cartItems.ItemId);
            return View(cartItems);
        }

        // POST: CartItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity,CartID,ItemId")] CartItems cartItems)
        {
            if (id != cartItems.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemsExists(cartItems.ItemId))
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
            ViewData["ItemId"] = new SelectList(_context.Carts, "Id", "Id", cartItems.ItemId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id", cartItems.ItemId);
            return View(cartItems);
        }

        // GET: CartItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItems = await _context.CartItems
                .Include(c => c.Cart)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (cartItems == null)
            {
                return NotFound();
            }

            return View(cartItems);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartItems = await _context.CartItems.FindAsync(id);
            _context.CartItems.Remove(cartItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartItemsExists(int id)
        {
            return _context.CartItems.Any(e => e.ItemId == id);
        }
    }
}
