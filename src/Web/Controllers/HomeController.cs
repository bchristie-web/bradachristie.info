using System;
using System.Net;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("~/", Name = "Home", Order = 1)]
        [Route("Index", Order = 2)]
        public ActionResult Index()
        {
            ViewBag.Title = "Personal vCard";

            return View();
        }

        [HttpPost]
        [Route("Contact")]
        public ActionResult Contact(ContactViewModel model)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            if (ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
    }
}