using asp.Models;
using asp.Services;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class EmployeeController :Controller
    {
       private readonly IEmployeeService _employeeService ; 
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService ;
        }
        public ActionResult Index ()
        {
            var employees = _employeeService.GetAll();
            return View(employees);
        }

        
    }
}
