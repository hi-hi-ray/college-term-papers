using System.Web.Mvc;

namespace KeepEverything.Consumer.RaysaDutra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
