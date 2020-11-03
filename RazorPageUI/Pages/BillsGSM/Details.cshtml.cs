using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageUI.Data;
using RazorPageUI.Models;

namespace RazorPageUI.Pages.BillsGSM
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageUI.Data.BillContext _context;

        public DetailsModel(RazorPageUI.Data.BillContext context)
        {
            _context = context;
        }

        public BillGSM BillGSM { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BillGSM = await _context.BillGSM.FirstOrDefaultAsync(m => m.ID == id);

            if (BillGSM == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
