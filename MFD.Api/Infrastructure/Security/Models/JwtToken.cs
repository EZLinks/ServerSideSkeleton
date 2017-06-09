using MFD.Common.Api.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MFD.Common.Api.Security.Models
{
    /// <summary> 
    /// jwt token model. 
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class JwtToken
    {
        /// <summary> 
        /// The principal 
        /// </summary> 
        private readonly ClaimsPrincipal _principal;

        /// <summary> 
        /// Initializes a new instance of the <see cref="JwtToken"/> class. 
        /// </summary> 
        /// <param name="principal">The principal.</param> 
        public JwtToken(ClaimsPrincipal principal)
        {
            _principal = principal;
        }

        /// <summary> 
        /// Gets the user identifier. 
        /// </summary> 
        /// <value> 
        /// The user identifier. 
        /// </value> 
        int UserId => _principal.Claims.GetUserId();
    }
}