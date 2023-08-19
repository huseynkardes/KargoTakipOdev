using KargoTakip_Egitim_1.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace KargoTakip_Egitim_1.Data.Context
{
    public class ApplicationDbContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O0UGV37;Database=KargoTakipDb;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
    }
}
