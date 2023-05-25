namespace Employees.Domain.Entities
{
    public class EmployeeInfo
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Experience { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public void Add(EmployeeInfo employeeInfo)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IQueryable<EmployeeInfo> employeeInfos)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}