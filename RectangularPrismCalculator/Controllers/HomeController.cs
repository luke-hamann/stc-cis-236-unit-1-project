﻿/*
    Name: Luke Hamann
    Date: 2024-09-12
    Purpose: The HomeController class provides the main controller for the
             application. It includes action methods for getting a blank copy
             of the index calculator form, posting to run calculations based on
             inputs to the index calculator form, and getting the about page.
*/
using Microsoft.AspNetCore.Mvc;
using RectangularPrismCalculator.Models;

namespace RectangularPrismCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RectangularPrism prism)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Volume = prism.Volume;
                ViewBag.SurfaceArea = prism.SurfaceArea;
                ViewBag.Diagonal = prism.Diagonal;
            }

            return View(prism);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
    }
}
