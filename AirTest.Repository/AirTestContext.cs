using AirTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AirTest.Repository
{
    public class AirTestContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public AirTestContext(DbContextOptions<AirTestContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("AirTest");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
        
    }
    public static class DBInitializer
    {
        public static void Initialize(AirTestContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
