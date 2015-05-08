using System.Web.Mvc;

namespace Spaceout.Controllers
{
	public class HomeController : SpaceOutController
	{
        public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return ViewOrJson("Index", "", new { Title = "Home page" });
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return ViewOrJson("About", "", new { Title = "About page" });
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return ViewOrJson("Contact", "", new { Title = "Contact page" });
		}
	}
}
