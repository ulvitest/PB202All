using FrontoBackSqlConnection.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FrontoBackSqlConnection.Data
{
    public class MentorAppDbContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingServices> PricingServices { get; set; }
        public MentorAppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfiguration(new PricingConfiguration());
            //modelBuilder.Entity<Pricing>().Property(p => p.Price).HasColumnType("decimal(18,2)");
        }
    }
}
