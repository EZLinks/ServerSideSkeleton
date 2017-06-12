using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideSkeleton.Authentication.Models
{
    /// <summary> 
    /// The information returned when attempting to get a token. 
    /// </summary> 
    [ExcludeFromCodeCoverage]
    public class TokenPostReturnModel
    {
        /// <summary> 
        /// The returned token. 
        /// </summary> 
        public string Token { get; set; }
    }
}