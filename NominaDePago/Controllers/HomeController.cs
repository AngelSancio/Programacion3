using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    [Authorize]

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
