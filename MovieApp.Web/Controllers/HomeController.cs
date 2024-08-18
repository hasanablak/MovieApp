using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
          

            return View();
        }
    }
}
