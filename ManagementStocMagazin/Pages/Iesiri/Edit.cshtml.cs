using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagementStocMagazin.Data;
using ManagementStocMagazin.Models;

namespace ManagementStocMagazin.Pages.Iesiri
{
    public class EditModel : PageModel
    {
        private readonly ManagementStocMagazin.Data.ManagementStocMagazinContext _context;

        public EditModel(ManagementStocMagazin.Data.ManagementStocMagazinContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Iesire Iesire { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Iesire = await _context.Iesire
                .Include(i => i.CatalogProduse).FirstOrDefaultAsync(m => m.ID == id);

            if (Iesire == null)
            {
                return NotFound();
            }
           ViewData["CatalogProduseID"] = new SelectList(_context.CatalogProduse, "ID", "Descriere");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Iesire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IesireExists(Iesire.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool IesireExists(int id)
        {
            return _context.Iesire.Any(e => e.ID == id);
        }
    }
}
