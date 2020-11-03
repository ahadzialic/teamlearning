using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageUI.Models
{
    public class BillGSM
    {
        public int ID { get; set; } // šifra

        [Display(Name = "ID usluge")]
        public string ProductofferID { get; set; }

        [Display(Name = "Naziv usluge")]
        public string ProductofferNameGSM { get; set; }

        [Display(Name = "Jedinična cijena")]
        public decimal? UnitPriceGSM { get; set; }

        [Display(Name = "Količina jedinične mjere - decimal")]
        public decimal? UnitPriceAmountGSM1 { get; set; }

        [Display(Name = "Količina jedinične mjere - TimeSpan")]
        public TimeSpan? UnitPriceAmountGSM2 { get; set; }

        [Display(Name = "PDV")]
        public decimal? ValueWithoutVAT { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Datum izdavanja")]
        public DateTime? ReleaseDate { get; set; }
    }
}
