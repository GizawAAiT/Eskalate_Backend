using Eskalate_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Eskalate_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Team>? Teams { get; set; }
   
       
   public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    }
}
