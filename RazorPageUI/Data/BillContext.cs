using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageUI.Models;

namespace RazorPageUI.Data
{
    public class BillContext : DbContext
    {
        public BillContext (DbContextOptions<BillContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageUI.Models.Bill> Bill { get; set; }

        public DbSet<RazorPageUI.Models.BillGSM> BillGSM { get; set; }
    }
}
