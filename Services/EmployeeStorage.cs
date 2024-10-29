using EmployeeAccounting.Entities;

namespace EmployeeAccounting.Services;

public class EmployeeStorage
{
    private readonly List<Employee> _employees = new();
    
    public IEnumerable<Employee> GetAll()
        => _employees;
    
    public void Add(string name, string position, int age, string email)
    {
        _employees.Add(new Employee
        {
            Name = name,
            Position = position,
            Age = age,
            Email = email
        });
    }
}