using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Web.Mailers;
using Web.Models;

namespace Web.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        private readonly IContactMailer contactMailer;

        public HomeController()
             : this(new ContactMailer())
        {
        }
        public HomeController (IContactMailer contactMailer)
        {
            this.contactMailer = contactMailer;
        }

        [Route("~/", Name = "Home", Order = 1)]
        [Route("Index", Order = 2)]
        public ActionResult Index()
        {
            ViewBag.Title = "Personal vCard";

            return View();
        }

        [HttpPost]
        [Route("Contact")]
        public async Task<ActionResult> Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                await this.contactMailer.Send(model).SendAsync();
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
    }
}