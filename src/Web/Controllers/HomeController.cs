using System.Web.Mvc;

namespace Web.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("~/", Name = "Home", Order = 1)]
        [Route("Index", Order = 2)]
        public ActionResult Index()
        {
            return View();
        }
    }
}