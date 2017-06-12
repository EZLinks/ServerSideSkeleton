using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MFD.Common.Api.Security.Models
{
    /// <summary> 
    /// Options for JWT token creation 
    /// </summary> 
    [ExcludeFromCodeCoverage]
    public class JwtTokenOptions
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
    }
}