﻿

namespace CarRantingSystem.Controllers
{
    using CarRantingSystem.Models.Cars;
    using Microsoft.AspNetCore.Mvc;
    public class CarsController : Controller
    {
       public IActionResult Add() => View();

      [HttpPost]
      public IActionResult Add (AddCarFormModel car)
       {
           return View();
       }
    }
}
