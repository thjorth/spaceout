using System.Web.Mvc;

namespace Spaceout.Infrastructure.Filters
{
    public class MetaDataFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var title = filterContext.Controller.ViewBag.Title;

            filterContext.HttpContext.Response.AppendHeader("X-Title", title);

            base.OnActionExecuted(filterContext);
        }
    }
}