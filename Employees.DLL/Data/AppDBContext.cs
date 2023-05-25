using Employees.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Employees.DLL.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }
       
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<EmployeePosition> EmployeePosition { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<FineSalary> FineSalary { get; set; }
        public DbSet<Fine> Fine { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}
