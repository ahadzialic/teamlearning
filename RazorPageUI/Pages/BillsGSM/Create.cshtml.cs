using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageUI.Data;
using RazorPageUI.Models;

namespace RazorPageUI.Pages.BillsGSM
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageUI.Data.BillContext _context;

        public CreateModel(RazorPageUI.Data.BillContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BillGSM BillGSM { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BillGSM.Add(BillGSM);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
