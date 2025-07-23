using Microsoft.EntityFrameworkCore;
using GorevTakip.WebAPI.Models;

namespace GorevTakip.WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Gorev> Gorevler { get; set; }
    }
}
