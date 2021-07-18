using Microsoft.AspNetCore.Mvc;
using MVC_App_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_App_Test.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek! " };

            return View(movie);
        }
    }
}
