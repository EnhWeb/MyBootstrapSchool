using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBootstrapSchool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string username = "", string password = "")
        {
            //Request.IsAjaxRequest();
            Response.Write("Request.IsAjaxRequest()：" + Request.IsAjaxRequest().ToString()); 
            if (username != "" && password != "" && Request.HttpMethod == "POST")
            {
                Response.Write(string.Format(" | 用户名：{0} 密码：{1}", username, password));
            }


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}