using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRONKZ.Areas.Apartments.Controllers
{
    [Area("Apartments")]
    public class ApartmentController : Controller
    {
        // GET: Apartment
        public ActionResult Show()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }





    }
}