using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StajniaOjcowiznaWebApp.Models;

namespace StajniaOjcowiznaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(InstructorModel user)
        {
            ViewData["FirstName"] = user.FirstName;
            ViewData["LastName"] = user.LastName;
            ViewData["Role"] = user.Role;
            return View();
        }
    }
}
