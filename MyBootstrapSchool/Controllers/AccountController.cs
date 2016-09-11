using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBootstrapSchool.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]//防止CSRF攻击
        [HttpPost]
        public ActionResult Register(string username = "", string password = "")
        {
            string result = "<h1>测式</h1>";


            // application/json  
            return Content(result, "text/html", System.Text.Encoding.UTF8);
        }
    }
}