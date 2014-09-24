using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoSurfaceTest.Controllers
{
    public class DemoController : SurfaceController
    {
        // url ~/umbraco/surface/Demo/Index/You
        public ActionResult Index(string id)
        {
            return Content("hello " + id + "!");
        }

        // url ~/umbraco/surface/Demo/ViewTest
        public ActionResult ViewTest()
        {
            return View();
        }
    }
}