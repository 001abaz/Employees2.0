using Employees.Domain.Entities;
namespace Employees.Domain.Entities
{
    public class FineSalary
    {
        public int Id { get; set; }
        public int FineID { get; set; }
        public int SalaryID { get; set; }
        public Fine Fine { get; set; }
        public Salary Salary { get; set; }
    }
}