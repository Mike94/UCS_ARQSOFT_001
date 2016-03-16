using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using SGI.MVCCliente.Controllers.Filters;

namespace SGI.MVCCliente.Controllers
{
    public class HomeController : Controller
    {
        [RequiresAuthenticationAttribute]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

    }
}
