using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace MFD.Common.Api.Exceptions
{
    /// <summary>
    /// <see cref="HttpRequestMessageExtensions"/> adds extension messages to <see cref="HttpRequestMessage"/> instances.
    /// </summary>
    [ExcludeFromCodeCoverage] // Complexity to test doesn't outweigh the benefits here.
    public static class HttpRequestMessageExtensions
    {
        #region Static and Constants

        private const string HttpContext = "MS_HttpContext";

        private const string RemoteEndpointMessage =
            "System.ServiceModel.Channels.RemoteEndpointMessageProperty";

        private const string OwinContext = "MS_OwinContext";

        #endregion

        /// <summary>
        /// Gets the client ip address.
        /// Taken from http://stackoverflow.com/a/19849122/151445 by Nikolai Samteladze (http://stackoverflow.com/users/1267021/nikolai-samteladze)
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>System.String.</returns>
        public static string GetClientIpAddress(this HttpRequestMessage request)
        {
            try
            {
                // Web-hosting. Needs reference to System.Web.dll
                if (request.Properties.ContainsKey(HttpContext))
                {
                    dynamic ctx = request.Properties[HttpContext];
                    if (ctx != null)
                    {
                        return ctx.Request.UserHostAddress;
                    }
                }

                // Self-hosting. Needs reference to System.ServiceModel.dll. 
                if (request.Properties.ContainsKey(RemoteEndpointMessage))
                {
                    dynamic remoteEndpoint = request.Properties[RemoteEndpointMessage];
                    if (remoteEndpoint != null)
                    {
                        return remoteEndpoint.Address;
                    }
                }

                // Self-hosting using Owin. Needs reference to Microsoft.Owin.dll. 
                var owinContext = request.GetOwinContext();
                return owinContext != null ? owinContext.Request.RemoteIpAddress : null;
            }
            // ReSharper disable once CatchAllClause
            catch (Exception ex)
            {
                // Generally, we don't catch all exceptions. Getting the client's IP Address is a nicety and should never cause the app to fail, so swallow the exception.
                Debug.WriteLine("Exception while trying to get Client's IP Address: " + ex.Message);
            }

            return null;
        }
    }
}