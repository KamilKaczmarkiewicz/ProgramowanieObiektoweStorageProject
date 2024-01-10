using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
