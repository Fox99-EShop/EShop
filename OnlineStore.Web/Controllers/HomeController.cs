using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Data;
namespace OnlineStore.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var contxt = new ApplicationContext();
            var users = contxt.Users.Count();
            ViewBag.UserCount = users;
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