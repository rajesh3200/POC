using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class FourthController : Controller
    {
        //
        // GET: /Third/
        public ActionResult Index()
        {
            ViewBag.DemoTitle = "Demo Sample"; // provides a way to pass extra data from Controller
            var rajesh = new Person { Name = "Rajesh", Age = 25 };
            return View("PersonView", rajesh);

            // we could also render a view which is in a different controller as like below,
            //return View("../Movies/AddMovie", model); - Movies is a different controller

            //another option to render a absolute URL
            //string CurrentURL = Request.Url.AbsoluteUri;
            //return View(CurrentURL);

            //or we could redirect to an external url
            //return Redirect("http://www.google.com");

            // string ipAddress2 = Request.UserHostAddress; string ipAddress = Request.ServerVariables["REMOTE_ADDR"];

            // To retrieve the current domain name //string Domain = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host + (Request.Url.IsDefaultPort ? "" : ":" + Request.Url.Port);

        }
    }
}
