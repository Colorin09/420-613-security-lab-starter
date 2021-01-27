using System.Web;
using System.Web.Optimization;
using System.Web.Mvc;

namespace SecurityLab1_Starter
{
    //Testing a custom filter to handle 500 error
    public class MyHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            filterContext.HttpContext.Response.TrySkipIisCustomErrors = false;
        }
    }
}
