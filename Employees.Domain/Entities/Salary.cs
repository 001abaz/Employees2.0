using Employees.Domain.Entities;
namespace Employees.Domain.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public decimal EmployeeSalary { get; set; }
        public string CardNumber { get; set; }
        public decimal Bonus { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public List<FineSalary> FineSalary { get; set; }

    }
}