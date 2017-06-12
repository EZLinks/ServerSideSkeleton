using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFD.Common.Api.Constants
{
    /// <summary> 
    /// <see cref="SecurityConstants"/> presents the security-related constant members for use everywhere in the code. 
    /// </summary> 
    public static class SecurityConstants
    {
        /// <summary> 
        /// The user id claim 
        /// </summary> 
        public const string UserIdClaim = "user_id";

        /// <summary> 
        /// The authentication cookie name 
        /// </summary> 
        public const string AuthCookieName = "access_token";

        /// <summary> 
        /// The authentication header 
        /// </summary> 
        public const string AuthHeader = "Authorization";
    }
}