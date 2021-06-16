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
        public ActionResult Detail (int id)
        {
            var employees = _employeeService.GetEmployeetById(id);
            return View(employees);
        }
        public ActionResult Delete (int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction ("Index");
   
        }
        [HttpGet]
          public IActionResult Create()
        {
            return View();
        }


        [HttpPost]        
        public ActionResult Create (Employee employee)
        {
            _employeeService.Create(employee);
            return RedirectToAction ("Index");
            
        }
        [HttpGet]        public ActionResult Update(int id)
        {
            var employee = _employeeService.GetEmployeetById(id);
            return View(employee);

        }
        [HttpPost]
        public ActionResult Update (Employee employee)
        {
            _employeeService.Update(employee);
            return RedirectToAction("Index");
        }


         
      

        
    }
}
