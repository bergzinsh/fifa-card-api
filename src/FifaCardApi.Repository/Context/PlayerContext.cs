using FifaCardApi.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FifaCardApi.Domain.Context
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options) { }
        public DbSet<Player> Player { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .HasOne(a => a.Player)
                .WithMany(b => b.Cards)
                .HasForeignKey(a => a.PlayerId);
        }
    }
}
