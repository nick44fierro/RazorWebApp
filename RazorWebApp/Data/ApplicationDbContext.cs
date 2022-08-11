using Microsoft.EntityFrameworkCore;
using RazorWebApp.Model;

namespace RazorWebApp.Data
{
    public class ApplicationDbContext : DbContext // DbContext class from EntityFrameworkCore - for accessing and managing database
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }

        // need to configure DbSet to use connection string in appsetting.json
        // done in program.cs
    }
}
