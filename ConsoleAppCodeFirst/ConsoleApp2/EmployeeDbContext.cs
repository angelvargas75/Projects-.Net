using System.Data.Entity;

namespace ConsoleApp2
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("name=conDemo1EF")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
