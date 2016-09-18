using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBootstrapSchool.Areas.Manage.Controllers
{
    public class ConfigController : Controller
    {
        // GET: Manage/Config
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string SkinName)
        {

                //Response.Write("ace.settings 为空");

            HttpCookie cookie = new HttpCookie("ace.SkinId", string.Format(" class=\"{0}\"", SkinName)) { Expires = DateTime.Now.AddDays(300) };
                Response.Cookies.Add(cookie);

            var result = new {
                data = "ok",
                status = "success",
            };

            return Json(result, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.DenyGet);

        }
    }
}