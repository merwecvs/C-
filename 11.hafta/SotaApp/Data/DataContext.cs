using Microsoft.EntityFrameworkCore;
namespace SotaApp.Data{
    public class DataContext: DbContext{
        public DataContext(DbContextOptions<DataContext>options):base(options){}
        public DbSet<Musteri> Musteriler =>Set<Musteri>();
        public DbSet<Urun> Urunler =>Set<Urun>();
        public DbSet<Satis>Satislar => Set<Satis>();
        public DbSet<Satici>Saticilar => Set<Satici>();
    }
}