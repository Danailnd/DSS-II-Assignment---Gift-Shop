using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gift_Shop_admin_input.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gift_Shop_admin_input.Pages.ItemList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Item Item { get; set; }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Item.AddAsync(Item);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            else
            {
                return Page();
            }
        }
    }
}
