using Microsoft.EntityFrameworkCore;
using BankAuthApi.Models;

namespace BankAuthApi.DB;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.HasKey(x => x.Id);

            entity.HasIndex(x => x.Username)
                  .IsUnique();

            entity.HasIndex(x => x.NIC)
                  .IsUnique();
        });
    }
}