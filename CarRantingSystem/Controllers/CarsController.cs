using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CarRantingSystem.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Add => View();

        [HttpPost]
        public IActionResult Add()
    }
}
