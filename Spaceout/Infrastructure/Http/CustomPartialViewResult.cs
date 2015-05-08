using System.Web.Mvc;

namespace Spaceout.Infrastructure.Http
{
    public class CustomPartialViewResult : ViewResult
    {
        public ViewResultBase Res { get; set; }

        public CustomPartialViewResult(ViewResultBase res)
        {
            Res = res;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            Res.ExecuteResult(context);
        }
        public static ViewResult Convert(ViewResultBase res)
        {
            return new CustomPartialViewResult(res);
        }
    }
}