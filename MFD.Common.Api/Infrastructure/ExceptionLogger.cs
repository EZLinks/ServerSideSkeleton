using IBS.Logging;
using MFD.Common.Api.Exceptions;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace MFD.Common.Api.Infrastructure
{
    /// <summary>
    /// exception class for logger
    /// </summary>
    /// <seealso cref="System.Web.Http.ExceptionHandling.IExceptionLogger" />
    [ExcludeFromCodeCoverage]
    public class ExceptionLogger : IExceptionLogger
    {
        #region IExceptionLogger Members

        #region Implementation of IExceptionLogger

        /// <summary>
        /// Logs an unhandled exception.
        /// </summary>
        /// <returns>
        /// A task representing the asynchronous exception logging operation.
        /// </returns>
        /// <param name="context">The exception logger context.</param><param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="System.Security.SecurityException">The caller does not have the permission required to set the principal. </exception>
        public Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            if (context.ExceptionContext.ControllerContext != null)
            {
                ILog logger = LogManager.GetLogger(context.ExceptionContext.ControllerContext.Controller.GetType());

                try
                {
                    ClaimsPrincipal identity = Thread.CurrentPrincipal as ClaimsPrincipal;
                    if (identity != null)
                    {
                        logger.SetContext("AuditLogin", identity.Identity.Name);
                        logger.SetContext("EventCategory", "UnhandledError");
                        logger.SetContext("EventType", "Error");
                        logger.SetContext("IPAddress", context.Request.GetClientIpAddress());
                    }
                }
                // ReSharper disable once CatchAllClause
                catch
                {
                    // swallow uncaught exceptions so we actually log our unhandled exception. Better to have exception text and no extras than nothing at all.
                }

                logger.Exception(context.Exception, "Unhandled Exception.");
            }

            Debug.WriteLine("Log Exception Type: {0}, Originated: {1}, URL: {2}",
                context.Exception.GetType(),
                context.CatchBlock,
                context.Request.RequestUri);

            return Task.FromResult<object>(null);
        }

        #endregion

        #endregion
    }
}