using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class FifthController : Controller
    {
        //
        // GET: /Third/
        public ViewResult Index()
        {
            var rajesh = new Person {Name = "Rajesh", Age = 30};
            var sanjay = new Person {Name="Sanjay",Age=25};

            return View("PeopleView", new List<Person>{rajesh,sanjay});
        }
    }
}
