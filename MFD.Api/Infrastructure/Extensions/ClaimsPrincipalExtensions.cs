using MFD.Common.Api.Constants;
using MFD.Common.Api.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MFD.Common.Api.Extensions
{
    /// <summary> 
    /// The claims principal extensions. 
    /// </summary> 
    public static class ClaimsPrincipalExtensions
    {
        /// <summary> 
        /// The get user id. 
        /// </summary> 
        /// <param name="claims">The claims.</param> 
        /// <returns>The <see cref="int"/>.</returns> 
        public static int GetUserId(this IEnumerable<Claim> claims)
        {
            return GetId(claims, SecurityConstants.UserIdClaim);
        }

        /// <summary> 
        /// The get id. 
        /// </summary> 
        /// <param name="claims">The claims.</param> 
        /// <param name="claimId">The claim id.</param> 
        /// <returns>The <see cref="int"/>.</returns> 
        private static int GetId(IEnumerable<Claim> claims, string claimId)
        {
            var claim = GetClaim(claims, claimId);

            return int.Parse(claim.Value);
        }

        /// <summary> 
        /// The get claim. 
        /// </summary> 
        /// <param name="claims">The claims.</param> 
        /// <param name="claimId">The claim id.</param> 
        /// <returns>The <see cref="Claim"/>.</returns> 
        /// <exception cref="AuthorizationException">Claim is not found.</exception> 
        private static Claim GetClaim(IEnumerable<Claim> claims, string claimId)
        {
            var claim = claims.FirstOrDefault(c => c.Type == claimId);

            if (claim == null)
            {
                throw new AuthorizationException();
            }

            return claim;
        }
    }
}