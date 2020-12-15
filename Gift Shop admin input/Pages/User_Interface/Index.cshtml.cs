using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gift_Shop_admin_input.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Gift_Shop_admin_input.Pages.User_Interface
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Item> Items { get; set; }
        public async Task OnGet()
        {
            Items = await _db.Item.ToListAsync();
        }
        
        /*public async Task<IActionResult> OnPostDelete(int id)
        {
            var item = await _db.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            _db.Item.Remove(item);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }*/
    }
}
