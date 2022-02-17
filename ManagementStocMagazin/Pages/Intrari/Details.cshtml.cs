using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementStocMagazin.Data;
using ManagementStocMagazin.Models;

namespace ManagementStocMagazin.Pages.Intrari
{
    public class DetailsModel : PageModel
    {
        private readonly ManagementStocMagazin.Data.ManagementStocMagazinContext _context;

        public DetailsModel(ManagementStocMagazin.Data.ManagementStocMagazinContext context)
        {
            _context = context;
        }

        public Intrare Intrare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Intrare = await _context.Intrari
                .Include(i => i.CatalogProduse).FirstOrDefaultAsync(m => m.ID == id);

            if (Intrare == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
