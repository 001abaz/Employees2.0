using Employees.Domain.Entities;
namespace Employees.Domain.Entities
{
    public class Position
    {
        public int PositionId { get; set; }
        public int Name { get; set; }
        public int Schedule { get; set; }
        public List<EmployeePosition> EmployeePosition { get; set; }
    }
}