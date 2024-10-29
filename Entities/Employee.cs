namespace EmployeeAccounting.Entities;

public class Employee
{
    public int Id { get; set; } = LastId++;
    public string Name { get; set; }
    public string Position { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    
    private static int LastId { get; set; }
}