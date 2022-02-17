using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagementStocMagazin.Models;

namespace ManagementStocMagazin.Data
{
    public class ManagementStocMagazinContext : DbContext
    {
        public ManagementStocMagazinContext (DbContextOptions<ManagementStocMagazinContext> options)
            : base(options)
        {
        }

        public DbSet<ManagementStocMagazin.Models.CatalogProduse> CatalogProduse { get; set; }

        public DbSet<ManagementStocMagazin.Models.Intrare> Intrari { get; set; }

        public DbSet<ManagementStocMagazin.Models.Iesire> Iesire { get; set; }
    }
}
