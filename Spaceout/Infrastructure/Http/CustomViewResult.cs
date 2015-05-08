using System.Web.Mvc;

namespace Spaceout.Infrastructure.Http
{
    public class DynamicResult : ActionResult
    {
        public string ViewName { get; set; }

        public DynamicResult()
        {
            
        }

        public DynamicResult(string viewName)
        {
            ViewName = viewName;
        }
        

        public override void ExecuteResult(ControllerContext context)
        {
            var usePartial = context.HttpContext.Request.IsAjaxRequest();
            ActionResult res = GetInnerViewResult(usePartial);
            res.ExecuteResult(context);
        }

        private ActionResult GetInnerViewResult(bool usePartial)
        {
            var view = ViewName;
            ViewResult res = new ViewResult();

            /*if (string.IsNullOrEmpty(view))
                res = usePartial ? new PartialViewResult {} : new ViewResult();
            else
                res = usePartial ? new PartialViewResult() : new ViewResult();*/

            return res;
        }
    }
}