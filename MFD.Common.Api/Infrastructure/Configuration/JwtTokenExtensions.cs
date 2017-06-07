using System;
using System.Configuration;

namespace MFD.Common.Api.Infrastructure.Configuration
{
    public static class JwtTokenExtensions
    {
        /// <summary>
        /// Gets the token expiration time in minutes (from config or default).
        /// </summary>
        /// <returns>System.Int32.</returns>
        public static TimeSpan GetTokenExpiredTime(this JwtTokenOptions options)
        {
            int tokenExpirationMinutes;
            if (!int.TryParse(ConfigurationManager.AppSettings["jwt:TokenExpirationMinutes"], out tokenExpirationMinutes))
            {
                tokenExpirationMinutes = 60;
            }
            else
            {
                // JSON will have a problem if the value here is too large (OAuth's expires_in is in seconds).
                // so, limit to 60 < setting < 19999999
                tokenExpirationMinutes = Math.Min(Math.Max(60, tokenExpirationMinutes), 19999999);
            }

            return TimeSpan.FromMinutes(tokenExpirationMinutes);
        }
    }
}