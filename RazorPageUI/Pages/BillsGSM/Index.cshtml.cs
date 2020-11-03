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
    public class IndexModel : PageModel
    {
        private readonly RazorPageUI.Data.BillContext _context;

        public IndexModel(RazorPageUI.Data.BillContext context)
        {
            _context = context;
        }

        public IList<BillGSM> BillGSM { get;set; }

        public async Task OnGetAsync()
        {
            BillGSM = await _context.BillGSM.ToListAsync();
        }
    }
}
