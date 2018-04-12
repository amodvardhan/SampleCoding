using System.Web.Mvc;

namespace SampleCoding.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Create new user";

            return View();
        }

        public ActionResult UserList()
        {
            ViewBag.Message = "List ofall users";

            return View();
        }
    }
}