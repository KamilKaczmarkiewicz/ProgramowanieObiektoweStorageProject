using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProgramowanieObiektoweStorageProject.DbServices;
using ProgramowanieObiektoweStorageProject.Models;

namespace ProgramowanieObiektoweStorageProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get; set; } = default!;

        public async Task OnGetAsync(string sortOrder)
        {

            IQueryable<Item> items = _context.Items;

            items = sortOrder switch
            {
                "name_desc" => items.OrderByDescending(s => s.Name),
                "Quantity" => items.OrderBy(s => s.Quantity),
                "quantity_desc" => items.OrderByDescending(s => s.Quantity),
                "ItemVolume" => items.OrderBy(s => s.ItemVolume),
                "volume_desc" => items.OrderByDescending(s => s.ItemVolume),
                "ItemPrice" => items.OrderBy(s => s.ItemPrice),
                "price_desc" => items.OrderByDescending(s => s.ItemPrice),
                "LastModificationDate" => items.OrderBy(s => s.LastModificationDate),
                "date_desc" => items.OrderByDescending(s => s.LastModificationDate),
                _ => items.OrderBy(s => s.Name),
            };

            Item = await items.AsNoTracking().ToListAsync();
        }
    }
}
