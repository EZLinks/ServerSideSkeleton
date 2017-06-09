using IBS.Cloud.Common.Utils.Utilities;
using IBS.Cloud.Common.Web.Mvc.Core.Results;
using MFD.Api.Resources;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace MFD.Common.Api.Filters
{
    /// <summary> 
    /// The global exception filter. 
    /// </summary> 
    [ExcludeFromCodeCoverage]
    public class GlobalExceptionFilter : IExceptionFilter
    {
        /// <summary> 
        /// The logger. 
        /// </summary> 
        private readonly ILogger _logger;

        /// <summary> 
        /// Initializes a new instance of the <see cref="GlobalExceptionFilter"/> class. 
        /// </summary> 
        /// <param name="logger"> 
        /// The logger. 
        /// </param> 
        /// <exception cref="ArgumentNullException"> 
        /// If logger is null. 
        /// </exception> 
        public GlobalExceptionFilter(ILoggerFactory logger)
        {
            ArgumentUtilities.CheckNull(logger, nameof(logger));

            _logger = logger.CreateLogger<GlobalExceptionFilter>();
        }

        /// <summary> 
        /// The on exception action. 
        /// </summary> 
        /// <param name="context"> 
        /// The context. 
        /// </param> 
        public void OnException(ExceptionContext context)
        {
            context.Result = new ProblemResult
            {
                Status = HttpStatusCode.InternalServerError,
                Detail = ResponseMessages.GenericErrorDetail,
            };

            _logger.LogError(ResponseMessages.GenericErrorDetail, context.Exception);
        }
    }
}