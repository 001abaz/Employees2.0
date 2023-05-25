using Employees.Domain.Entities;
namespace Employees.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public DateTime BithDate { get; set; }
        public List<EmployeePosition> EmployeePosition { get; set; }
        public EmployeeInfo EmployeeInfo { get; set; }
    }
}