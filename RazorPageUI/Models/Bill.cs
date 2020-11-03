using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace RazorPageUI.Models
{
    public class Bill
    {
        public int ID { get; set; } // šifra

        [Display(Name = "Naziv  usluge"), StringLength(10)]
        [Column(TypeName = "varchar(200)")]
        public string ProductofferName { get; set; }

        [Display(Name = "Jedinična cijena")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Količina jedinične mjere - decimal")]
        public decimal? UnitPriceAmount1 { get; set; }

        [Display(Name = "Količina jedinične mjere - TimeSpan")]
        public TimeSpan? UnitPriceAmount2 { get; set; }

        [Display(Name = "Vrijednost PDV-a")]
        public decimal VAT { get; set; }
    }


}
