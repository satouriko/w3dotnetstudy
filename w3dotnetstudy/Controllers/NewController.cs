using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace w3dotnetstudy.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }

        // GET: New
        public ActionResult ShowName(string name)
        {
            return View();
        }
    }
}