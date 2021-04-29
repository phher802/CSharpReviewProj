using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!", Genre = "Animation", Director = "Andrew Adamson" };
            return View(movie);
        }
    }
}
