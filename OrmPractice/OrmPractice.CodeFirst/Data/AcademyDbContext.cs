
using Microsoft.EntityFrameworkCore;
using OrmPractice.CodeFirst.Models;

namespace OrmPractice.CodeFirst.Data
{
    internal class AcademyDbContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=AcademyDb2;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
