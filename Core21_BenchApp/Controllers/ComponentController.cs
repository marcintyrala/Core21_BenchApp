using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core21_BenchApp.Models;

namespace Core21_BenchApp.Controllers
{
    public class ComponentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ComponentsList()
        {
            string componentsPath = @"C:\bench_backup_22-11-2019\Components";
            string searchComponentsPattern = "*.xdev";
            List<Component> listOfComponents = BenchObjectReader.ReadAllBenchObjects<Component>(componentsPath, searchComponentsPattern);
            return View(listOfComponents);
        }
    }
}