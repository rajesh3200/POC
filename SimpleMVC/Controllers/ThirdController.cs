using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class ThirdController : Controller
    {
        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        //
        // GET: /Third/
        public JsonResult Index()
        {
            //string sampleJson = "[{\"Title\":\"Fantastic Four\",\"Count\":2},{\"Title\":\"Superman\",\"Count\":1},{\"Title\":\"Thor\",\"Count\":2}]";
            //return Json(sampleJson, JsonRequestBehavior.AllowGet);

            var people = new List<Person>();
            people.Add(new Person{Age=30,Name="Rajesh"});
            people.Add(new Person { Age = 26, Name = "Sanjay" });
            return Json(people, JsonRequestBehavior.AllowGet);
        }
    }
}
