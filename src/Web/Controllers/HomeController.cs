using System.Web.Mvc;

namespace Web.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("~/", Name = "Home")]
        [Route("Index")]
        public ActionResult Index()
        {
            return Content("Hello, world!");
        }
    }
}