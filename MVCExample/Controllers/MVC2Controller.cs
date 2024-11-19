using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class MVC2Controller : Controller
    {
        // GET: MVC2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return RedirectToAction("Index");
        }
    }
}