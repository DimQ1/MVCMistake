using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var testUser = new UserModel { Id = "1", Name = "test0000" };
            return View("~/Views/Home/Index.cshtml", testUser);
        }
        [HttpPost]
        public ActionResult CheckBag(UserModel user)
        {
            if (ModelState.IsValid)
            {

            }
            var testUser = new UserModel { Id = "2", Name = "test33333" };
            return View("~/Views/Home/Index.cshtml", testUser);
        }
    }
}