using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementStocMagazin.Data;
using ManagementStocMagazin.Models;

namespace ManagementStocMagazin.Pages.Iesiri
{
    public class IndexModel : PageModel
    {
        private readonly ManagementStocMagazin.Data.ManagementStocMagazinContext _context;

        public IndexModel(ManagementStocMagazin.Data.ManagementStocMagazinContext context)
        {
            _context = context;
        }

        public IList<Iesire> Iesire { get;set; }

        public async Task OnGetAsync()
        {
            Iesire = await _context.Iesire
                .Include(i => i.CatalogProduse).ToListAsync();
        }
    }
}
