using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IdentityModel.Tokens.Jwt;

namespace MFD.Common.Api.Infrastructure.Configuration
{
    /// <summary>
    /// Options for JWT token creation
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class JwtTokenOptions :  ISecureDataFormat<AuthenticationTicket>
    {
        /// <summary>
        /// The audience
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// The issuer
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Sets the value of the base 64 encoded secret used to generate signing credentials
        /// </summary>
        public string Base64Secret { get; set; }

        #region ISecureDataFormat<AuthenticationTicket> Members

        /// <summary>
        /// Protects the specified data as a JSON Web Token.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.ArgumentNullException">data</exception>
        public string Protect(AuthenticationTicket data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            DateTime? issued = null;
            DateTime? expires = null;

            if (data.Properties.IssuedUtc.HasValue)
            {
                issued = data.Properties.IssuedUtc.Value.UtcDateTime;
            }

            if (data.Properties.ExpiresUtc.HasValue)
            {
                expires = data.Properties.ExpiresUtc.Value.UtcDateTime;
            }

            var token = new JwtSecurityToken(Issuer, Audience, data.Identity.Claims, issued, expires, CreateSigningCredentials(Base64Secret));

            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.WriteToken(token);

            return jwt;
        }

        /// <summary>
        /// Unprotects the specified protected text.
        /// </summary>
        /// <param name="protectedText">The protected text.</param>
        /// <returns><see cref="AuthenticationTicket"/>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates the signing credentials instance from a base64 encoded secret.
        /// </summary>
        /// <param name="base64EncodedSecret">The secret.</param>
        /// <returns>SigningCredentials.</returns>
        private static SigningCredentials CreateSigningCredentials(string base64EncodedSecret)
        {
            var securityKey = new SymmetricSecurityKey(TextEncodings.Base64Url.Decode(base64EncodedSecret));

            var signingCredentials = new SigningCredentials(
                securityKey,
                SecurityAlgorithms.HmacSha256Signature
                );

            return signingCredentials;
        }

        #endregion
    }
}