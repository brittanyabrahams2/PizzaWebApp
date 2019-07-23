using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();

        }

        public IActionResult Pizza()
        {
            return View();

        }

        public IActionResult Wings()
        {
            return View();

        }

        public IActionResult Desserts()
        {
            return View();

        }
    }
}
