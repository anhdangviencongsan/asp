using asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class EmployeeController :Controller
    {
        public ViewResult Index ()
        {
            var employee = new Employee {
                ID = 1 , Name = "Van"
            };
            return View(employee);
        }

        
    }
}
