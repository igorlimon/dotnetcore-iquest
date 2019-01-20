using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Data;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<ParkingLot> ParkingLots { get; private set; }

        public async Task OnGetAsync()
        {
            ParkingLots = await _db.ParkingLots.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _db.ParkingLots.FindAsync(id);

            if (contact != null)
            {
                _db.ParkingLots.Remove(contact);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public void OnHead()
        {
            HttpContext.Response.Headers.Add("Custom", "REWQ");
        }
    }
}