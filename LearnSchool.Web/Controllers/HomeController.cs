using System.Web.Mvc;

namespace LearnSchool.Web.Controllers
{
    public class HomeController : LearnSchoolControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}