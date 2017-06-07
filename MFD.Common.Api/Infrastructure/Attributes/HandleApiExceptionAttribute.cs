using IBS.Cloud.Common.Web.WebApi.Results;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace MFD.Common.Api.Infrastructure.Attributes
{
    /// <summary>
    /// Class HandleApiExceptionAttribute is a catch-all exception filter.
    /// Taken from FredM's (http://stackoverflow.com/users/3085002/fredm) answer on stack overflow (http://stackoverflow.com/questions/16243021/return-custom-error-objects-in-web-api)
    /// </summary>
    public class HandleApiExceptionAttribute : ExceptionFilterAttribute
    {
        #region Overrides of ExceptionFilterAttribute

        /// <summary>
        /// Called (asynchronously) when an exception occurs.
        /// NOTE : this call is not executed if you have async void action in controller,
        /// but I set up *treat warnings as errors* so we should never have that issue
        /// </summary>
        /// <param name="actionExecutedContext">The action executed context.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        public override async Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            var request = actionExecutedContext.ActionContext.Request;

            if (actionExecutedContext.Exception != null)
            {
                var result = new ProblemResult(request)
                {
                    Type = "internal",
                    Title = "Unexpected server error.",
                    Detail = String.Format("There was an unexpected error while processing your request. Time was {0}.", DateTime.Now.ToString("u")),
                    Status = HttpStatusCode.InternalServerError
                };

                actionExecutedContext.Response = await result.ExecuteAsync(cancellationToken);
            }
        }

        #endregion

    }
}