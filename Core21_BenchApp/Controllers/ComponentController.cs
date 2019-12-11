using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core21_BenchApp.Models;

using Core21_BenchApp.Models.BenchModels.Component;

namespace Core21_BenchApp.Controllers
{
    public class ComponentController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("ComponentsList");
        }

        public IActionResult ComponentsList()
        {

            List<Component> listOfComponents =BenchObjectReader.ReadAllBenchObjects<Component>(
                 BenchProperties.BenchPath + @"\Components",
                 BenchProperties.searchComponentsPattern
                 );

            return View(listOfComponents);
        }


        [Route("Component/ComponentView/{id?}")]
        public IActionResult ComponentView(string id)
        {
            List<Component> listOfComponents = 
                BenchObjectReader.ReadAllBenchObjects<Component>(
                    BenchProperties.BenchPath + @"\Components", 
                    BenchProperties.searchComponentsPattern
                    );
            var selectedComponent = listOfComponents.Where(o => o.Name.Contains(id)).FirstOrDefault();

            //Return model to Campaign View
            var componentModel = new ComponentViewModel{ CurrentComponent = selectedComponent };

            return View(componentModel);
        }
    }
}