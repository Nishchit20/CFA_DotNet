using Microsoft.EntityFrameworkCore;
using CFA_Dot_Net.Models;

namespace CFA_Dot_Net.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
