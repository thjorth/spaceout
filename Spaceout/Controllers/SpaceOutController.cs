using System.Web.Mvc;
using Spaceout.Infrastructure.Http;
using Spaceout.Helpers;

namespace Spaceout.Controllers
{
    public class SpaceOutController : Controller
    {
		protected ActionResult ViewOrJson(string viewName, string masterName, object model)
		{
			if (ControllerContext.RequestContext.HttpContext.Request.IsAjaxRequest())
			{
				return Json(new {
					Body = ControllerExtensions.RenderPartialViewToString(this, viewName, model),
					Model = model
				}, JsonRequestBehavior.AllowGet);
			}
			else
			{
				return base.View(viewName, model);
			}

			/*
			return ControllerContext.RequestContext.HttpContext.Request.IsAjaxRequest()
				? Json(ControllerExtensions.RenderPartialViewToString(this, viewName, model))
				: base.View(viewName, masterName, model);
			*/
		}

		/*
        protected override ViewResult View(string viewName, string masterName, object model)
        {
            //If AJAX request, sent a partial view
            return ControllerContext.RequestContext.HttpContext.Request.IsAjaxRequest()
                ? Json(ControllerExtensions.RenderPartialViewToString(this, viewName, model))
                : base.View(viewName, masterName, model);
        }
		 * */
    }
}