using System.Web.Mvc;
using Spaceout.Infrastructure.Http;

namespace Spaceout.Controllers
{
    public class SpaceOutController : Controller
    {
        protected override ViewResult View(string viewName, string masterName, object model)
        {
            //If AJAX request, sent a partial view
            return ControllerContext.RequestContext.HttpContext.Request.IsAjaxRequest()
                ? CustomPartialViewResult.Convert(PartialView(viewName, model))
                : base.View(viewName, masterName, model);
        }
    }
}