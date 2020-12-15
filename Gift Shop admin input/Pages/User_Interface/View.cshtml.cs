using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gift_Shop_admin_input.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gift_Shop_admin_input.Pages.User_Interface
{
    public class ViewModel : PageModel
    {
        private ApplicationDbContext _db;

        public ViewModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Item Item { get; set; }

        public async Task OnGet(int id)
        {
            Item = await _db.Item.FindAsync(id);
        }
    }
}
