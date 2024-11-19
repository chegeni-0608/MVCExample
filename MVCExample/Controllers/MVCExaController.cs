using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class MVCExaController : Controller
    {
        // GET: MVCExa
        public ActionResult Index()
        {
            return View();
        }
    }
}