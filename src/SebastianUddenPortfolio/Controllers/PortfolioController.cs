using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SebastianUddenPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Minesweeper()
        {
            return View();
        }

        public IActionResult WeatherApp()
        {
            return View();
        }

        public IActionResult PhotoSlider()
        {
            return View();
        }
    }
}
