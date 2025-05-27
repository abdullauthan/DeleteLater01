using DeleteLater01.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DeleteLater01.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=EmployeeAttendance;TrustServerCertificate=True;Integrated Security=True;");
        }

        public DbSet<Employee> EmployeeData { get; set; }
    }
}
