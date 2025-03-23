using Microsoft.EntityFrameworkCore;
using Greta_MVC.Models; // 👈 Būtinai pridėkite šią eilutę!

namespace Greta_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Student");
        }

        public DbSet<Student> Student { get; set; }
    }
}
