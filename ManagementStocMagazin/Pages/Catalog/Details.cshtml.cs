using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementStocMagazin.Data;
using ManagementStocMagazin.Models;

namespace ManagementStocMagazin.Pages.Catalog
{
    public class DetailsModel : PageModel
    {
        private readonly ManagementStocMagazin.Data.ManagementStocMagazinContext _context;

        public DetailsModel(ManagementStocMagazin.Data.ManagementStocMagazinContext context)
        {
            _context = context;
        }

        public CatalogProduse CatalogProduse { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CatalogProduse = await _context.CatalogProduse.FirstOrDefaultAsync(m => m.ID == id);

            if (CatalogProduse == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
