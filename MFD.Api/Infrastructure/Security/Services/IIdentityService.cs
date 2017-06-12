using System.Security.Claims;
using MFD.Domain.Models;
using Microsoft.AspNetCore.Builder;

namespace MFD.Common.Api.Security.Services
{
    /// <summary> 
    /// A service used to manage a user's identity 
    /// </summary> 
    public interface IIdentityService
    {
        /// <summary> 
        /// Creates a token based off of the given user. 
        /// </summary> 
        /// <param name="user">The user to create a token for.</param> 
        /// <returns>The token string.</returns> 
        string CreateToken(User user);

        /// <summary> 
        /// Gets a user's claims identity. 
        /// </summary> 
        /// <param name="user">The user to create the identity for.</param> 
        /// <returns>A <see cref="ClaimsIdentity"/>.</returns> 
        ClaimsIdentity GetIdentity(User user);

        /// <summary> 
        /// Creates a JwtBearerOptions using the settings in the JwtTokenOptions 
        /// </summary> 
        /// <returns>A configured JwtBearerOptions</returns> 
        JwtBearerOptions CreateJwtBearerOptions();
    }
}