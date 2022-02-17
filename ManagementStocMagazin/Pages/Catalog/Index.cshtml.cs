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
    public class IndexModel : PageModel
    {
        private readonly ManagementStocMagazin.Data.ManagementStocMagazinContext _context;

        public IndexModel(ManagementStocMagazin.Data.ManagementStocMagazinContext context)
        {
            _context = context;
        }

        public IList<CatalogProduse> CatalogProduse { get;set; }

        public async Task OnGetAsync()
        {
            CatalogProduse = await _context.CatalogProduse.ToListAsync();
        }
    }
}
