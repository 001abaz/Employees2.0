using Employees.Domain.Entities;
namespace Employees.Domain.Entities
{
    public class Fine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public FineSalary FineSalary { get; set; }
    }
}