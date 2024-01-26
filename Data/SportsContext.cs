using BucksSportsAcademy.Models;
using Microsoft.EntityFrameworkCore;

namespace BucksSportsAcademy.Data
{
    public class SportsContext : DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sport>().ToTable("Sport");
            modelBuilder.Entity<Fixture>().ToTable("Fixture");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}



