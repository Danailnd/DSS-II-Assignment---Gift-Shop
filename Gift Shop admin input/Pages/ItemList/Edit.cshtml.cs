using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gift_Shop_admin_input.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gift_Shop_admin_input.Pages.ItemList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Item Item { get; set; }

        public async Task OnGet(int id)
        {
            Item = await _db.Item.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var ItemFromDb = await _db.Item.FindAsync(Item.Id);
                ItemFromDb.Name = Item.Name;
                ItemFromDb.ImageAddress = Item.ImageAddress;
                ItemFromDb.Category = Item.Category;
                ItemFromDb.Price = Item.Price;
                ItemFromDb.Date = DateTime.Now;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
