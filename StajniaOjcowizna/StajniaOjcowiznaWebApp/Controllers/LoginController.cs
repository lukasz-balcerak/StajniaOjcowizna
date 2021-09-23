using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StajniaOjcowiznaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
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
        public IActionResult LogInSubbmit(LoginModel loginUser)
        {
            var emailAddress = loginUser.EmailAddress;
            var password = loginUser.Password;
            var users = _db.Instructors;
            var userInDataBase = users.FirstOrDefault(e => e.Email == emailAddress);
            if (userInDataBase != null && userInDataBase.Password == password)
            {
                return View("LogInSukces");
            }
            return View("LogInError");
        }
        public IActionResult LogIn()
        {
            return View();
        }

    }
}
