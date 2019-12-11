using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core21_BenchApp.Models.BenchModels.Test;
using Core21_BenchApp.Models;

namespace Core21_BenchApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult TestsList()
        {
            List<TestDescription> listOfTests = BenchObjectReader.ReadAllBenchObjects<TestDescription>(
                BenchProperties.BenchPath + BenchProperties.TestsPath, 
                BenchProperties.searchTestsPattern
                );
            return View(listOfTests);
        }
    }
}