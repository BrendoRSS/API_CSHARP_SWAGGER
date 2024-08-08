namespace PrimeiraAPI.Model
{
    public interface iEmployeeRepository
    {
        void Add(Employee employee);

        List<Employee> Get();
    }
}
