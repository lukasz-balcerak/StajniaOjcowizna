using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StajniaOjcowiznaWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using SODataAccessLibrary.DataAccess;
using SODataAccessLibrary.Models;


namespace StajniaOjcowiznaWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly LessonContext _db;
        private readonly string _conn;
        public LoginController(ILogger<LoginController> logger, LessonContext db, IConfiguration configuration)
        {
            _logger = logger;
            _db = db;
            _conn = configuration.GetConnectionString("Default");
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

        [HttpPost]
        public IActionResult LogInSubbmit(LoginModel loginUser)
        {

            var emailAddress = loginUser.EmailAddress;
            var password = loginUser.Password;
            var users = _db.Instructors;
            var userInDataBase = users.FirstOrDefault(e => e.Email == emailAddress);
            if (userInDataBase != null && userInDataBase.Password == password)
            {
                var user = new InstructorModel()
                {
                    FirstName = userInDataBase.FirstName,
                    LastName = userInDataBase.LastName,
                    Role = "Instructor"
                };
                return RedirectToAction("Index", "Home", user);
            }

            return RedirectToAction("LogIn", new { isInDB = "false"});
        }

        public IActionResult LogIn(string isInDB)
        {
            if (isInDB == "false")
            {
                LoadSampleData();
                ViewData["Style"] = "";
                return View();
            }
            else
            {
                ViewData["Style"] = "hide";
                return View();
            }
        }
    }
}
