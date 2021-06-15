using System.Linq;
using asp.Models;
using Asp.Data;
using Microsoft.AspNetCore.Mvc;


namespace asp.Controllers
{
    public class MoviesController : Controller
    {

        public readonly DataContext _context;
        public MoviesController(DataContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var movies = _context.Movies.FirstOrDefault(n => n.Name =="Goole ");
            if(movies == null)
            {
                return BadRequest("Van oc cho");
            }
            return View(movies);
        }

        

    }
}