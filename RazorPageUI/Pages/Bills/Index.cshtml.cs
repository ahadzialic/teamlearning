using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageUI.Data;
using RazorPageUI.Models;

namespace RazorPageUI.Pages.Bills
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageUI.Data.BillContext _context;

        public IndexModel(RazorPageUI.Data.BillContext context)
        {
            _context = context;
        }

        public IList<Bill> Bill { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public async Task OnGetAsync()
        {
            var bills = from m in _context.Bill
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                bills = bills.Where(s => s.ProductofferName.Contains(SearchString));
            }

            Bill = await bills.ToListAsync();
        }
        
    }
}
