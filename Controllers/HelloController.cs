using asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Index ()
        {
            var a = new Hello(){
                Id = 1 ,
                Name="Anh dang ven"
            };
            return View(a);
        }
    }
}