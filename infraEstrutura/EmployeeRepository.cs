using PrimeiraAPI.Model;

namespace PrimeiraAPI.infraEstrutura
{
    public class EmployeeRepository : iEmployeeRepository
    {
        private readonly conexaoDb _context = new conexaoDb();

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }
    }
}
