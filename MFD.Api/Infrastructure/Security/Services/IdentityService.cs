using IBS.Cloud.Common.Utils.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MFD.Common.Api.Constants;
using MFD.Common.Api.Security.Models;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Builder;
using Microsoft.IdentityModel.Tokens;
using System.Security.Principal;
using MFD.Domain.Models;

namespace MFD.Common.Api.Security.Services
{
    /// <summary> 
    /// A service used to manage a user's identity 
    /// </summary> 
    [ExcludeFromCodeCoverage]
    public class IdentityService : IIdentityService
    {
        /// <summary> 
        /// The token options. 
        /// </summary> 
        private readonly JwtTokenOptions _tokenOptions;

        /// <summary> 
        /// The constructor. 
        /// </summary> 
        /// <param name="tokenOptions">The options required to construct a token.</param> 
        public IdentityService(IOptions<JwtTokenOptions> tokenOptions)
        {
            _tokenOptions = tokenOptions.Value;
        }

        /// <summary> 
        /// Gets the token. 
        /// </summary> 
        /// <param name="context">The context.</param> 
        /// <returns>The token model.</returns> 
        private JwtToken GetToken(HttpContext context)
        {
            ArgumentUtilities.CheckNull(context, nameof(context));

            return new JwtToken(context.User);
        }

        /// <summary> 
        /// Gets a user's claims identity. 
        /// </summary> 
        /// <param name="user">The user to create the identity for.</param> 
        /// <returns>A <see cref="ClaimsIdentity"/>.</returns> 
        public ClaimsIdentity GetIdentity(User user)
        {
            var claims = new[]
            {
                new Claim(SecurityConstants.UserIdClaim, user.Id.ToString()),
            };

            var identity = new ClaimsIdentity(new GenericIdentity(user.Email, "TokenAuth"), claims);

            return identity;
        }

        /// <summary> 
        /// Creates a token based off of the given user. 
        /// </summary> 
        /// <param name="user">The user to create a token for.</param> 
        /// <returns>The token string.</returns> 
        public string CreateToken(User user)
        {
            var handler = new JwtSecurityTokenHandler();

            var identity = GetIdentity(user);
            var credentials = CreateCredentials(_tokenOptions.Base64Secret);

            var securityToken = handler.CreateEncodedJwt(
                issuer: _tokenOptions.Issuer,
                audience: _tokenOptions.Audience,
                signingCredentials: credentials,
                subject: identity,
                expires: DateTime.UtcNow.AddDays(1),
                issuedAt: DateTime.UtcNow,
                notBefore: null);

            return securityToken;
        }

        /// <summary> 
        /// Creates a JwtBearerOptions using the settings in the JwtTokenOptions 
        /// </summary> 
        /// <returns>A configured JwtBearerOptions</returns> 
        public JwtBearerOptions CreateJwtBearerOptions()
        {
            var credentials = CreateCredentials(_tokenOptions.Base64Secret);
            return new JwtBearerOptions
            {
                TokenValidationParameters = new TokenValidationParameters
                {
                    IssuerSigningKey = credentials.Key,
                    ValidAudience = _tokenOptions.Audience,
                    ValidIssuer = _tokenOptions.Issuer,
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                },
            };
        }

        /// <summary> 
        /// Creates signing credentials using the key provided as a base64 string 
        /// </summary> 
        /// <param name="base64Secret">The base64 encoded secret key</param> 
        /// <returns>Signing credentials</returns> 
        private static SigningCredentials CreateCredentials(string base64Secret)
        {
            var key = new SymmetricSecurityKey(Convert.FromBase64String(base64Secret));
            return new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}