using ITOrganization.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ITOrganization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
        public ActionResult ITOrganization()
        {
            List<string> HyderabadOffice = new List<string>();
            HyderabadOffice.Add("Microsoft www.microsoft.com");
            HyderabadOffice.Add("Cognizant www.cognizant.com");
            HyderabadOffice.Add("Google");
            HyderabadOffice.Add("Amazon");
            HyderabadOffice.Add("TCS");
            return View((List<string>)HyderabadOffice);
        }
    }
}
