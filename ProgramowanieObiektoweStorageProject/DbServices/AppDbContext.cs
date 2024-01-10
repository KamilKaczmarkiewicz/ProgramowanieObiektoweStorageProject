using Microsoft.EntityFrameworkCore;
using ProgramowanieObiektoweStorageProject.Models;

namespace ProgramowanieObiektoweStorageProject.DbServices
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
    }
}
