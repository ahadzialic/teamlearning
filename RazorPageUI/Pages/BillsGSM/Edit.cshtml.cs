using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPageUI.Data;
using RazorPageUI.Models;

namespace RazorPageUI.Pages.BillsGSM
{
    public class EditModel : PageModel
    {
        private readonly RazorPageUI.Data.BillContext _context;

        public EditModel(RazorPageUI.Data.BillContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BillGSM).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillGSMExists(BillGSM.ID))
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

        private bool BillGSMExists(int id)
        {
            return _context.BillGSM.Any(e => e.ID == id);
        }
    }
}
