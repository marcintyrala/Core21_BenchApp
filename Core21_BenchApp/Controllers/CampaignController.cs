using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core21_BenchApp.Models;

namespace Core21_BenchApp.Controllers
{
    public class CampaignController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CampaignsList()
        {
            List<CampaignDescription> listOfCampaigns = BenchObjectReader.ReadAllBenchObjects<CampaignDescription>(BenchProperties.BenchPath +@"\Campaigns", BenchProperties.searchCampaignsPattern);
            return View(listOfCampaigns);
        }

        // GET: Campaign/campaignName

        [Route("Campaign/CampaignView/{id?}")]
        public IActionResult CampaignView( string id)
        {
            List<CampaignDescription> listOfCampaigns = BenchObjectReader.ReadAllBenchObjects<CampaignDescription>(BenchProperties.BenchPath + @"\Campaigns", BenchProperties.searchCampaignsPattern);
            var selectedCampaign = listOfCampaigns.Where(o => o.Name.Contains(id)).FirstOrDefault() ;
            var currentParameters = BenchObjectReader.ReadBenchObject<Parameters>(selectedCampaign.FolderPath.ToString() + @"\CampComp.xpar");

            //Return model to Campaign View
            var model = new CampaignViewModel { CurrentParameters = currentParameters, CurrentCampaignDescription = selectedCampaign };
            return View(model);
        }


        


    }
}