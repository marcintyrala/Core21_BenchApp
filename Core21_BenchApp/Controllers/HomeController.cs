using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core21_BenchApp.Models;

namespace Core21_BenchApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel()
            {
            BenchPath = BenchProperties.BenchPath
            };
            ViewBag.Message = indexViewModel;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       [HttpPost]
       // [Route("Home/ChangePath/{searchText}")]
        public ActionResult Index(IndexViewModel model)
        {
            BenchProperties.BenchPath = model.BenchPath;
            ViewBag.Message = model;
            return View();
        }

        [HttpPost]
        // [Route("Home/ChangePath/{searchText}")]
        public ActionResult BenchDefaultValue()
        {
            BenchProperties.BenchPath = BenchProperties.BenchPathDefaultValue;
            return RedirectToAction("Index");
        }


    }
}
