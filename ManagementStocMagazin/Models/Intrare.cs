using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementStocMagazin.Models
{
    public class Intrare
    {
        public int ID { get; set; }
        public int CatalogProduseID { get; set; }
        public CatalogProduse CatalogProduse { get; set; }
        [RegularExpression(@"^[0-9a-zA-Z''-'\s]{3,40}$",
        ErrorMessage = "Permise doar litere si cifre, min = 3, max = 40"), Required]
        public string Descriere { get; set; }
        [Display(Name = "Data Intrarii")]
        public DateTime DataIntrarii { get; set; }
        [RegularExpression(@"^[1-9][0-9]*$",
        ErrorMessage = "Doar numere"), Required]
        public int Cantitate { get; set; }
    }
}
