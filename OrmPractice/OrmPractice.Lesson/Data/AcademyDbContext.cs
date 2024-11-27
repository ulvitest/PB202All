
using Microsoft.EntityFrameworkCore;
using OrmPractice.Lesson.Models;

namespace OrmPractice.Lesson.Data
{
    internal class AcademyDbContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=AcademyDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}
