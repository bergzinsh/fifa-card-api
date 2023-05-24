using FifaCardApi.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace FifaCardApi.Domain.Context
{
    public class PlayerContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FifaCardDB;Data Source=DESKTOP-V2MAEJ2\\SQLEXPRESS;TrustServerCertificate=Yes");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasMany(a => a.Cards)
                .WithOne(b => b.Player)
                .HasForeignKey(b => b.PlayerId);
        }
    }
}
