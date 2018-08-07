using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectGit.Controllers
{
    public class SriengController : Controller
    {
        // GET: Srieng
        public ActionResult Index()
        {
            ViewBag.Test = "Hello World!";
            return View();
        }
    }
}