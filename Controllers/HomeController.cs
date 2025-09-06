using MetricSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MS = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TemperatureModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.MS = model.CelsiusValue;
            }
            else
            {
                ViewBag.MS = null;
            }
            return View(model);
        }
    }
}