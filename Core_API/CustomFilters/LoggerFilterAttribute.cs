using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Core_API.CustomFilters
{
    public class LoggerFilterAttribute : ActionFilterAttribute
    {
        private void LogRequest(string currentExecutionState, RouteData route)
        {
            string controllerName = route.Values["controller"].ToString();
            string actionName = route.Values["action"].ToString();

            string logMessage = $"Current State of Execution is {currentExecutionState} in {actionName} action method of the {controllerName} controller";

            // Log it

            Debug.WriteLine(logMessage);
        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            LogRequest("OnActionExecuting", context.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            LogRequest("OnActionExecuted", context.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            LogRequest("OnResultExecuting", context.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            LogRequest("OnResultExecuted", context.RouteData);
        }
    }
}
