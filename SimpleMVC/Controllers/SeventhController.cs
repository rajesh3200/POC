using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class SeventhController : Controller
    {
        // GET: /Seventh/
        public ActionResult Index()
        {
            return View("CustomView");
        }
    }
}
