using System.Web.Mvc;

namespace Spaceout.Controllers
{
	public class HomeController : SpaceOutController
	{
        public ViewResult Index()
        {
            ViewBag.Title = "Home";
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
		}

		public ActionResult About()
		{
            ViewBag.Title = "About";
			ViewBag.Message = "Your app description page.";

            return View();
		}

		public ActionResult Contact()
		{
            ViewBag.Title = "Contact";
			ViewBag.Message = "Your contact page.";

            return View();
		}
	}
}
