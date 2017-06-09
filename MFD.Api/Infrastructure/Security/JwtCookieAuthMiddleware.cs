using MFD.Common.Api.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MFD.Api.Infrastructure.Security
{
    /// <summary>
    /// Middleware to intercept access tokens in cookies and add an authorization header instead
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class JwtCookieAuthMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        /// Creates a new instance of JwtCookieAuthMiddleware
        /// </summary>
        /// <param name="next">Next delegate</param>
        public JwtCookieAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Implementation of Invoke for the middleware
        /// </summary>
        /// <param name="context">The context</param>
        /// <returns>A Task</returns>
        public async Task Invoke(HttpContext context)
        {
            // if the request is providing an authorization header, use that and ignore the cookie
            if (!context.Request.Headers.ContainsKey(SecurityConstants.AuthHeader))
            {
                var cookie = context.Request.Cookies[SecurityConstants.AuthCookieName];
                if (cookie != null)
                {
                    context.Request.Headers.Append(SecurityConstants.AuthHeader, $"Bearer {cookie}");
                }
            }

            await _next.Invoke(context);
        }
    }
}
