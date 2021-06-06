using asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class MoviesController:Controller
    {

        public ActionResult Index ()
        {
            var movie = new Movie ()
            {
                Name = "Amazon"
            };
            return View (movie);
        }
        public ActionResult Edit (int id)
        {
            return Content ("id="+id);
        }
}
}