using IBS.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MFD.Common.Api.Infrastructure.Handlers
{
    /// <summary>
    /// handler to validate json web token
    /// </summary>
    public class JsonWebTokenValidationHandler : DelegatingHandler
    {
        #region Static and Constants

        private const string GenericErrorMessage = "An error has occurred.";

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the audience.
        /// </summary>
        /// <value>
        /// The audience.
        /// </value>
        public string Audience { get; set; }

        /// <summary>
        /// Gets or sets the issuer.
        /// </summary>
        /// <value>
        /// The issuer.
        /// </value>
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the symmetric key.
        /// </summary>
        /// <value>
        /// The symmetric key.
        /// </value>
        public string SymmetricKey { get; set; }

        #endregion

        private static bool TryRetrieveToken(HttpRequestMessage request, out string token)
        {
            token = null;
            IEnumerable<string> authzHeaders;

            if (!request.Headers.TryGetValues("Authorization", out authzHeaders) || authzHeaders.Count() > 1)
            {
                // Fail if no Authorization header or more than one Authorization headers  
                // are found in the HTTP request  
                return false;
            }

            // Remove the bearer token scheme prefix and return the rest as ACS token  
            var bearerToken = authzHeaders.ElementAt(0);
            token = bearerToken.StartsWith("Bearer ") ? bearerToken.Substring(7) : bearerToken;

            return true;
        }

        /// <summary>
        /// Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string token;
            HttpResponseMessage errorResponse = null;

            if (TryRetrieveToken(request, out token))
            {
                Exception exception = null;
                try
                {
                    var secret = SymmetricKey.Replace('-', '+').Replace('_', '/');

                    Thread.CurrentPrincipal = JsonWebToken.ValidateToken(
                        token,
                        secret, Audience, true, Issuer);

                    // check if the token has been revoked.
                    ClaimsPrincipal identity = Thread.CurrentPrincipal as ClaimsPrincipal;
                    if (identity != null)
                    {
                        IInMemoryState state = new InMemoryState();
                        // Check for revocation here.
                    }


                    if (HttpContext.Current != null)
                    {
                        HttpContext.Current.User = Thread.CurrentPrincipal;
                    }
                }
                catch (Exception ex)
                {
                    exception = ex;
                    errorResponse = request.CreateErrorResponse(HttpStatusCode.InternalServerError, GenericErrorMessage);
                }

                if (exception != null)
                {
                    var log = LogManager.GetLogger(GetType());
                    log.Exception(exception, "Token validation failed.");
                    Trace.TraceError(exception.Message);
                }
            }

            return errorResponse != null
                ? Task.FromResult(errorResponse)
                : base.SendAsync(request, cancellationToken);
        }
    }
}