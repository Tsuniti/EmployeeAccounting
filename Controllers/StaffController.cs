using EmployeeAccounting.Models;
using EmployeeAccounting.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace EmployeeAccounting.Controllers;

public class StaffController : Controller
{
    private readonly EmployeeStorage _employeeStorage;

    public StaffController(EmployeeStorage employeeStorage)
    {
        _employeeStorage = employeeStorage;
    }
    
    public IActionResult Form()
    {
        ViewBag.ErrorMessage = TempData["ErrorMessage"];
        return View();
    }
    
    public IActionResult All()
    {
        var model = new EmployeesViewModel
        {
            Employees = _employeeStorage.GetAll()
        };

        return View(model);
    }

    public IActionResult Employee([FromQuery] int id)
    {
        var model = new EmployeeViewModel
        {
            Employee = _employeeStorage.GetAll().FirstOrDefault(e => e.Id == id) 
        };
        
        return View(model);
    }
    
    [HttpPost]
    public IActionResult HandleOrder(string name, string position, int age, string email)
    {
        
        _employeeStorage.Add(name, position, age, email);

        return RedirectToAction(nameof(Form));
    }
}