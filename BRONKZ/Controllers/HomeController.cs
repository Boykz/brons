using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BRONKZ.Models;
using BRONKZ.HLPClasess;
using Microsoft.Extensions.Caching.Memory;
using LIBS;

namespace BRONKZ.Controllers
{
    public class HomeController : MainController
    {
        //private readonly Caches cachings;
        IMemoryCache memoryCache;
        public HomeController(IMemoryCache caching) : base(caching)
        {
            memoryCache = caching;           
        }      
         
        public IActionResult Index()
        {
            // ImageDraw img = new ImageDraw();
            // img.Draw();
            
            ViewBag.start = DateTime.Now;
            List<Cities> cits = getCacheData<List<Cities>>(ShareClass.cities);
            return View(cits);
             
        }

        public IActionResult About()
        {
            
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [Route("about-us")]
        public IActionResult AboutMe()
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
    }
}
