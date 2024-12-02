using Academy.Core.Entities;
using Academy.Data.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Academy.Data
{
    public class AcademyDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=AcademyDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
         } 
    }
}
