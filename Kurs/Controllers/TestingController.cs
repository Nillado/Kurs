using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kurs.Data;
using Kurs.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurs.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View(new UserProfile() {
                Nickname = "Nillado",
                Email = "nillado@dgva.com",
                Password = "qwerty"
            });
        }
    }
}
