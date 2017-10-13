using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc;

namespace barcode_generator.Areas.BarcodeGenerator.Controllers
{
    public class HomeController : Controller
    {
        // GET: BarcodeGenerator/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}