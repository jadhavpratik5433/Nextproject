using Microsoft.EntityFrameworkCore;
using Nextproject.Models;

namespace Nextproject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Emploee> Employees { get; set; }
    }
}
