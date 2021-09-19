using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StajniaOjcowiznaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using SODataAccessLibrary.DataAccess;
using SODataAccessLibrary.Models;

namespace StajniaOjcowiznaWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly LessonContext _db;

        public LoginController(ILogger<LoginController> logger, LessonContext db)
        {
            _logger = logger;
            _db = db;
        }

        private void LoadSampleData()
        {
            if (_db.Instructors.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("generated.json");
                var instructor = JsonSerializer.Deserialize<List<Instructor>>(file);
                _db.AddRange(instructor);
                _db.SaveChanges();
            }
        }

        public IActionResult Login()
        {
            LoadSampleData();
            return View();
        }

    }
}
